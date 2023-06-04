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

// using class จากไฟล์ DatabaseQuery.cs
using DatabaseQuery.Database;


namespace MyWeatherForecast
{
    public partial class Form1 : Form
    {

        // My APIKey ห้ามลบ
        string APIKey = "fe1905e9017405e8f89b295caccc7eab";


        private Database dbQuery;
        public Form1()
        {
            InitializeComponent();
            dbQuery = new Database();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dbQuery.updateTable(weatherTable);
        }

        private void getWeather()
        {

            try
            {

                // รับ input from textbox
                string inputCity = tbCity.Text;
                // ปรับ input ชื่อเมืองตัวแรกให้เป็นอักษรพิมพ์ใหญ่
                string upperCaseCity = char.ToUpper(inputCity[0]) + inputCity.Substring(1);


                // แปลงวันเวลาให้เป็น MM-DD-YYYY
                DateTime convertDateTime(long millisec)
                {
                    DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    day = day.AddSeconds(millisec).ToLocalTime();
                    return day;
                }


                using (WebClient web = new WebClient())
                {

                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=en", upperCaseCity, APIKey);
                    var json = web.DownloadString(url);

                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    // เก็บพระอาทิตย์ขึ้น
                    string sunrise = convertDateTime(Info.sys.sunrise).ToString();
                    labSunrise.Text = "Sunrise : " + sunrise;

                    // เก็บพระอาทิตย์ตก
                    string sunset = convertDateTime(Info.sys.sunset).ToString();
                    labSunset.Text = "Sunset : " + sunset;

                    // เก็บความเร็วลม Windspeed
                    string windspeed = Info.wind.speed.ToString();
                    labWindspeed.Text = "Windspeed : " + windspeed + " m/s";

                    // เก็บความกดอากาศ MSL
                    string MSLPressure = Info.main.pressure.ToString();
                    labPressure.Text = "MSL Pressure : " + MSLPressure + " hPa";

                    // เก็บความชื้นในอากาศ RH
                    string RelativeHumid = Info.main.humidity.ToString();
                    labHumidity.Text = "Relative Humidity : " + RelativeHumid + " %";


                    // เก็บอุณหภูมิ FeelLike
                    string tempFeelLike = Info.main.feels_like.ToString();
                    // เก็บรายละเอียดสภาพอากาศ
                    string weatherDescription = Info.weather[0].description;
                    // เก็บสภาพอากาศ
                    string weather = Info.weather[0].main;
                    // แสดงบรรทัด Feels Like
                    labRealFeel.Text = "Feels Like " + tempFeelLike + " °C. " + weatherDescription + ". " + weather + ".";


                    // แสดง DateTime
                    DateTime currentDateTime = DateTime.Now;
                    labDateTime.Text = currentDateTime.ToString();
                    // ปรับ format สำหรับ store ลง db
                    string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");


                    // Temp. - แปลงทศนิยมเป็นจำนวนเต็ม
                    double storeTemp = Info.main.temp;
                    labTemp.Text = Convert.ToInt32(storeTemp).ToString() + " °C";


                    // เก็บชื่อประเทศ
                    string country = Info.sys.country.ToString();
                    // แสดงชื่อเมือง + ประเทศ
                    labCity.Text = upperCaseCity.ToString() + ", " + country;


                    // เคลียร์ Input หลังจากกดปุ่มค้นหา
                    tbCity.Clear();


                    // -- ส่วน Insert Database -- //
                    string append = "INSERT INTO myweather.recordedWeather (Date, City, Country, Temp, FeelLike, Weather, WeatherDetail, Windspeed, MSLPressure, RH, Sunset, Sunrise)" +
                                    "VALUES ('" + formattedDateTime + "' , '" + upperCaseCity + "', '" + country + "', '" + storeTemp + "', '" + tempFeelLike + "', '" + weather + "', '" + weatherDescription + "', '" + windspeed + "', '" + MSLPressure + "', '" + RelativeHumid + "', '" + sunset + "', '" + sunrise + "')";

                    dbQuery.executeQuery(append);
                    dbQuery.updateTable(weatherTable);
                }
            }

            catch
            {
                MessageBox.Show("ไม่พบข้อมูล กรุณาตรวจสอบอีกครั้งจ้า (ภาษาอังกฤษเท่านั้น)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void menuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void weatherTable_MouseClick(object sender, MouseEventArgs e)
        {
            tbCity.Text = weatherTable.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resultText = "MyWeather Forecast - Version 1.00a (Free)\n\n" +
                                "Weather API : openweathermap.org (API Key from danai.j (me))\nDatabase : MySQL Workbench 8.0CE\nExport .xlsx library : closedXML 0.95.4\nProgrammer : Danai Jantapalaboon\nAssistant Programmer : ChatGPT\n---------------------------------------------------\nโปรแกรมแจกฟรีในกลุ่ม .NET Thailand เท่านั้น\n4 มิถุนายน 2566";
            MessageBox.Show(resultText, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbQuery.updateTable(weatherTable);
        }

        private void deleteHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbQuery.deleteALL();
            dbQuery.updateTable(weatherTable);
        }

        private void btnDeleteALL_Click(object sender, EventArgs e)
        {
            dbQuery.deleteALL();
            dbQuery.updateTable(weatherTable);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dbQuery.exportExcel(weatherTable);
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbQuery.exportExcel(weatherTable);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dbQuery.textBoxSearch(weatherTable, tbSearch);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbQuery.deleteData(weatherTable);
            dbQuery.updateTable(weatherTable);
        }
    }
}
