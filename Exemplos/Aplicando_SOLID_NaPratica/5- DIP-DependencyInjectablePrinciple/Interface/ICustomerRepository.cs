namespace Aplicando_SOLID_NaPratica.DIP_DependencyInjectablePrinciple.Interface
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Delete(Customer customer);
    }
}