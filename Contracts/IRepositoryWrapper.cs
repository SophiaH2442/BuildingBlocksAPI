namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IOrderRepository Order { get; }
        ICustomerRepository Customer { get; }
    }
}
