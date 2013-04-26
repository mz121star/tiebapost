using System;
using System.Collections.Generic;
using System.Text;
using SharpSvn;


namespace core
{
   public class VCSHelper
    {
       /// <summary>
       /// clone项目
       /// </summary>
       /// <param name="gitpath">远程地址</param>
       /// <param name="destpath">本地地址</param>
       /// <returns></returns>
       public static bool Clone(string gitpath, string destpath)
       {

           using (SvnClient client = new SvnClient())
           {
               // Checkout the code to the specified directory
               return client.CheckOut(new Uri(gitpath),  destpath);
               
               return true;
               // Update the specified working copy path to the head revision
                
               SvnUpdateResult result;
               client.Update(destpath, out result);
                

               client.Move("c:\\sharpsvn\\from.txt", "c:\\sharpsvn\\new.txt");

               // Commit the changes with the specified logmessage
               SvnCommitArgs ca = new SvnCommitArgs();
               ca.LogMessage = "Moved from.txt to new.txt";
               client.Commit("c:\\sharpsvn", ca);
           }

           return true;

       }
       /// <summary>
       /// update
       /// </summary>
       /// <param name="destpath"></param>
       /// <returns></returns>
        public static bool Update(string destpath)
        {
            using (SvnClient client = new SvnClient())
            {
                    client.Update(destpath);
                
                    return true;
            }

        }


       /// <summary>
       /// 是否存在版本库
       /// </summary>
       /// <param name="destpath">目标文件夹</param>
       /// <returns>false不存在，true存在</returns>
        public static bool HasRepository(string destpath)
       {
             using (SvnClient client = new SvnClient())
             {

                 var url = client.GetRepositoryRoot(destpath);
                 return url != null;

             }
            
       }
    }
}
