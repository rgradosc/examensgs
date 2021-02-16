using System.Configuration;
using System.Net.Http;

namespace ExamenSGS.WinUI.Services
{
    public class BaseService
    {
        public string BaseURI
        {
            get
            {
                return ConfigurationManager.AppSettings["BaseURI"];
            }
        }

        public HttpClient HttpClient { get; set; }

        public BaseService()
        {
            HttpClient = new HttpClient();
        }
    }
}
