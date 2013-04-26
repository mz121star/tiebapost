using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace core
{
    public class DirectoryHelper
    {
        public static IList<FileInfo> Getfiles(string path)
        {
            IList<FileInfo> fileInfos = new List<FileInfo>();
            DirectoryInfo Folder = new DirectoryInfo(path);
            //遍历文件夹

            foreach (FileInfo NextFile in Folder.GetFiles())
                fileInfos.Add(NextFile);
            return fileInfos;
        }

        /// <summary>
        /// 从一个目录将其内容移动到另一目录
        /// </summary>
        /// <param name="p">源目录</param>
        /// <param name="p_2">目的目录</param>
        public static void MoveFolderTo(string p, string p_2)
        {
            //检查是否存在目的目录
            if (!Directory.Exists(p_2))
                Directory.CreateDirectory(p_2);
            //先来移动文件
            DirectoryInfo info = new DirectoryInfo(p);
            FileInfo[] files = info.GetFiles();
            foreach (FileInfo file in files)
            {
                File.Copy(Path.Combine(p,file.Name), Path.Combine(p_2, file.Name), true);
                
            }
        }
    }
}
