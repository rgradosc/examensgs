using ExamenSGS.Domain.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ExamenSGS.WinUI.ViewModels;

namespace ExamenSGS.WinUI.Services
{
    public class CalculateYearService : BaseService, IService<YearViewModel>
    {
        public async Task<string> Request(YearViewModel values)
        {
            string apiURL = $"{BaseURI}/calcular";
            var entidad = new Year
            {
                BirthDate = values.Birthdate,
                QuantityYears = values.QuantityYear
            };

            var json = JsonConvert.SerializeObject(entidad);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await HttpClient.PostAsync(apiURL, content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
