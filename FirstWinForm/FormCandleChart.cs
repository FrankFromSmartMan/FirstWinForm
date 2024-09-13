using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace FirstWinForm
{
    public partial class FormCandleChart : Form
    {

        public FormCandleChart()
        {
            InitializeComponent();
            var data = new FinancialData[]
            {
                new(new DateTime(2021, 1, 1), 523, 500, 450, 400),
                new(new DateTime(2021, 1, 2), 500, 450, 425, 400),
                new(new DateTime(2021, 1, 3), 490, 425, 400, 380),
                new(new DateTime(2021, 1, 4), 420, 400, 420, 380),
                new(new DateTime(2021, 1, 5), 520, 420, 490, 400),
                new(new DateTime(2021, 1, 6), 580, 490, 560, 440),
                new(new DateTime(2021, 1, 7), 570, 560, 350, 340),
                new(new DateTime(2021, 1, 8), 380, 350, 380, 330),
                new(new DateTime(2021, 1, 9), 440, 380, 420, 350),
                new(new DateTime(2021, 1, 10), 490, 420, 460, 400),
                new(new DateTime(2021, 1, 11), 520, 460, 510, 460),
                new(new DateTime(2021, 1, 12), 580, 510, 560, 500),
                new(new DateTime(2021, 1, 13), 600, 560, 540, 510),
                new(new DateTime(2021, 1, 14), 580, 540, 520, 500),
                new(new DateTime(2021, 1, 15), 580, 520, 560, 520),
                new(new DateTime(2021, 1, 16), 590, 560, 580, 520),
                new(new DateTime(2021, 1, 17), 650, 580, 630, 550),
                new(new DateTime(2021, 1, 18), 680, 630, 650, 600),
                new(new DateTime(2021, 1, 19), 670, 650, 600, 570),
                new(new DateTime(2021, 1, 20), 640, 600, 610, 560),
                new(new DateTime(2021, 1, 21), 630, 610, 630, 590)
            };
            cartesianChart1.Series =
            [
                // 使用LiveChartCore.Defaults.FinancialPointI的指定型態才能去畫K線圖
                new CandlesticksSeries<FinancialPointI>
                {
                    // 把我們的資料轉換成FinancialPointI型態
                    Values = data.Select(x => new FinancialPointI(x.High, x.Open, x.Close, x.Low)).ToArray(),
                    // 設定滑鼠游標移過去顯示的資訊
                    YToolTipLabelFormatter = x => $"最高: {x.Model?.High}\r\n最低: {x.Model?.Low}\r\n開盤: {x.Model?.Open}\r\n收盤: {x.Model?.Close}",
                }
            ];

            cartesianChart1.XAxes =
            [
                new Axis
                {
                    LabelsRotation = 15,
                    // X軸的日期資訊
                    Labels = data.Select(x => x.Date.ToString("yyyy/MM/dd")).ToArray()
                }
            ];
            cartesianChart1.Title = new LiveChartsCore.SkiaSharpView.VisualElements.LabelVisual
            {
                Text = "K線圖範例",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
        }
    }
}
public class FinancialData
{
    public FinancialData(DateTime date, double high, double open, double close, double low)
    {
        Date = date;
        High = high;
        Open = open;
        Close = close;
        Low = low;
    }

    public DateTime Date { get; set; } // 日期
    public double High { get; set; } // 最高
    public double Open { get; set; } // 開盤
    public double Close { get; set; } // 收盤
    public double Low { get; set; } // 最低
}