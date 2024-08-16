using Microsoft.VisualBasic;

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
    public partial class FormFiles : Form
    {
        // 物品陣列
        List<Item> items = new List<Item>();
        public FormFiles()
        {
            InitializeComponent();
            // 註冊點擊事件 +=
            buttonOpenFile.Click += ButtonOpenFile_Click;
        }

        private void ButtonOpenFile_Click(object? sender, EventArgs e)
        {
            // 開啟檔案dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // 設定檔案類型 (CSV)
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            // 開啟檔案dialog
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // 顯示剛抓檔案的名稱
                labelFileName.Text = openFileDialog.FileName;
                // 讀取檔案的內容 (讀取的每一行塞到data字串陣列string[]) 950 	big5
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                // 先清空listbox的items
                listBoxFileData.Items.Clear();
                foreach (var line in lines)
                {
                    listBoxFileData.Items.Add(line);
                }
                // 把資料呈現到dataGridView 
                // 跑迴圈一個一個到進去上面的item陣列
                for (var i = 0; i < lines.Length; i++)
                {
                    // 跳過第0個
                    if (i == 0)
                    {
                        continue; // continue可以跳過這一圈，直接進入下一圈
                    }
                    string line = lines[i]; // 方括號可以抓第i行的資料
                    var splitData = line.Split(","); // 用後號分割，分割完後回傳字串陣列string[]
                    Item item = new Item();
                    item.Name = splitData[0]; // 第一個是名稱
                    item.Type = splitData[1];
                    item.MarketValue = splitData[2];
                    item.Quantity = int.Parse(splitData[3]); // 因為Quanity我定義是數字，所以要轉型
                    item.Description = splitData[4];
                    items.Add(item); // 把建立好的 item 加到 items 陣列
                }
                dataGridViewFileData.DataSource = items; // 把 items 顯示在 grid 上面
            }
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            // 將匯入的資料再轉出去一次，但是可以指定路徑
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            // 開啟存檔案dialog
            var result = saveFileDialog.ShowDialog();
            // 建立空的字串行資料
            List<string> lines = new List<string>();
            // 若使用者按下OK
            if (result == DialogResult.OK)
            {
                // 檔案名稱
                string filePath = saveFileDialog.FileName;
                lines.Add("名稱,種類,價值,數量,描述");
                // 把lines塞滿資料
                foreach (var item in items)
                {
                    string singleLineData = item.Name + "," + item.Type + "," + item.MarketValue + "," + item.Quantity.ToString() + "," + item.Description;
                    lines.Add(singleLineData);
                }
                // 把剛剛匯入的資料寫道指定檔案中
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
                MessageBox.Show("儲存到" + filePath + "了!");
                // 要先引用在最上方 using System.Diagnostics
                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                // 開啟檔案
                Process.Start(processStartInfo);
            }
        }
    }
}
