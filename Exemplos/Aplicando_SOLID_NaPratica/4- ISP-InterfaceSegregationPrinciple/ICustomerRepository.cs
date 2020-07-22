namespace Aplicando_SOLID_NaPratica.ISP_InterfaceSegregationPrinciple
{
    public interface ICustomerRepository : IRepositoryBase
    {
        void EnviarEmail();
    }
}
