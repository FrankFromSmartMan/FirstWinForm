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
                // 讀取檔案的內容 (讀取的每一行塞到data字串陣列string[])
                string[] items = File.ReadAllLines(openFileDialog.FileName);
                // 先清空listbox的items
                listBoxFileData.Items.Clear();
                foreach (var item in items)
                {
                    listBoxFileData.Items.Add(item);
                }
            }
        }

        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {

        }
    }
}
