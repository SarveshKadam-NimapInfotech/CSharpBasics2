using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------file & fileinfo------------------------------ -

                var path = @"c:\somefolder\helloworld.sln";

            //    File.Copy(path, @"d:\somelocation.jpg", true);
            //    File.Delete(path);
            //    if(File.Exists(path))
            //    {
            //        //
            //    }

            //    var contect = File.ReadAllText(path);

            //    var fileinfo = new FileInfo(path);
            //    fileinfo.CopyTo("...");
            //    fileinfo.Delete();
            //    if(fileinfo.Exists(path))
            //    {
            //        //

            //    }

            //---------------------------Directory&Directoryinfo-----------------------

            //Directory.CreateDirectory(path);

            //var files = Directory.GetFiles(path, "*.sln", SearchOption.AllDirectories);
            //foreach(var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //var directories = Directory.GetDirectories(path, "*.sln", SearchOption.AllDirectories);
            //foreach(var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //Directory.Exists(path);

            //var directoryInfo = new DirectoryInfo(path);
            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();

            //-------------------------path---------------------------------------

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));









        }
    }
}
