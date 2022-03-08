using System;

namespace PenaltyCalculation.Data.Entities
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PenaltyPoint { get; set; }
    }
}
