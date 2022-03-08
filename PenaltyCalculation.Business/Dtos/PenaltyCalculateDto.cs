using PenaltyCalculation.Business.Enums;

namespace PenaltyCalculation.Business.Dtos
{
    public class PenaltyCalculateDto
    {
        public int TotalDay { get; set; }

        public int WorkDay { get; set; }

        public int Holiday { get; set; }

        public int PenaltyDay { get; set; }

        public decimal PenaltyPrice { get; set; }

        public CountryEnum CountryCode { get; set; }

        public MoneyCodeEnum MoneyCode { get; set; }

        public int CountryId { get; set; }
    }
}
