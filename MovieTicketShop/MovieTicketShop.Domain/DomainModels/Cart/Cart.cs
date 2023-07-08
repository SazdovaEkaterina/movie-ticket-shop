using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketShop.Domain.DomainModels
{
    public class Cart : BaseEntity
    {
        public virtual List<CartItem> Items { get; set; } = new List<CartItem>();
        public double TotalPrice { get; set; }
    }
}
