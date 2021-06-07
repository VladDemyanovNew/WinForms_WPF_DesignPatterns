using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;

namespace Lab10.Context
{
    public class SqlConnectionFactory
    {
        public static SqlConnection CreateDbContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                sqlConnection.Open();
            }
            catch
            {
                CreateDataBase();
                CreateTables();
            }
            finally
            {
                // если подключение открыто
                if (sqlConnection.State == ConnectionState.Open)
                {
                    // закрываем подключение
                    sqlConnection.Close();
                }
            }

            return sqlConnection;
        }

        private static void CreateDataBase()
        {
            string connectionString2 = "Server=LENOVO_R2500U;Database=master;Trusted_Connection=True;";
            string sqlExpression = "CREATE DATABASE adonetdb";
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Connection = connection;
                // выполняем команду
                command.ExecuteNonQuery();
                Console.WriteLine("База данных создана");
            }
        }

        private static void CreateTables()
        {
            string connectionString2 = "Server=LENOVO_R2500U;Database=adonetdb;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE TABLE Users (Id INT PRIMARY KEY IDENTITY, Age INT NOT NULL, Name NVARCHAR(100) NOT NULL)";
                command.Connection = connection;
                command.ExecuteNonQuery();

                Console.WriteLine("Таблица Users создана");
            }
        }
        
    }
}
