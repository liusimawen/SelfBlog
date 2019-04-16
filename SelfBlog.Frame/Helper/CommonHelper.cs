using System;
using System.Drawing.Imaging;
using System.IO;

namespace SelfBlog.Frame
{
    public class CommonHelper
    {
        public static ImageFormat GetImageFormat(string filePath, out string format)
        {
            try
            {
                byte[] sb = new byte[2];  //这次读取的就是直接0-1的位置长度了.
                if (File.Exists(filePath) == false)
                {
                    format = string.Empty;
                    return null;
                }
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    if (fs.Length < 2)
                    {
                        format = string.Empty;
                        return null;
                    }
                    fs.Read(sb, 0, sb.Length);
                }
                //根据文件头判断
                string strFlag = sb[0].ToString() + sb[1].ToString();
                //察看格式类型
                switch (strFlag)
                {
                    //JPG格式
                    case "255216":
                        format = ".jpg";
                        break;
                    //GIF格式
                    case "7173":
                        format = ".gif";
                        break;
                    //BMP格式
                    case "6677":
                        format = ".bmp";
                        break;
                    //PNG格式
                    case "13780":
                        format = ".png";
                        break;
                    //其他格式
                    default:
                        format = string.Empty;
                        break;
                }
            }
            catch
            {
                format = Path.GetExtension(filePath).ToLower();
            }

            switch (format)
            {
                //JPG格式
                case ".jpg":
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                //GIF格式
                case ".gif":
                    return System.Drawing.Imaging.ImageFormat.Gif;
                //BMP格式
                case ".bmp":
                    return System.Drawing.Imaging.ImageFormat.Bmp;
                //PNG格式
                case ".png":
                    return System.Drawing.Imaging.ImageFormat.Png;
                //其他格式
                default:
                    format = string.Empty;
                    return null;
            }
        }
    }
}
