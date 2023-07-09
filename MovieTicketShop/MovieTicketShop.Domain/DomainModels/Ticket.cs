using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketShop.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public virtual Movie Movie { get; set; }
        [Required]
        public double Price { get; set; }

        public Ticket(DateTime dateTime, int stock, Movie movie, double price)
        {
            DateTime = dateTime;
            Stock = stock;
            Movie = movie;
            Price = price;
        }

    }
}
