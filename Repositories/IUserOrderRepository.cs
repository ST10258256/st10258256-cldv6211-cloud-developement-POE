namespace KhumaloCraft
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders(bool getAll = false);
    }
}