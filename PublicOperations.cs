using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibrarySystem
{
    //该静态类用于存放一些公用操作
    public static class PublicOperations
    {
        //打开其他窗口
        public static void OpenForm(Form currentForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
            currentForm.Hide(); //注意，本程序使用Hide，其他时候应该close以节省内存
        }

        //网络模块
        public static async Task<Dictionary<string, string>> NetWork(string requestName, Dictionary<string, string> values)
        {
            var client = new HttpClient();   //创建HttpClient对象
            var content = new FormUrlEncodedContent(values);  //将字典转换为表单数据,理解为JSON即可
            string serverIP= "http://localhost:5000/";
            string path = serverIP + requestName;
            var response = await client.PostAsync(path, content);  //向后端发送HTTP POST请求 
            var responseString = await response.Content.ReadAsStringAsync();
            var responseDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);
            return responseDict; //返回的是字典类型
        }
    }
}
