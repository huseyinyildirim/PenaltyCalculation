using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using PenaltyCalculation.Business.Dtos;

namespace PenaltyCalculation.Web.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            CountrySelectList = new List<SelectListItem>();
        }

        public List<SelectListItem> CountrySelectList { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int CountryId { get; set; }

        public PenaltyCalculateDto PenaltyCalculate { get; set; }
    }
}
