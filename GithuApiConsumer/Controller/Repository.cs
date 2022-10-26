﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using GithuApiConsumer.Model;

namespace GithuApiConsumer.Controller
{
    internal class Repository
    {
        private String url = "https://api.github.com/";

        public Repository()
        {
        }

        public List<Repo> GetUserRepos(string nickname)
        {
            List<Repo> lr = (List<Repo>)MakeRequest(String.Concat(url, "users/", nickname, "/repos"), null, "GET", "application/json", typeof(List<Repo>));
            return lr;
        }

        public static object MakeRequest(String Url, object Body, string HttpMethod, string ContentType, Type ResponseType)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(Url) as HttpWebRequest;
                request.UserAgent = "Mozilla/5.0 (X11; Linux x86_64; rv:102.0) Gecko/20100101 Firefox/102.0";
                string sb = JsonConvert.SerializeObject(Body);
                request.Method = HttpMethod;
                if (HttpMethod != "GET")
                {
                    request.ContentType = ContentType;
                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK) throw new Exception(String.Format("Server error (HTTP {0}: {1}.)", response.StatusCode, response.StatusDescription));
                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    string strsb = sr.ReadToEnd();
                    object objResponse = JsonConvert.DeserializeObject(strsb, ResponseType);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
            return new object();
        }
    }
}

