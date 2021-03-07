using Moviesite.Data;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            this._context = context;
        }
    }
}
