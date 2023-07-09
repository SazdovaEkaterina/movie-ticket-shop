using Microsoft.AspNet.Identity.EntityFramework;
using MovieTicketShop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketShop.Domain.IdentityModels
{
    public class MovieTicketShopUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual Cart UserShoppingCart { get; set; }
    }
}
