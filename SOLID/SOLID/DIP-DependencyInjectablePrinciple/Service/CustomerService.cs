using AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple.Interface;

namespace AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailService _emailService;

        public CustomerService(ICustomerRepository customerRepository, IEmailService emailService)
        {
            _customerRepository = customerRepository;
            _emailService = emailService;
        }

        public bool AddCustomer(Customer customer)
        {
            if (!customer.Validar())
                return false;

            _customerRepository.Add(customer);

            _emailService.SendEmail(customer.Email, "silva.joao@google.com", "[SOLID] Aplicando DIP", "Modelo de uma implementacao do DIP, Utilizando os Principios do SOLID.");

            return true;
        }

    }
}