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
                EmployeeService.ConnString = conn.ConnectionString;
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
            // hide birthday column 隱藏欄位
            dataGridView1.Columns["Birthday"].Visible = false;
            // set so whole row is selected 讓整行被選取
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // can only select one row at a time 不可以多選
            dataGridView1.MultiSelect = false;
            // read only
            dataGridView1.ReadOnly = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // get the Employee data from row
            // 把員工資料抓出來
            Employee employee = new Employee();
            if (isSelected)
            {
                employee.ChineseName = dataGridView1.SelectedRows[0].Cells["ChineseName"].Value.ToString();
                employee.EnglishName = dataGridView1.SelectedRows[0].Cells["EnglishName"].Value.ToString();
                employee.EMPLOYECD = dataGridView1.SelectedRows[0].Cells["EMPLOYECD"].Value.ToString();
            }
            else
            {
                MessageBox.Show("請選擇一個員工");
                return;
            }
            FormUpdate formUpdate = new FormUpdate(employee);
            formUpdate.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            bool isSelected = dataGridView1.SelectedRows.Count > 0;
            // 檢查有沒有選一行資料列
            if (isSelected == false)
            {
                MessageBox.Show("請選擇一個員工");
                return;
            }
            string employeCd = dataGridView1.SelectedRows[0].Cells["EmployeCd"].Value.ToString();
            string employeeName = dataGridView1.SelectedRows[0].Cells["ChineseName"].Value.ToString();
            // 跳訊息確定是否要刪除
            var result = MessageBox.Show("確定要刪除" + employeeName + "嗎?", "刪除員工", MessageBoxButtons.YesNo);
            // 如果選NO就結束
            if (result == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Execute("Delete From Employee Where Employecd = @EmployeCd", new { employeCd });
            MessageBox.Show("刪除成功");
            conn.Close();
        }
    }
}
