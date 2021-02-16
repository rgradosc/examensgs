using ExamenSGS.Application.AverageNumbers.Queries.CalculateAverageQuery;
using ExamenSGS.Application.Interfaces;
using System.Threading.Tasks;
using ExamenSGS.Domain.Entities;

namespace ExamenSGS.Application.AverageNumbers.Commands.CalculateAverage
{
    public class CalculateAverageCommand
    {
        public int Start { get; set; }

        public int End { get; set; }
    }

    public class CalculateAverageCommandHandler : IRequestHandler<CalculateAverageCommand>
    {
        private readonly IQuery<Average> query;

        public CalculateAverageCommandHandler()
        {
            query = new CalculateAverageQuery();
        }

        public async Task<string> Handler(CalculateAverageCommand request)
        {
            var entity = new Average
            {
                End = request.End,
                Start = request.Start,
            };
            
            var result = await query.Calculate(entity);

            return result;
        }
    }
}
