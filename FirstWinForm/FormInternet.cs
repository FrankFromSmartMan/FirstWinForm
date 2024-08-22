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
        // 一個空的股票物件陣列
        public List<StockData> StockDatas { get; set; } = new List<StockData>();
        public FormInternet()
        {
            InitializeComponent();
            // 跑迴圈去搜尋所有控制項 (Controls代表畫面上當層的所有控制項)
            foreach (var control in Controls)
            {
                // 如果是按鈕
                if (control is Button)
                {
                    // (Button)把控制項強轉成按鈕類別。再去改它的Font屬性。
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
                    // 把每一行的雙引號都拿掉 (取代成空字串)
                    lines[i] = lines[i].Replace("\"", "");
                    // 跳過表頭
                    if (i == 0)
                    {
                        continue;
                    }
                    // 用逗號切割
                    var items = lines[i].Split(",").ToList();
                    // 若資料的欄為長度不對就跳過
                    if (items.Count < 2)
                    {
                        continue;
                    }
                    // 建立一個股票物件
                    StockData stockData = new StockData();
                    // 把原始檔案中的字串轉成物件屬性
                    stockData.ID = items[0];
                    stockData.StockName = items[1];
                    // 把字串轉成int(整數)或是double(小數點)，透過tryParse來先檢查可不可以轉換型態，不行的預設0
                    stockData.StockTraded = int.TryParse(items[2], out _) ? int.Parse(items[2]) : 0;
                    stockData.HighestAmount = double.TryParse(items[5], out _) ? double.Parse(items[5]) : 0;
                    stockData.AmountChanged = double.TryParse(items[8], out _) ? double.Parse(items[8]) : 0;
                    stocks.Add(stockData);
                    // 把股票資料加到陣列
                    StockDatas.Add(stockData);
                }
                // 顯示在grid
                dataGridViewData.DataSource = stocks;
            }
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // using在這裡代表程式結束後會對資源釋放
                using (var workbook = new XLWorkbook())
                {
                    // 新增一個活頁 (worksheeet)
                    var worksheet = workbook.Worksheets.Add("股票資訊");
                    // 把標頭寫到A1 ~ E1儲存格
                    worksheet.Cell("A1").Value = "證券代號";
                    worksheet.Cell("B1").Value = "證券名稱";
                    worksheet.Cell("C1").Value = "成交股數";
                    worksheet.Cell("D1").Value = "最高金額";
                    worksheet.Cell("E1").Value = "漲價跌差";
                    // 針對股票物件陣列去跑迴圈
                    for (int i = 0; i < StockDatas.Count; i++)
                    {
                        // 目前迴圈當前的股票物件 (第i個資料列)
                        var stock = StockDatas[i];
                        // 把每筆資料塞到目前Excel中的資料列 Cell(水平列位置、垂直欄位位置) 記得Excel起始值是從1開始不是0。
                        worksheet.Cell(i + 2, 1).Value = stock.ID;
                        worksheet.Cell(i + 2, 2).Value = stock.StockName;
                        worksheet.Cell(i + 2, 3).Value = stock.StockTraded;
                        worksheet.Cell(i + 2, 4).Value = stock.HighestAmount;
                        worksheet.Cell(i + 2, 5).Value = stock.AmountChanged;
                        // 根據漲跌條件顯示綠色或紅色
                        if (stock.AmountChanged > 0)
                        {
                            // set to green
                            worksheet.Cell(i + 2, 5).Style.Font.FontColor = XLColor.Green;
                        }
                        else
                        {
                            worksheet.Cell(i + 2, 5).Style.Font.FontColor = XLColor.Red;
                        }
                    }
                    // 把Excel存起來
                    workbook.SaveAs("stockReport.xlsx");
                    // 開檔案
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = "stockReport.xlsx",
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                // 跳出可能發生的錯誤
                MessageBox.Show(ex.Message);
            }
        }
    }
}
