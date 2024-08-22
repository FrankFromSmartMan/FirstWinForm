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
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "stock.csv",
                    UseShellExecute = true
                };
                Process.Start(psi);

                // 根據換行符號/r/n切割把資料塞到陣列中
                List<string> lines = new List<string>();
                lines = data.Split("\r\n").ToList();
                // 把資料呈現到listbox
                foreach (var line in lines)
                {
                    listBoxFileData.Items.Add(line);
                }
                // 用類別把資料接起來
                // List<StockData> stocks = new List<StockData>();
            }
        }
    }
}
