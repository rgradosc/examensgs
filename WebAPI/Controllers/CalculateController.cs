﻿using ExamenSGS.Application.AverageNumbers.Commands.CalculateAverage;
using ExamenSGS.Application.Commands.AddYears.CalculateYears;
using ExamenSGS.Application.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CalculateController : ApiController
    {
        private readonly IRequestHandler<CalculateYearsCommand> handlerYear;
        private readonly IRequestHandler<CalculateAverageCommand> handlerSum;

        public CalculateController()
        {
            handlerYear = new CalculateYearsCommandHandler();
            handlerSum = new CalculateAverageCommandHandler();
        }
        
        [HttpPost]
        [Route("api/calcular")]
        public async Task<string> GetYear([FromBody] CalculateYearsCommand command)
        {
            return await handlerYear.Handler(command);
        }
        
        [HttpPost]
        [Route("api/promediar")]
        public async Task<double> GetSum([FromBody] CalculateAverageCommand command)
        {
            var result  = await handlerSum.Handler(command);

            return Convert.ToDouble(result);
        } 
    }
}
