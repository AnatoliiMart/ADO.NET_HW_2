using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;

namespace ADO.NET_HW_2.Models
{
    internal class DbVegs_Fruits: IDisposable
    {
        public DbConnection _connection;
        public DbVegs_Fruits()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["VegsAndFruitsDb"].ConnectionString;
            string factoryName = ConfigurationManager.AppSettings["DataProvider"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(factoryName);

            _connection = factory.CreateConnection();
            _connection.ConnectionString = connectionString;
            _connection.Open();
        }

        public void Dispose() => _connection.Close();

        public void DivideOnVegsAndFruits(DbCommand command, ref List<Fruis> fruis, ref List<Vegetables> vegetables)
        {
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Type"].ToString().ToLower() == "fruit")
                    fruis.Add(new Fruis()
                    {
                        Id = reader["ID"].ToString(),
                        Name = reader["Name"].ToString(),
                        Color = reader["Color"].ToString(),
                        Calories = (int)reader["Calories"]
                    });
                else if (reader["Type"].ToString().ToLower() == "vegetable")
                    vegetables.Add(new Vegetables()
                    {
                        Id = reader["ID"].ToString(),
                        Name = reader["Name"].ToString(),
                        Color = reader["Color"].ToString(),
                        Calories = (int)reader["Calories"]
                    });
            }
            reader.Close();
        }

        public DbCommand CommandCreation(string query)
        {
            string commandText = query;
            DbCommand command = _connection.CreateCommand();
            command.CommandText = commandText;
            return command;
        }
    }
}
