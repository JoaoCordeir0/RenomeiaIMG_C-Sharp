using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameImg
{
    class Program
    {
        static void Main(string[] args)
        {            
            var files = Directory.GetFiles(@"D:\Caminho");

            foreach (var file in files)
            {
                var name = new FileInfo(file).FullName;

                File.Move(name, name.Replace("IMG_", "newname"));
            }
        }
    }
}
