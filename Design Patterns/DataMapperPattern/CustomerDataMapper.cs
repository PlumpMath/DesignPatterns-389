using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Design_Patterns.DataMapperPattern
{
    // The Data Mapper separates the mapping from the business object class while maintaining the Single Responsibity Principle
    //However, the Active Record Design Pattern updates the mapping quicker if the business class changes, since the mapping code is in the same class. However, the business class gets larger.
    public class CustomerDataMapper
    {
        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

        public static Customer GetByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SELECT TOP 1 * FROM [Customer] WHERE [Id] = @Id";
                    command.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    // If the query returned a row, create the Customer object and return it.
                    if (reader.HasRows)
                    {
                        reader.Read();

                        string name = (string)reader["Name"];
                        bool isPremiumMember = (bool)reader["IsPremiumMember"];

                        return new Customer(id, name, isPremiumMember);
                    }
                }
            }

            return null;
        }

        public void Save(Customer customer)
        {
            // INSERT and UPDATE methods go here
        }

        public void Delete(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [Id] = @Id";
                    command.Parameters.AddWithValue("@Id", customer.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
