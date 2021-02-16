using ExamenSGS.Application.AddYears.Queries.CalculateYearFuture;
using ExamenSGS.Application.Interfaces;
using ExamenSGS.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ExamenSGS.Application.Commands.AddYears.CalculateYears
{
    public class CalculateYearsCommand
    {
        public DateTime BirthDate { get; set; }

        public int QuantityYears { get; set; }
    }

    public class CalculateYearsCommandHandler : IRequestHandler<CalculateYearsCommand>
    {
        private readonly IQuery<Year> query;

        public CalculateYearsCommandHandler()
        {
            query = new CalculateYearFuture();
        }
        
        public async Task<string> Handler(CalculateYearsCommand request)
        {
            var entity = new Year
            {
                BirthDate = request.BirthDate,
                QuantityYears = request.QuantityYears,
            };
            
            var result = await query.Calculate(entity);
            return result;
        }
    }
}
