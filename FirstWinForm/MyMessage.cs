using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWinForm
{
    // 層級的列舉 (好處:可以讓呼叫者去用點的方式選擇)
    public enum MessageLevel
    {
        Info,
        Warning,
        Danger,
        EndOfTheWorld
    }
    public class MyMessage
    {
        public void PrintMyMessage()
        {
            MessageBox.Show("呼叫了新類別的方法!");
        }
        // overload methods 方法多載
        public void PrintMyMessage(string message)
        {
            MessageBox.Show(message);
        }
        // 可以接受三個參數，isShowTime代表要不要顯示時間，預設level為Info(為選擇性參數)
        public void PrintMyMessage(string message, 
                                   bool isShowTime, 
                                   MessageLevel level = MessageLevel.Info)
        {
            // 格式化時間
            string formattedTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if (isShowTime == true)
            {
                message = formattedTime + " " + message;
            }
            // 層級判斷
            string severity = "Info";
            if (level == MessageLevel.Warning)
            {
                severity = "Warning";
            }
            else if (level == MessageLevel.Danger)
            {
                severity = "Danger";
            }
            else if (level == MessageLevel.EndOfTheWorld)
            {
                severity = "End of the world!!!!";
            }
            message = severity + " " + message;
            MessageBox.Show(message);
        }

    }
}
