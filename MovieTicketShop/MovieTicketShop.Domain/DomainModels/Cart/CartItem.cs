using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketShop.Domain.DomainModels
{
    public class CartItem : BaseEntity
    {
        [Required]
        public virtual Ticket Ticket { get; set; }
        public int Quantity { get; set; }

        public CartItem(Ticket ticket, int quantity)
        {
            this.Ticket = ticket;
            this.Quantity = quantity;
        }
    }
}
