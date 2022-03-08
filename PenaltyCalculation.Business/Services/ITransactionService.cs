using System;
using PenaltyCalculation.Business.Dtos;

namespace PenaltyCalculation.Business.Services
{
    public interface ITransactionService
    {
        PenaltyCalculateDto PenaltyCalculate(DateTime purchaseDate, DateTime deliveryDate, int countryId);

    }
}
