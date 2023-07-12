using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieTicketShop.Domain;

namespace EShop.Repository.Implementation
{
    public class UserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<MovieTicketShopUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<MovieTicketShopUser>();
        }
        public IEnumerable<MovieTicketShopUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public MovieTicketShopUser Get(string id)
        {
            return entities
               .Include(z => z.UserCart)
               .Include("UserCart.ProductInShoppingCarts")
               .Include("UserCart.ProductInShoppingCarts.CurrnetProduct")
               .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(MovieTicketShopUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(MovieTicketShopUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(MovieTicketShopUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}