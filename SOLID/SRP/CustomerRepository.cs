using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace SRP
{
    public class CustomerRepository
    {
        private DbConnection _sqlConnection;
        private DbCommand _sqlCommand;

        public CustomerRepository()
        {
            _sqlConnection = new SqlConnection();
            _sqlCommand = new SqlCommand();

            _sqlConnection.ConnectionString = "ConnectionString";
            _sqlCommand.Connection = _sqlConnection;
        }

        public void Add(Customer customer)
        {
            using (_sqlConnection)
            {
                _sqlCommand.CommandType = CommandType.Text;
                _sqlCommand.CommandText = "INSERT INTO customer (id, name, email, cpf, rg) VALUES (@id, @name, @email, @cpf, @rg);";

                _sqlCommand.Parameters.Add(customer);

                _sqlConnection.Open();
                _sqlCommand.ExecuteNonQuery();
            }
        }

        public void Delete(Customer customer)
        {
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.CommandText = "DELETE FROM customer WHERE id = @id";

            _sqlCommand.Parameters.Add(customer);

            _sqlConnection.Open();
            _sqlCommand.ExecuteNonQuery();
        }
    }
}
