using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Musify.MVVM.Utility
{
    public static class ImageHandler
    {
        public static string GetFullFilePath(string fileName)
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 0; i < 4; i++)
            {
                root = System.IO.Path.GetDirectoryName(root);
            }

            return $"{root}/Lib/Uploads/{fileName}";
        }

        public static ImageSource GetBitmapImage(string fileName)
        {
            BitmapImage bitmap = new();
            bitmap.BeginInit();

            bitmap.UriSource = new Uri(ImageHandler.GetFullFilePath(fileName));
            bitmap.EndInit();

            return bitmap;
        }

        public static void AttemptToDeleteImage(string fileName)
        {
            if (fileName == "notfound.png")
                return;

            if (!IsFileInUse(fileName))
                File.Delete(ImageHandler.GetFullFilePath(fileName));
        }

        public static void CopyImageToLocalStorage(string fileName, string destination)
        {
            File.Copy(fileName, ImageHandler.GetFullFilePath(destination));
        }

        private static bool IsFileInUse(string fileName)
        {
            try
            {
                using (var stream = File.Open(ImageHandler.GetFullFilePath(fileName), FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
                {
                    return false;
                }
            }
            catch(IOException)
            {
                return true;
            }
        }
    }
}
