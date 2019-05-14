using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BasicLibrary
{
    public class HttpClientHelper
    {

        private static string tomcat_url = "";
        private static string server_url = tomcat_url + "resteasy";

        // REST @GET 方法，根据泛型自动转换成实体，支持List<T>
        public static T doGetMethodToObj<T>(string metodUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server_url + metodUrl);
            request.Method = "get";
            request.ContentType = "application/json;charset=UTF-8";
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                response = (HttpWebResponse)e.Response;
                //MessageBox.Show(e.Message + " - " + getRestErrorMessage(response));
                return default(T);
            }
            string json = getResponseString(response);
            return JsonConvert.DeserializeObject<T>(json);
        }

        // 将 HttpWebResponse 返回结果转换成 string
        private static string getResponseString(HttpWebResponse response)
        {
            string json = null;
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("UTF-8")))
            {
                json = reader.ReadToEnd();
            }
            return json;
        }

        // 获取异常信息
        private static string getRestErrorMessage(HttpWebResponse errorResponse)
        {
            string errorhtml = getResponseString(errorResponse);
            string errorkey = "spi.UnhandledException:";
            errorhtml = errorhtml.Substring(errorhtml.IndexOf(errorkey) + errorkey.Length);
            errorhtml = errorhtml.Substring(0, errorhtml.IndexOf("\n"));
            return errorhtml;
        }

        // REST @POST 方法
        public static T doPostMethodToObj<T>(string metodUrl, string jsonBody)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server_url + metodUrl);
            request.Method = "post";
            request.ContentType = "application/json;charset=UTF-8";
            var stream = request.GetRequestStream();
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(jsonBody);
                writer.Flush();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string json = getResponseString(response);
            return JsonConvert.DeserializeObject<T>(json);
        }

        // REST @PUT 方法
        public static string doPutMethod(string metodUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server_url + metodUrl);
            request.Method = "put";
            request.ContentType = "application/json;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("UTF-8")))
            {
                return reader.ReadToEnd();
            }
        }

        // REST @PUT 方法，带发送内容主体
        public static T doPutMethodToObj<T>(string metodUrl, string jsonBody)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server_url + metodUrl);
            request.Method = "put";
            request.ContentType = "application/json;charset=UTF-8";
            var stream = request.GetRequestStream();
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(jsonBody);
                writer.Flush();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string json = getResponseString(response);
            return JsonConvert.DeserializeObject<T>(json);
        }

        // REST @DELETE 方法
        public static bool doDeleteMethod(string metodUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server_url + metodUrl);
            request.Method = "delete";
            request.ContentType = "application/json;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("UTF-8")))
            {
                string responseString = reader.ReadToEnd();
                if (responseString.Equals("1"))
                {
                    return true;
                }
                return false;
            }
        }
    }
}