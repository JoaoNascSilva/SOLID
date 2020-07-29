using System.Data;
using System.Data.SqlClient;

namespace Aplicando_SOLID_NaPratica
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using(var connection = new SqlConnection())
            {
                var command = new SqlCommand();
                
                connection.ConnectionString = "MinhaConexao";
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "[ SQL INSERT ] ";
                
                connection.Open();
                command.ExecuteNonQuery();    
            }
        }
    }
}
