using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moviesite.Entities
{
    public class Order
    {
        [Key]

        public int Id { get; set; }

        public string UserId { get; set; }

        public string MovieTitle { get; set; }

        public string MovieProducer { get; set; }

        public string MovieCountry { get; set; }

        public string MovieCategory { get; set; }

        public string MovieFormatType { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
