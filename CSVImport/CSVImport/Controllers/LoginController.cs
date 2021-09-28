using Amazon.EC2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks; 
using System.Web.Mvc;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace CSVImport.Controllers
{
    public class LoginController
    {
        public ViewResult LoginForm()
        {
            return ViewResult();
        }

        public JsonResult Loginvalidate(UserData)
        {
            HttpClient client = new HttpClient();
            string _url = ConfigurationManager.AppSettings["webapibaseurl"];
            client.BaseAddress = new Uri(_url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            MediaTypeFormatter jsonFormatter = new JsonMediaTypeFormatter();
            HttpResponseMessage response = client.GetAsync("URL").Result;
            string content1 = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode.ToString() == "OK")
            {
                return JsonResult(content1, JsonRequestBehavior.AllowGet); 
            }
        }

        private JsonResult JsonResult(string content1, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }

        private ViewResult ViewResult()
        {
            throw new NotImplementedException();
        }
    }

}
