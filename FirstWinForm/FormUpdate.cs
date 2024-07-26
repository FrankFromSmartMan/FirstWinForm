using Dapper;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class FormUpdate : Form
    {
        // 建構子 constructor
        Employee employee;
        public FormUpdate(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            // 初始化員工資料
            this.textBox1.Text = employee.EMPLOYECD;
            this.textBox2.Text = employee.ChineseName;
            this.textBox3.Text = employee.EnglishName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 存檔
            SqlConnection conn = new SqlConnection(EmployeeService.ConnString);
            conn.Open();
            string employeCd = this.textBox1.Text; // EmployeCd
            string updatedChineseName = textBox2.Text;
            string updatedEnglishName = textBox3.Text;
            conn.Execute("Update Employee Set ChineseName = '" + updatedChineseName + "' , EnglishName = @updatedEnglishName Where EmployeCd = @EmployeCd", 
                new { updatedEnglishName, employeCd }
                );
            MessageBox.Show("存檔成功");
            Close();
        }
    }
}
