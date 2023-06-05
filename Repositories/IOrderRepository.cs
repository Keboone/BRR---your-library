using LibraryFinal.Models;

namespace LibraryFinal.Repositories
{
    public interface IOrderRepository
    {
        public void SaveOrder(Order order);
    }
}
