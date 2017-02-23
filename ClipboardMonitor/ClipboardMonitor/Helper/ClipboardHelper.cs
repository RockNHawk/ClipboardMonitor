using System.Windows.Forms;

namespace ClipboardMonitor.Helper
{
    /// <summary>
    /// 剪贴板帮助类
    /// </summary>
    public class ClipboardHelper
    {
        /// <summary>
        /// 设置剪贴板的文本内容
        /// </summary>
        /// <param name="s"></param>
        public static void SetText(string s)
        {
            Clipboard.SetDataObject(s ?? "");
        }
        /// <summary>
        /// 获取剪贴板中的文本内容
        /// </summary>
        /// <returns></returns>
        public static string GetText()
        {
            IDataObject iData = Clipboard.GetDataObject();
            return (string)iData.GetData(DataFormats.Text);
        }
    }
}
