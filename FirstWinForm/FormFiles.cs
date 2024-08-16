using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class FormFiles : Form
    {
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
                foreach (var item in lines)
                {
                    listBoxFileData.Items.Add(item);
                }
                // 把資料呈現到dataGridView 
                // 先建立陣列item
                List<Item> items = new List<Item>();
                // 跑迴圈一個一個到進去上面的item陣列
                for (var i = 0; i < lines.Length;  i++)
                {
                    var splitData = lines[i].Split(","); // 用後號分割，分割完後回傳字串陣列string[]
                    Item item = new Item();
                    item.Name = splitData[0]; // 第一個是名稱
                    item.Type = splitData[1];
                    item.MarketValue = splitData[2];
                    item.Quantity = splitData[3];
                    item.Description = splitData[4];
                    items.Add(item); // 把建立好的 item 加到 items 陣列
                }
                dataGridViewFileData.DataSource = items; // 把 items 顯示在 grid 上面
            }
        }
    }
}
