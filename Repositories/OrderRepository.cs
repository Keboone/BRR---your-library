using LibraryFinal.Models;

namespace LibraryFinal.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public DatabaseContext context;

        public OrderRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void SaveOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
