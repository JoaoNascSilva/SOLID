namespace AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple.Interface
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Delete(Customer customer);
    }
}
