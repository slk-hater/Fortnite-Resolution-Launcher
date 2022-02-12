using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortnite_Resolution_Launcher
{
    class DataFile
    {

        public static string path = @"C:\Fortnite Custom Resolution";
        public static void CreateDirectory()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                string tempExeName = Path.Combine(path, "QRes.exe");
                using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = Properties.Resources.GetQRes();
                    fsDst.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}
