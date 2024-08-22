using ClosedXML.Excel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class FormInternet : Form
    {
        public FormInternet()
        {
            InitializeComponent();
            foreach (var control in Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Font = new Font(FontFamily.GenericSerif, 14);
                }
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            // 畫面上的URL存起來
            string url = textBoxURL.Text;
            // 透過URL位置去把檔案抓下來 httpClient
            using (HttpClient httpClient = new HttpClient())
            {
                var data = httpClient.GetStringAsync(url).Result;
                // 抓下來的檔案先存起來，檔案名稱為stock.csv
                File.WriteAllText("stock.csv", data);

                // 直接開啟檔案
                //ProcessStartInfo psi = new ProcessStartInfo()
                //{
                //    FileName = "stock.csv",
                //    UseShellExecute = true
                //};
                //Process.Start(psi);

                // 根據換行符號/r/n切割把資料塞到陣列中
                List<string> lines = new List<string>();
                lines = data.Split("\r\n").ToList();
                // 把資料呈現到listbox
                foreach (var line in lines)
                {
                    listBoxFileData.Items.Add(line);
                }
                // 用類別把資料接起來
                List<StockData> stocks = new List<StockData>();

                for (int i = 0; i < lines.Count; i++)
                {
                    lines[i] = lines[i].Replace("\"", "");
                    if (i == 0)
                    {
                        continue;
                    }
                    var items = lines[i].Split(",").ToList();
                    if (items.Count < 2)
                    {
                        continue;
                    }
                    StockData stockData = new StockData();
                    stockData.ID = items[0];
                    stockData.StockName = items[1];
                    // Generate rest
                    stockData.StockTraded = int.TryParse(items[2], out _) ? int.Parse(items[2]) : 0;
                    stockData.HighestAmount = double.TryParse(items[5], out _) ? double.Parse(items[5]) : 0;
                    stocks.Add(stockData);
                }
                dataGridViewData.DataSource = stocks;
            }
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "Hello World!";
                worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
                workbook.SaveAs("HelloWorld.xlsx");
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "HelloWorld.xlsx",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}
