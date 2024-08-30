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
              
                List<string> headerNames = ["停車場編號","區域ID","區域名稱","停車場名稱","總停車格數量","狀態","剩餘空間","價格資訊","說明","位址","經度","緯度"];
                // set datagridview header names to above
                for (int i = 0; i < headerNames.Count; i++)
                {
                    dataGridView1.Columns[i].HeaderText = headerNames[i];
                }
                using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    workbook.SaveAs("停車場資訊.xlsx");
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() { FileName = "停車場資訊.xlsx", UseShellExecute = true });
                    
                };
                MessageBox.Show("下載成功");
            }
        }
    }
}
