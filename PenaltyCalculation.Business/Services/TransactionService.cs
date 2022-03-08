using System;
using Nager.Date;
using PenaltyCalculation.Business.Dtos;
using PenaltyCalculation.Business.Enums;
using PenaltyCalculation.Data.Repository;

namespace PenaltyCalculation.Business.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public PenaltyCalculateDto PenaltyCalculate(DateTime purchaseDate, DateTime deliveryDate, int countryId)
        {
            int totalDay = 0;
            int workDay = 0;
            int holiday = 0;
            int penaltyDay = 0;

            decimal penaltyPrice = 0.00m;

            for (var day = purchaseDate.Date; day.Date <= deliveryDate.Date; day = day.AddDays(1))
            {
                CountryEnum countryEnum = (CountryEnum)countryId;

                if (DateSystem.IsPublicHoliday(day, (CountryCode)countryEnum) || DateSystem.IsWeekend(day, (CountryCode)countryEnum))
                {
                    holiday++;
                }
                else
                {
                    workDay++;
                }
                    
                if (workDay >= 10)
                {
                    penaltyPrice += 5;
                    penaltyDay++;
                }

                totalDay++;
            }

            return new PenaltyCalculateDto
            {
                WorkDay = workDay,
                PenaltyPrice = penaltyPrice,
                CountryCode = (CountryEnum)countryId,
                TotalDay = totalDay,
                Holiday = holiday,
                MoneyCode = (MoneyCodeEnum)countryId,
                PenaltyDay = penaltyDay
            };
        }
    }
}