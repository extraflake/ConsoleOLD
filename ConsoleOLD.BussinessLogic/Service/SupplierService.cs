using ConsoleOLD.Connection;
using ConsoleOLD.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Service
{
    public class SupplierService : ISupplier
    {
        protected SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        string query;
        
        public SupplierService()
        {
            connection = DbConnection.getConnection();
        }

        public void Add(string name)
        {
            query = "insert into Suppliers (Name, CreateDate, IsDelete) values ('" + name + "', '" + DateTimeOffset.UtcNow.ToLocalTime() + "', '" + 0 + "')";
            
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            Console.Write("Insert Successfully");
            connection.Close();
        }

        public void Update(int id, string name)
        {
            query = "update Suppliers set Name = '" + name + "', UpdateDate = '" + DateTimeOffset.UtcNow.ToLocalTime() + "' where Id = '" + id + "'";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            Console.Write("Update Successfully");
            connection.Close();
        }

        public void Display()
        {
            query = "select * from Suppliers";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    for (int display = 1; display <= 100; display++)
                    {
                        Console.WriteLine(reader.GetValue(display));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.Read();
            }
            Console.Write("Display Successfully");
            connection.Close();
        }

        public void Delete(int id)
        {
            query = "update Suppliers set IsDelete = '" + true + "', DeleteDate = '" + DateTimeOffset.UtcNow.ToLocalTime() + "' where Id = '" + id + "'";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            Console.Write("Delete Successfully");
            connection.Close();
        }
    }
}
