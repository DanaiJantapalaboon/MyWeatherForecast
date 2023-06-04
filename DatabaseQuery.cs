using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using ClosedXML.Excel;

namespace DatabaseQuery.Database
{
    public class Database
    {

        // MySQL Connection ห้ามลบ แก้ไขได้
        MySqlConnection conn = new MySqlConnection("host = localhost; user = root; password = 1234; database = myweather");
        MySqlCommand command;

        public void updateTable(DataGridView weatherTable)
        {
            try
            {
                string loadTable = "SELECT * FROM myweather.recordedWeather";
                MySqlDataAdapter adapterTable = new MySqlDataAdapter(loadTable, conn);

                DataTable table = new DataTable();
                adapterTable.Fill(table);
                weatherTable.DataSource = table;

                // ซ่อน id column
                weatherTable.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("ไม่สามารถดึงข้อมูลจากฐานข้อมูลได้ กรุณาตรวจสอบการเชื่อมต่อ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void executeQuery(string query)
        {
            try
            {
                conn.Open();
                command = new MySqlCommand(query, conn);

                if (command.ExecuteNonQuery() == 1)
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        public void deleteALL()
        {
            DialogResult dialog = MessageBox.Show("ข้อมูลบันทึกทั้งหมดจะหายหมดเลย ท่านต้องการลบหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string deleteALL = "DELETE FROM myweather.recordedWeather";

                executeQuery(deleteALL);
            }
        }


        public void exportExcel(DataGridView weatherTable)
        {

            string loadTable = "SELECT * FROM myweather.recordedWeather";
            MySqlDataAdapter adapterTable = new MySqlDataAdapter(loadTable, conn);

            DataTable table = new DataTable();
            adapterTable.Fill(table);
            weatherTable.DataSource = table;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(table, "myweather.recordedWeather");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("ส่งออกไฟล์ excel สำเร็จแง้ว", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void textBoxSearch(DataGridView weatherTable, TextBox tbSearch)
        {

            string loadTable = "SELECT * FROM myweather.recordedWeather";
            MySqlDataAdapter adapterTable = new MySqlDataAdapter(loadTable, conn);

            DataTable table = new DataTable();
            adapterTable.Fill(table);
            weatherTable.DataSource = table;

            string searchValue = tbSearch.Text;

            var matchingRows = table.AsEnumerable().Where(row =>
            {
                foreach (var item in row.ItemArray)
                {
                     if (item.ToString().Contains(searchValue))
                     {
                         return true;
                     }
                }
                return false;
            });

            DataTable filteredTable = matchingRows.CopyToDataTable();
            weatherTable.DataSource = filteredTable;

        }


        public void deleteData(DataGridView weatherTable)
        {
            try
            {
                string txtidSearch = weatherTable.CurrentRow.Cells[0].Value.ToString();
                string delete = "DELETE FROM myweather.recordedWeather WHERE id = '" + txtidSearch + "'";

                DialogResult dialog = MessageBox.Show("คุณต้องการลบรายการที่เลือกหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    executeQuery(delete);
                }
            }
            catch
            {
                MessageBox.Show("ไม่พบข้อมูลในตาราง", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
