namespace Aplicando_SOLID_NaPratica
{
    public class CustomerService
    {
        public bool NewCustomer(Customer customer)
        {
            if (!customer.IsValid()) 
                return false;

            var customerRepository = new CustomerRepository();
            customerRepository.AddCustomer(customer);

            EmailService.Send("", "", "", "");

            return true;
        }
    }
}
