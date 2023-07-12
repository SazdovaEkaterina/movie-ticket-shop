using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketShop.Service
{
    public class CartService
    {
        private readonly Repository<Cart> _cartRepository;
        private readonly Repository<Order> _orderRepository;
        private readonly UserRepository _userRepository;

        public ShoppingCartService(Repository<Cart> cartRepository, UserRepository userRepository, Repository<Order> orderRepository)
        {
            _cartRepository = cartRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
        }


        public bool deleteProductFromSoppingCart(string userId, Guid itemId)
        {
            if (!string.IsNullOrEmpty(userId) && itemId != null)
            {
                var loggedInUser = this._userRepository.Get(userId);

                var userCart = loggedInUser.UserCart;

                var itemToDelete = userCart.Items.Where(z => z.ItemId.Equals(itemId)).FirstOrDefault();

                userCart.Items.Remove(itemToDelete);

                this._cartRepository.Update(userCart);

                return true;
            }
            return false;
        }
    }
}
