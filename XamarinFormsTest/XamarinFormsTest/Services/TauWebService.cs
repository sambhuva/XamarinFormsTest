using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using XamarinFormsTest.Model;

namespace XamarinFormsTest.Services
{
    public class TauWebService : IWebService
    {
        private CookieCollection _cookies;

        public async Task LoginToPage(UserLoginData userData)
        {
            GetBaseAdressCookies();
        }

        //private async Task LoginToTau()
        //{
        //    var baseAddress = new Uri("https://nidp.tau.ac.il");
        //    var cookieContainer = new CookieContainer();
        //    using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
        //    using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
        //    {
        //        var content = new FormUrlEncodedContent(new[]
        //            {
        //                new KeyValuePair<string, string>("option", "credential"),
        //                new KeyValuePair<string, string>("Ecom_User_ID", "doronkaminer"),
        //                new KeyValuePair<string, string>("Ecom_User_Pid", "302866835"),
        //                new KeyValuePair<string, string>("Ecom_Password", "pingaK7")
        //            });
        //        //option=credential&Ecom_User_ID=doronkaminer&Ecom_User_Pid=302866835&Ecom_Password=MYPASSWORD
        //        cookieContainer.Add(new Uri("https://nidp.tau.ac.il/nidp/idff/sso?sid=0&sid=0"), _cookies);
        //        var result = await client.PostAsync("/nidp/idff/sso?sid=0&sid=0", content);
        //        var responseString = result.Content.ReadAsStringAsync();
        //    }

        //    var myTauAddress = new Uri("https://mytau.tau.ac.il");
        //    var tauCookieContainer = new CookieContainer();
        //    using (var tauClient = new HttpClient(new HttpClientHandler() { CookieContainer = tauCookieContainer }) { BaseAddress = myTauAddress })
        //    {
        //        var result = await tauClient.GetStringAsync("/index.php");
        //    }
        //}

        private void GetBaseAdressCookies()
        {
            var cookies = new CookieCollection();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mytau.tau.ac.il");
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Uri("https://mytau.tau.ac.il"), cookies);
            //Get the response from the server and save the cookies from the first request..
            request.BeginGetResponse(async r =>
            {
                var reponse = (HttpWebResponse)request.EndGetResponse(r);
                _cookies = reponse.Cookies;
                //await LoginToTau();

            }, null);

        }


    }
}
