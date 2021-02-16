using ExamenSGS.Application.Interfaces;
using ExamenSGS.Domain.Entities;
using System.Threading.Tasks;

namespace ExamenSGS.Application.AddYears.Queries.CalculateYearFuture
{
    public class CalculateYearFuture : IQuery<Year>
    {
        public string CalculateYear(Year futureYear)
        {
            var newYear = (futureYear.BirthDate.Year + futureYear.QuantityYears).ToString();
            var result = string.Empty;

            foreach (char digit in newYear)
            {
                result = string.Format("{0}|{1}", result, digit);
            }

            return result.Substring(1);
        }

        public async Task<string> Calculate(Year futureYear)
        {
            return await Task.Run(() =>
            {
                var newYear = (futureYear.BirthDate.Year + futureYear.QuantityYears).ToString();
                var result = string.Empty;

                foreach (char digit in newYear)
                {
                    result = string.Format("{0}|{1}", result, digit);
                }

                return result.Substring(1);
            });
           

        }
    }
}
