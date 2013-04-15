using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace core
{
    public  class DirectoryHelper
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
    }
}
