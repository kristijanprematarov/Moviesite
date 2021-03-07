using Moviesite.Service.Interfaces;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            this._shoppingCartRepository = shoppingCartRepository;
        }
    }
}
