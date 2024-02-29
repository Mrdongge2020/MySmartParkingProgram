using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.SmartParking.Client.DAL
{
    public class WebDataAccess
    {
        private string domain = "http://localhost:5000/api/";

        public  Task<string> GetDatas(string uri) 
        {
            using (HttpClient client=new HttpClient())
            {
                var resp = client.GetAsync($"{domain}{uri}").GetAwaiter().GetResult();
                return resp.Content.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// post表单数据组装
        /// </summary>
        /// <param name="httpContent"></param>
        /// <returns></returns>
        private MultipartFormDataContent GetFormData(Dictionary<string, HttpContent> httpContent)
        {
            var postContent=new MultipartFormDataContent();
            string boundary = $"-----------------{DateTime.Now.Ticks.ToString("x")}-----------";
            postContent.Headers.Add("ContentType",$"muiltipart/form-data,boundary={boundary}");
            foreach (var item in httpContent)
            {
                postContent.Add(item.Value,item.Key);
            }
            return postContent;
        }

        public Task<string> PostDatas(string uri, Dictionary<string,HttpContent> httpContent) 
        {
            using (HttpClient client = new HttpClient())
            {
                var resp = client.PostAsync($"{domain}{uri}", this.GetFormData(httpContent)).GetAwaiter().GetResult();
                return resp.Content.ReadAsStringAsync();
            }
        }
     }
}
