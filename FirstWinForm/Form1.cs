namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int myVarLabel = 0; ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalNetpay_Click(object sender, EventArgs e)
        {
            int nTaxincome = int.Parse(Taxincome.Text);

        }
    }
}
