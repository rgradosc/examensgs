using ExamenSGS.Application.Interfaces;
using ExamenSGS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenSGS.Application.AverageNumbers.Queries.CalculateAverageQuery
{
    public class CalculateAverageQuery : IQuery<Average>
    {
        public async Task<string> Calculate(Average numbers)
        {
            return await Task.Run(() =>
            {
                int start = numbers.Start;
                int end = numbers.End;
                double result = 0;

                var listOfNumbers = AddInList(start, end);

                if (listOfNumbers.Count > 0)
                {
                    result = Average(listOfNumbers);
                }

                return result.ToString();
            });
        }

        private List<int> AddInList(int start, int end)
        {
            List<int> numbers = new List<int>();
            while (start <= end)
            {
                numbers.Add(start);
                start++;
            }
            return numbers;
        }

        private double Average(List<int> numbers)
        {
            double result = 0;
            foreach (int number in numbers)
            {
                result = result + number;
            }

            double divisor = numbers.Count;

            return (result/divisor);
        }
    }
}
