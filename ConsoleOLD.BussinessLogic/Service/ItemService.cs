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
    public class ItemService : IItem
    {
        protected SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        string query;

        public ItemService()
        {
            connection = DbConnection.getConnection();
        }

        public void Delete(int id)
        {
            query = "update Items set IsDelete = '" + true + "', DeleteDate = '" + DateTimeOffset.UtcNow.ToLocalTime() + "' where Id = '" + id + "'";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            Console.Write("Delete Successfully");
            connection.Close();
        }

        public void Display()
        {
            query = "select * from Items";

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

        public void Insert(string name, int price, int stock, int id)
        {
            query = "insert into Items " +
                "(Name, Price, Stock, Supplier_Id, CreateDate, IsDelete) " +
                "values " +
                "('" + name + "', '" + price + "', '" + stock + "', '" + id + "', '" + DateTimeOffset.UtcNow.ToLocalTime() + "', '" + 0 + "')";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            Console.Write("Insert Successfully");
            connection.Close();
        }

        public void Update(int id, int price)
        {
            query = "update Suppliers set Price = '" + price + "', UpdateDate = '" + DateTimeOffset.UtcNow.ToLocalTime() + "' where Id = '" + id + "'";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            Console.Write("Update Successfully");
            connection.Close();
        }
    }
}
