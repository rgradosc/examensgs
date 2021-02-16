using System;

namespace ExamenSGS.Domain.Entities
{
    public class Year
    {
        public int Id { get; set; }

        public DateTime BirthDate { get; set; }

        public int QuantityYears { get; set; }

        public Year()
        {
            BirthDate = new DateTime();
        }
    }
}
