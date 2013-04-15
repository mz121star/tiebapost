using System;
using System.Collections.Generic;
using System.Text;
using System.IO ;//�ļ���д�������ռ�

namespace core
{
    /// <summary>
    /// ��ȡ�ļ���
    /// </summary>
   public  class RFile
    {
       //�����ļ���,�ļ�����;
       private string FileName;
       private StreamReader sr;
       private StreamWriter sw;
       private bool readOpened, writerOpened;
//------------------------------------------���캯��----------------------------------------
        /// <summary>
        /// ���캯��
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

//---------------------------------------ͨ�����캯�������Զ��庯��,�Ա�����ֵ,ʡȴ�˶Բ�ͬ�����Ĺ��캯����Ҫ���д˸�ֵ�Ĵ����ظ�---------------------------------------------------
       private void Init()
       {
           readOpened = false;
           writerOpened = false;
       }
//------------------------------------------------------------------------------------------

//------------------------------------------�ļ���д����----------------------------------------
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
//----------------------------------------------�ļ���д������Ĺر�------------------------------------------------
       public void close()
       {
           if (readOpened) //����ǰΪ��ȡ����,��ȡ�ɹ���ֵΪTrue;Ȼ��رն��ı���
           {
               sr.Close();
           }
           if (writerOpened)//����ǰΪд�����,��ȡ�ɹ���ֵΪTrue;Ȼ��ر�д�ı���
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
