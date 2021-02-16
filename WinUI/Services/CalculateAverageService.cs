using ExamenSGS.Domain.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ExamenSGS.WinUI.ViewModels;

namespace ExamenSGS.WinUI.Services
{
    public class CalculateAverageService : BaseService, IService<AverageViewModel>
    {
        public async Task<string> Request(AverageViewModel values)
        {
            string apiURL = $"{BaseURI}/promediar";
            var entidad = new Average
            {
                End = values.End,
                Start = values.Start,
            };

            var json = JsonConvert.SerializeObject(entidad);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await HttpClient.PostAsync(apiURL, content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
