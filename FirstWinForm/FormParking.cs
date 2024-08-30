using FirstWinForm.DataModels;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class FormParking : Form
    {
        public FormParking()
        {
            InitializeComponent();
            blueButtonContainer1.InnerButton.Click += InnerButton_Click;
            blueButtonContainer1.InnerButton.Text = "下載資料";
        }

        private void InnerButton_Click(object? sender, EventArgs e)
        {
            const string url = "https://data.tycg.gov.tw/opendata/datalist/datasetMeta/download?id=f4cc0b12-86ac-40f9-8745-885bddc18f79&rid=0daad6e6-0632-44f5-bd25-5e1de1e9146f";
            using (HttpClient http = new HttpClient())
            {
                var result = http.GetStringAsync(url).Result;
                ParkingLotAPIResponse parkingLotAPIResponse = JsonSerializer.Deserialize<ParkingLotAPIResponse>(result) ?? new ParkingLotAPIResponse();
                dataGridView1.DataSource = parkingLotAPIResponse.ParkingLots;
                MessageBox.Show("下載成功");
            }
        }
    }
}
