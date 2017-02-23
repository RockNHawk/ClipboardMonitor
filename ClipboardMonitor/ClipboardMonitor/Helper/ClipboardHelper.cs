using System.Drawing;
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
        /// <param name="s">文本内容</param>
        public static void SetText(string s)
        {
            Clipboard.SetDataObject(s ?? "");
        }
        /// <summary>
        /// 获取剪贴板中的文本内容
        /// </summary>
        /// <returns>返回剪贴板文本</returns>
        public static string GetText()
        {
            IDataObject iData = Clipboard.GetDataObject();
            return (string)iData.GetData(DataFormats.Text);
        }
        /// <summary>
        /// 获取剪贴板位图格式数据
        /// </summary>
        /// <returns>位图</returns>
        public static Bitmap GetBitmap()
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                Bitmap bt = (Bitmap)iData.GetData(DataFormats.Bitmap);
                return bt;
            }
            return null;
        }
    }
}
