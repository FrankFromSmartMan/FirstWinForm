using FirstWinForm.DataModels;

using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.Painting.Effects;

namespace FirstWinForm
{
    public partial class FormParking : Form
    {
        public FormParking()
        {
            InitializeComponent();
            blueButtonContainer1.InnerButton.Click += InnerButton_Click;
            blueButtonContainer1.InnerButton.Text = "下載資料";


            string[] types = ["礦石", "武器", "裝備", "補給品", "掉落物"];
            int[] values = [9490, 2370, 2040, 1210, 9995];
            List<ISeries> pieCharts = [];
            string[] lighterColors = [ "#ffccd0", "#ffdbb5", "#fff9cc", "#b1daff", "#e5c5ff" ]; // 最淺的顏色清單
            string[] colors = ["#ff98a1", "#ffb482", "#fff49d", "#82c2ff", "#d395ff"]; // 中等顏色清單
            string[] darkerColors = ["#ff8989", "#ffba84", "#eeffac", "#8cb6dd", "#8f52db"]; // 最深的顏色清單
            for (int i = 0; i < types.Length; i++)
            {
                var type = i + "-->" + types[i]; // 種類
                var value = values[i]; // 數值
                int ratio = (int)((value / (decimal)values.Sum()) * 100); // 比例 (先算出小數點再轉乘整數)
                pieCharts.Add(new PieSeries<int>
                {
                    Name = type, // 區域名稱 (滑鼠移過去的標題)
                    Values = [value], // 圓餅數值大小
                    // 圓餅圖的填充顏色 (這裡是用漸層顏色，可以塞多個顏色)
                    Fill = new RadialGradientPaint([
                            SKColor.Parse(lighterColors[i]),
                            SKColor.Parse(colors[i]),
                            SKColor.Parse(darkerColors[i])
                        ]),
                    // 圓餅圖的標籤顏色為黑色
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    // 圓餅圖上的標籤格式=區域名稱: 停車場數量
                    DataLabelsFormatter = x => $"[Labe] {type}: ${value:n0}。({ratio}%)",
                    // 滑鼠游標移過去顯示的明細
                    ToolTipLabelFormatter = x => $"[Tooltip] ${value:n0}。({ratio}%)",
                    // 圓餅圖的推出去距離
                    Pushout = 10,
                    // 圓餅圖的外框線樣式
                    Stroke = new SolidColorPaint(SKColors.DarkBlue, strokeWidth: 2),
                    // 外層圓餅圖的半徑偏移量
                    OuterRadiusOffset = i * 50
                });
            }
            pieChart1.Series = pieCharts;

        }

        private void InnerButton_Click(object? sender, EventArgs e)
        {
            // const 代表這個變數是常數，不可變更
            const string url = "https://data.tycg.gov.tw/opendata/datalist/datasetMeta/download?id=f4cc0b12-86ac-40f9-8745-885bddc18f79&rid=0daad6e6-0632-44f5-bd25-5e1de1e9146f";
            using (HttpClient http = new HttpClient())
            {
                var result = http.GetStringAsync(url).Result;
                // 使用Deserialize反序列化JSON資料，轉成物件
                ParkingLotAPIResponse parkingLotAPIResponse = JsonSerializer.Deserialize<ParkingLotAPIResponse>(result) ?? new ParkingLotAPIResponse();
                dataGridView1.DataSource = parkingLotAPIResponse.ParkingLots;

                List<string> headerNames = ["停車場編號", "區域ID", "區域名稱", "停車場名稱", "總停車格數量", "狀態", "剩餘空間", "價格資訊", "說明", "位址", "經度", "緯度"];
                // set datagridview header names to above
                for (int i = 0; i < headerNames.Count; i++)
                {
                    dataGridView1.Columns[i].HeaderText = headerNames[i];
                }
                using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    // 新增活頁1
                    var worksheet = workbook.Worksheets.Add("原始停車資料");
                    // 把標題放到第一列
                    for (int i = 0; i < headerNames.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = headerNames[i];
                    }
                    // 直接把陣列放到整個工作表
                    worksheet.Cell(2, 1).InsertData(parkingLotAPIResponse.ParkingLots);
                    // 新增活頁2
                    var worksheet2 = workbook.Worksheets.Add("停車場統計資料");
                    // 統計前十名的停車格數量最多的停車場
                    var top10 = parkingLotAPIResponse.ParkingLots.OrderByDescending(p => p.TotalSpace).Take(10).ToList();
                    worksheet2.Cell(1, 1).Value = "停車場名稱";
                    worksheet2.Cell(1, 2).Value = "地址";
                    worksheet2.Cell(1, 3).Value = "停車格數量";
                    for (int i = 0; i < top10.Count; i++)
                    {
                        worksheet2.Cell(i + 2, 1).Value = top10[i].ParkName;
                        worksheet2.Cell(i + 2, 2).Value = top10[i].Address;
                        worksheet2.Cell(i + 2, 3).Value = top10[i].TotalSpace;
                    }
                    // 使用區域groupby資料放到不同活頁
                    var groupByArea = parkingLotAPIResponse.ParkingLots.GroupBy(p => p.AreaName);
                    foreach (var group in groupByArea)
                    {
                        // 根據區域名稱新增活頁 (group.Key為每個分群是依照什麼去分的，也就是區域名稱)
                        var worksheetByArea = workbook.Worksheets.Add(group.Key);
                        // 用Where去篩選出區域名稱相同的停車場 (每分群裡面都是停車物件資訊，group.ToList()把這些物件資料轉成陣列)
                        var parkLotsByArea = group.ToList();
                        for (int i = 0; i < headerNames.Count; i++)
                        {
                            worksheetByArea.Cell(1, i + 1).Value = headerNames[i];
                        }
                        worksheetByArea.Cell(2, 1).InsertData(parkLotsByArea);
                    }
                    //workbook.SaveAs("Parklot.xlsx");
                    //ProcessStartInfo psi = new ProcessStartInfo()
                    //{
                    //    FileName = "Parklot.xlsx",
                    //    UseShellExecute = true,
                    //};
                    //System.Diagnostics.Process.Start(psi);
                }
                // 用區域名稱groupby
                var groupedByAreaName = parkingLotAPIResponse.ParkingLots.GroupBy(g => g.AreaName);
                // 用Select去選取區域名稱和總停車格數量
                // new { ... } => 匿名型別 
                var totalSpacesByAreaName = groupedByAreaName.Select(g => new 
                { 
                    areaName = g.Key, // 區域名稱
                    totalSpaces = g.Sum(p => p.TotalSpace) // 停車位數量
                }).ToList();
                // 產生圖表 (折線圖) 內容為一個各種Series(表)的陣列
                // 原本是 new ISeries[] {...}，這裡使用語法[...] 去簡化，表示一個陣列
                cartesianChart1.Series =
                [
                    new LineSeries<int>
                    {
                        Values = totalSpacesByAreaName.Select(t => t.totalSpaces) // 用Select選取總停車格數量
                    },
                ];
                // 設定圖表上方的標題
                cartesianChart1.Title = new LabelVisual
                {
                    Text = "每個區域的停車場總數量",
                    TextSize = 25,
                    Padding = new LiveChartsCore.Drawing.Padding(15),
                    Paint = new SolidColorPaint(SKColors.DarkSlateGray)
                };
                // 設定X軸的資訊
                cartesianChart1.XAxes =
                [
                    new Axis
                    {
                        //設定X軸的標籤，使用Select選取區域名稱，最後用ToList()轉成陣列
                        Labels = totalSpacesByAreaName.Select(t => t.areaName).ToList(),
                        Name = "區域名稱",
                        NamePaint = new SolidColorPaint(SKColors.Black),
                        LabelsPaint = new SolidColorPaint(SKColors.Blue),
                        TextSize = 16,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) { StrokeThickness = 2 }
                    }
                ];
                // 設定Y軸的資訊
                cartesianChart1.YAxes =
                [
                    new Axis
                    {
                        Name = "停車位數量",
                        NamePaint = new SolidColorPaint(SKColors.Red),
                        LabelsPaint = new SolidColorPaint(SKColors.Green),
                        TextSize = 20,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                        {
                            StrokeThickness = 2,
                            PathEffect = new DashEffect([3, 3])
                        }
                    }
                ];
                // groupby停車場名稱->Sum停車格數量->OrderByDescending停車格數量->Take(10)取前10名->ToList轉成陣列 (chained methods/functions)
                var top10ParkingLots = parkingLotAPIResponse.ParkingLots
                    .GroupBy(g => g.ParkName) // 用停車場名稱去groupby
                    .Select(g => new // 用SELECT與匿名型別 new { ... } 語法去抓取自訂的值。
                    {
                        parkName = g.Key,
                        totalSpaces = g.Sum(p => p.TotalSpace),
                    })
                    .OrderByDescending(p => p.totalSpaces) // 大到小排序
                    .Take(10) // 取得前10筆
                    .ToList(); // 轉成陣列
                // 顯示直條圖
                cartesianChart2.Series = 
                [
                    // 設定直條圖物件 (值是int整數型態)
                    new ColumnSeries<int>
                    {
                        Values = top10ParkingLots.Select(t => t.totalSpaces).ToList(), // 選取停車格數量
                    }
                ];
                // 設定圖表上方的標題
                cartesianChart2.Title = new LabelVisual
                {
                    Text = "前十名停車位最多的停車場",
                    TextSize = 25,
                    Padding = new LiveChartsCore.Drawing.Padding(15),
                    Paint = new SolidColorPaint(SKColors.DarkSlateGray)
                };
                // 設定X軸的資訊
                cartesianChart2.XAxes =
                [
                    new Axis
                    {
                        //設定X軸的標籤，使用Select選取停車場名稱，最後用ToList()轉成陣列
                        Labels = top10ParkingLots.Select(t => t.parkName).ToList(),
                        Name = "停車場名稱",
                        TextSize = 16,
                        LabelsRotation = 45 // 各停車場名稱旋轉45度，才不會太擠
                    }
                ];
                // 設定Y軸的資訊
                cartesianChart2.YAxes =
                [
                    new Axis
                    {
                        Name = "停車位數量",
                        NamePaint = new SolidColorPaint(SKColors.Red),
                        LabelsPaint = new SolidColorPaint(SKColors.Green),
                        TextSize = 20,
                        SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                        {
                            StrokeThickness = 2,
                            PathEffect = new DashEffect([3, 3])
                        }
                    }
                ];
                // 產生圓餅圖: 先用停車場數量大到小排序，再用Select選取區域名稱和總停車格數量
                pieChart1.Series = totalSpacesByAreaName
                    .OrderByDescending(t => t.totalSpaces)
                    // 這裡每個Select都要建一個PieSeries物件
                    .Select(t => new PieSeries<int>
                {
                    // 這裡是圓餅圖的值，這裡是停車位數量
                    Values = new List<int> { t.totalSpaces },
                    Name = t.areaName,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 22,
                    // for more information about available positions see:
                    // https://livecharts.dev/api/2.0.0-rc2/LiveChartsCore.Measure.PolarLabelsPosition
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    // 設定圓餅圖上的標籤格式=區域名稱: 停車場數量
                    DataLabelsFormatter = p => t.areaName + ": " + t.totalSpaces
                })
                    .ToList();
                // 設定圖表上方的標題
                pieChart1.Title = new LabelVisual
                {
                    Text = "桃園市停車位數量圓餅圖",
                    TextSize = 25,
                    Padding = new LiveChartsCore.Drawing.Padding(15),
                    Paint = new SolidColorPaint(SKColors.DarkSlateGray)
                };
                MessageBox.Show("下載成功");
            }
        }
    }
}
