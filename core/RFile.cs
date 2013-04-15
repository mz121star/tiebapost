using System;
using System.Collections.Generic;
using System.Text;
using System.IO ;//文件读写的命名空间

namespace core
{
    /// <summary>
    /// 读取文件类
    /// </summary>
   public  class RFile
    {
       //定义文件名,文件和流;
       private string FileName;
       private StreamReader sr;
       private StreamWriter sw;
       private bool readOpened, writerOpened;
//------------------------------------------构造函数----------------------------------------
        /// <summary>
        /// 构造函数
        /// </summary>
        public RFile()
        {
            Init();
        }

       public RFile(string file_name)
       {
           FileName = file_name;
           Init();
       }
//------------------------------------------------------------------------------------------

//---------------------------------------通过构造函数调用自定义函数,对变量赋值,省却了对不同参数的构造函数都要进行此赋值的代码重复---------------------------------------------------
       private void Init()
       {
           readOpened = false;
           writerOpened = false;
       }
//------------------------------------------------------------------------------------------

//------------------------------------------文件读写操作----------------------------------------
       public bool OpenForRead()
       {
           return OpenForRead(FileName);
       }
       public bool OpenForRead(string file_name)
       {
           FileName = file_name;
           readOpened = true;
           try
           {
               //sr = new StreamReader(FileName);
               sr = File.OpenText(FileName);
           }
           catch (FileNotFoundException  e)
           {
               readOpened = false;
           }
           return readOpened;
       }

       public bool OpenForWrite()
       {
           return OpenForWrite(FileName);
       }
       public bool OpenForWrite(string file_name)
       {
           FileName = file_name;
           writerOpened = true;
           try
           {
               sw = new StreamWriter (FileName);
           }
           catch (Exception e)
           {
               writerOpened  = false;
           }
           return writerOpened;
       }

       public string readline()
       {
           return sr.ReadLine();
       }
       public string readtoEnd()
       {
           return sr.ReadToEnd();
       }

       public void writeline(string s)
       {
           sw.WriteLine(s);
       }
//----------------------------------------------文件读写流对象的关闭------------------------------------------------
       public void close()
       {
           if (readOpened) //若当前为读取操作,读取成功该值为True;然后关闭读文本流
           {
               sr.Close();
           }
           if (writerOpened)//若当前为写入操作,读取成功该值为True;然后关闭写文本流
           {
               sw.Close();
           }
       }

        public void WriteToFile(string content)
        {
           OpenForWrite();
           writeline(content);
           close();
        }
       public string ReadFromFile()
       {
           OpenForRead();
           var result= readtoEnd();
           close();
           return result;
       }
    }
}
