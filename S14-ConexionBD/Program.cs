using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14_ConexionBD
{
    class Program
    {
        static void Main()
        {
            string connectionString =
                "Data Source=(local);Initial Catalog=Northwind;"
                + "Integrated Security=true";
            //string connectionString =
            //    "Data Source=NOMBREPC\\SQLEXPRESS;Initial Catalog=Northwind;"
            //    + "Integrated Security=true";

            selectProduct(connectionString, 50);

            //selectCustomers(connectionString);
        }

        /// <summary>
        /// Metodo para consultar datos de la tabla CUSTOMERS
        /// </summary>
        /// <param name="conS">String de conexion</param>
        private static void selectCustomers(string conS)
        {
            //OPCION 1: consulta completa en queryString
            //string queryString ="SELECT CustomerID, CompanyName, ContactName, ContactTitle from dbo.Customers WHERE ContactTitle LIKE 'Owner' ";

            //OPCION2: consulta parametrizada mediante command parameters
            string queryString = "SELECT CustomerID, CompanyName, ContactName, ContactTitle from dbo.Customers WHERE ContactTitle LIKE @titleOwner ";

            // Specify the parameter value.
            string paramValue = "Owner";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(conS))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@titleOwner", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                Console.ReadLine();
            }//end using
        }

        /// <summary>
        /// Metodo que permite obtener datos de la tabla PRODUCT
        /// </summary>
        /// <param name="conS">String de conexion</param>
        /// <param name="precio">valor del precio del producto</param>
        public static void selectProduct(string conS, int precio) {
            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT ProductID, UnitPrice, ProductName from dbo.products "
                    + "WHERE UnitPrice > @pricePoint "
                    + "ORDER BY UnitPrice DESC;";

            // Specify the parameter value.
            //int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(conS))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", precio);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                Console.ReadLine();
            }//end using
        }

    }
}
