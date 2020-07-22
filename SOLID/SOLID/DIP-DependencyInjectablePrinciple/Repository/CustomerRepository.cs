using AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple.Interface;
using System.Data;
using System.Data.SqlClient;

namespace AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            using (var connection = new SqlConnection())
            {
                var command = new SqlCommand();
                connection.ConnectionString = "MinhaConnectionString";
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "SQL";

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(Customer customer)
        {
            using (var connection = new SqlConnection())
            {
                var command = new SqlCommand();
                connection.ConnectionString = "MinhaConnectionString";
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "SQL";

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
