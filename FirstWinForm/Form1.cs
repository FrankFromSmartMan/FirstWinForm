using Dapper;

using System.Data.SqlClient;
using System.Diagnostics;

namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        public string ConnString { get; set; }
        public Form1()
        {
            InitializeComponent();

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 前往頁面: https://www.moneydj.com/tax/content.djhtm?a=02-04
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://www.moneydj.com/tax/content.djhtm?a=02-04"
            };
            Process.Start(psi);
        }

        private void ButtonGetNetTax_Click(object sender, EventArgs e)
        {
            int taxIncome = int.Parse(textBoxTaxIncome.Text);
            int taxFree = int.Parse(textBoxTaxFree.Text);
            int deduction = int.Parse(textBoxDeduction.Text);
            int specialDeduction = int.Parse(textBoxSpecialDeduction.Text);
            // 所得淨額
            int netIncome = taxIncome - taxFree - deduction - specialDeduction;
            // 修改所得淨額文字
            labelNetIncome.Text = "所得淨額 = " + netIncome;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // 判斷textbox有沒有出現逗號
            bool hasComma = textBoxName.Text.Contains(",");
            // 如果沒有逗號，直接加進去textbox
            if (hasComma == false)
            {
                // 讀取textbox的名字
                string name = textBoxName.Text;
                // 把名稱塞到listbox
                listBoxNames.Items.Add(name);
                // 清除textbox
                textBoxName.Clear();
            }
            else
            {
                string[] names = textBoxName.Text.Split(",");
                for (int i = 0; i < names.Length; i++)
                {
                    string name = names[i].Trim();
                    listBoxNames.Items.Add(name);
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // 先看使用者有沒有點listbox的名稱
            int selectedIndex = listBoxNames.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("請選擇一個名稱");
                return;
            }
            // 有點的話刪除listbox那個名稱
            listBoxNames.Items.RemoveAt(selectedIndex);
            // 刪除成功跳個訊息
            MessageBox.Show("刪除成功!!!");
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // 測試是否可以連到資料庫
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"
                        Server=localhost;
                        Database=HRIS;
                        User Id=SYSADM;
                        Password=SYSADM";
                this.ConnString = conn.ConnectionString;
                // 使用 builder
                //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                //// 伺服器
                //builder.DataSource = "localhost";
                //builder.InitialCatalog = "HRIS";
                //builder.UserID = "SYSADM";
                //builder.Password = "SYSADM";

                //conn.ConnectionString = builder.ConnectionString;

                // 可以或失敗都跳出訊息
                conn.Open();
                MessageBox.Show("連線成功!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message + "哪裡錯?" + ex.StackTrace);
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnString;
            conn.Open();
            List<Employee> employees = new List<Employee>();
            employees = conn.Query<Employee>("Select * From Employee").ToList();
            conn.Close();
            dataGridView1.DataSource = employees;
            // hide birthday column
            dataGridView1.Columns["Birthday"].Visible = false;
        }
    }
}
