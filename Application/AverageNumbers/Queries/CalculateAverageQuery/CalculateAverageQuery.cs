using ExamenSGS.Application.Interfaces;
using ExamenSGS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenSGS.Application.AverageNumbers.Queries.CalculateAverageQuery
{
    public class CalculateAverageQuery : IQuery<Average>
    {
        public string CalculateSum(Average values)
        {
            int start = values.Start;
            int end = values.End;
            int result = 0;

            var listOfNumbers = AddInList(start, end);

            result = Average(listOfNumbers);

            return result.ToString();
        }

        public async Task<string> Calculate(Average numbers)
        {
            return await Task.Run(() =>
            {
                int start = numbers.Start;
                int end = numbers.End;
                int result = 0;

                var listOfNumbers = AddInList(start, end);

                result = Average(listOfNumbers);

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

        private int Average(List<int> numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result = result + number;
            }

            var divisor = numbers.Count;

            return (result/divisor);
        }
    }
}
