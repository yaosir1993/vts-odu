using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicLibrary
{
    public class HttpUtils
    {
        /// <summary>
        /// get请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static JObject GetResponse(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    throw new ArgumentNullException("url");
                }
                if (url.StartsWith("https"))
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //if (GlobalData.Authorization.Length > 0)
                //{
                //    httpClient.DefaultRequestHeaders.Add("Authorization", GlobalData.Authorization);
                //}
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
               //StatusCodeHandler(response);
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    //exceptionHandler("连接失败");
                }
            }
            return new JObject();
        }

        public static T GetResponse<T>(string url)
              where T : class, new()
        {
            T result = default(T);
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //if (GlobalData.Authorization.Length > 0)
            //{
            //    httpClient.DefaultRequestHeaders.Add("Authorization", GlobalData.Authorization);
            //}
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                //StatusCodeHandler(response);

                if (response.IsSuccessStatusCode)
                {
                    Task<string> t = response.Content.ReadAsStringAsync();
                    string s = t.Result;
                    result = JsonConvert.DeserializeObject<T>(s);
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    // exceptionHandler("连接失败");
                }
            }
            return result;
        }

        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData">post数据</param>
        /// <returns></returns>
        public static JObject PostResponse(string url, string postData)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(postData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient httpClient = new HttpClient();
            //if (GlobalData.Authorization.Length > 0)
            //{
            //    httpClient.DefaultRequestHeaders.Add("Authorization", GlobalData.Authorization);
            //}
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                //StatusCodeHandler(response);
                //AuthorizationHandler(response, url);
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    //exceptionHandler("连接失败");
                }
            }
            return new JObject();
        }

        private static void AuthorizationHandler(HttpResponseMessage response, string url)
        {
            Regex reg = new Regex("(.+)/login$");
            Boolean isLogin = reg.IsMatch(url);
            if (isLogin)
            {
                //GlobalData.Authorization = getHeaderByKey(response, "Authorization");
            }
        }

        private static string getHeaderByKey(HttpResponseMessage response, string key)
        {
            string result = "";
            string header = response.Headers.ToString();
            string[] headers = header.Split("\r\n".ToCharArray());
            if (headers.Count() > 0)
            {
                foreach (string item in headers)
                {
                    Regex reg = new Regex("^" + key + ":(.+)");
                    if (reg.IsMatch(item))
                    {
                        string[] tokens = item.Split(':');
                        if (tokens[0].ToString() == key)
                        {
                            result = tokens[1].ToString();
                            break;
                        }
                    }
                    else
                    {
                        reg = new Regex("^" + key + "=(.+)");
                        if (reg.IsMatch(item))
                        {
                            string[] tokens = item.Split('=');
                            if (tokens[0].ToString() == key)
                            {
                                result = tokens[1].ToString();
                                break;
                            }
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 发起post请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">url</param>
        /// <param name="postData">post数据</param>
        /// <returns></returns>
        public static T PostResponse<T>(string url, string postData)
           where T : class, new()
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(postData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient httpClient = new HttpClient();
            T result = default(T);
            try
            {
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                String statusCode = response.StatusCode.ToString();
                if (statusCode.Equals("OK"))
                {
                    Task<string> t = response.Content.ReadAsStringAsync();
                    string s = t.Result;
                    result = JsonConvert.DeserializeObject<T>(s);
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    //exceptionHandler("连接失败");
                }
            }
            return result;
        }


        /// <summary>
        /// put请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="putData">put数据</param>
        /// <returns></returns>
        public static JObject PutResponse(string url, string putData = "")
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpContent httpContent = new StringContent(putData);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpClient httpClient = new HttpClient();
            //if (GlobalData.Authorization.Length > 0)
            //{
            //    httpClient.DefaultRequestHeaders.Add("Authorization", GlobalData.Authorization);
            //}
            try
            {
                HttpResponseMessage response = httpClient.PutAsync(url, httpContent).Result;
                //StatusCodeHandler(response);
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    //exceptionHandler("连接失败");
                }
            }
            return new JObject();
        }

        /// <summary>
        /// delete请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static JObject DeleteResponse(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (url.StartsWith("https"))
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //if (GlobalData.Authorization.Length > 0)
            //{
            //    httpClient.DefaultRequestHeaders.Add("Authorization", GlobalData.Authorization);
            //}
            try
            {
                HttpResponseMessage response = httpClient.DeleteAsync(url).Result;
                //StatusCodeHandler(response);
                string statusCode = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;

                    JObject jo = (JObject)JsonConvert.DeserializeObject(result);
                    return jo;
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message;
                if (msg == "无法连接到远程服务器")
                {
                    //exceptionHandler("连接失败");
                }
            }
            return new JObject();
        }
    }
}
