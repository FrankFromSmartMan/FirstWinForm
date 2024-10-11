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
    public partial class FormMethods : Form
    {
        public FormMethods()
        {
            InitializeComponent();
        }
        private void PrintInClassMessage()
        {
            MessageBox.Show("您呼叫了在同類別中的方法!");
        }
        private void buttonInScope_Click(object sender, EventArgs e)
        {
            //定義
            void PrintMessage()
            {
                //...
                //...
                MessageBox.Show("您呼叫了範圍中的方法");
            }
            //呼叫 ()
            PrintMessage();

        }
        private void buttonInClass_Click(object sender, EventArgs e)
        {
            PrintInClassMessage();
        }

        private void buttonNewClass_Click(object sender, EventArgs e)
        {
            // 呼叫新類別中(MyMessage)的方法
            MyMessage myMessage = new MyMessage();
            myMessage.PrintMyMessage();
        }

        private void buttonThreeParams_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            //myMessage.PrintMyMessage("自訂的方法 :)");
            myMessage.PrintMyMessage("我的自訂訊息", true, MessageLevel.Warning);
        }

        private void buttonOptionalParams_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintMyMessage("我的自訂訊息", true);
        }

        private void buttonNamedParams_Click(object sender, EventArgs e)
        {
            MyMessage myMessage = new MyMessage();
            myMessage.PrintMyMessage(isShowTime: false, 
                                     level: MessageLevel.EndOfTheWorld,
                                     message: "具名參數!!!");
        }
    }
}
