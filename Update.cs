using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UpdateD
{
    
    
    public class Update
    {
        public string[] after;
        public bool GetUpdate(string ID,string Ver)
        {
            
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                StringBuilder sb = new StringBuilder();
                String pageData = MyWebClient.DownloadString("http://2018k.cn/api/checkVersion?id="+ID+"&version=" + Ver); //从指定网站下载数据
                pageData = Encoding.UTF8.GetString(MyWebClient.DownloadData("http://2018k.cn/api/checkVersion?id=" + ID + "&version=" + Ver));
                after = pageData.Split(new char[] { '|' });
            if(after[0] == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
         
        }
        public string GetUpdateRem(string ID)
        {

            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            StringBuilder sb = new StringBuilder();
            String pageData = MyWebClient.DownloadString("http://2018k.cn/api/getExample?id=" + ID + "&data=remark"); //从指定网站下载数据
            pageData = Encoding.UTF8.GetString(MyWebClient.DownloadData("http://2018k.cn/api/getExample?id="+ID+ "&data=remark"));
            return pageData;



        }
        public string GetUpdateFile(string ID)
        {

            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            StringBuilder sb = new StringBuilder();
            String pageData = MyWebClient.DownloadString("http://2018k.cn/api/getExample?id=" + ID + "&data=url"); //从指定网站下载数据
            pageData = Encoding.UTF8.GetString(MyWebClient.DownloadData("http://2018k.cn/api/getExample?id=" + ID + "&data=url"));
            return pageData;



        }
        public string GetUpdateNotice(string ID)
        {

            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            StringBuilder sb = new StringBuilder();
            String pageData = MyWebClient.DownloadString("http://2018k.cn/api/getExample?id=" + ID + "&data=notice"); //从指定网站下载数据
            pageData = Encoding.UTF8.GetString(MyWebClient.DownloadData("http://2018k.cn/api/getExample?id=" + ID + "&data=notice"));
            return pageData;



        }
    }
}
