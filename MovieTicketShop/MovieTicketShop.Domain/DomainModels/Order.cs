using Microsoft.WindowsAzure.MediaServices.Client;
using MovieTicketShop.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketShop.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public virtual MovieTicketShopUser Owner { get; set; }
        public virtual List<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
