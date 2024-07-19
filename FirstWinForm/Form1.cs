using System.Diagnostics;

namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 前往頁面: https://www.moneydj.com/tax/content.djhtm?a=02-04
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://www.moneydj.com/tax/content.djhtm?a=02-04"
            };
            Process.Start(psi);
        }

        private void buttonGetNetTax_Click(object sender, EventArgs e)
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
    }
}
