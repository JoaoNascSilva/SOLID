using System;

namespace SRP
{
    public class CustomerService
    {

        public string AddCustomer(Customer customer)
        {
            if (!customer.Validar())
                return "Dados invalidos.";

            var repository = new CustomerRepository();
            repository.Add(customer);

            return "Cliente cadastrado com sucesso.";
        }

        public string DeleteCustomer(Customer customer)
        {
            var repository = new CustomerRepository();
            repository.Delete(customer);

            return "Cliente removido.";
        }

    }
}
