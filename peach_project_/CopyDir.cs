using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peach_project_
{
    class CopyDir
    {

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            System.IO.DirectoryInfo diSource = new System.IO.DirectoryInfo(sourceDirectory);
            System.IO.DirectoryInfo diTarget = new System.IO.DirectoryInfo(targetDirectory);
            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(System.IO.DirectoryInfo source, System.IO.DirectoryInfo target)
        {
            // Check if the target directory exists, if not, create it.
            if (System.IO.Directory.Exists(target.FullName) == false)
            {
                System.IO.Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (System.IO.FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(System.IO.Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (System.IO.DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                System.IO.DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

    }
}

