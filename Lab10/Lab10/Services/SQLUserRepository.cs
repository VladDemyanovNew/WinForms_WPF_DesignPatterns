using Lab10.Context;
using Lab10.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lab10.Models;
using System.Data;

namespace Lab10.Services
{
    public class SQLUserRepository : IGenericRepository<User>
    {
        public void Add(User entity)
        {
            string sqlExpression = $"INSERT INTO Users (Name, Age) VALUES ('{entity.Name}', {entity.Age})";

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }

        public IEnumerable<User> GetAll()
        {
            string sqlExpression = "SELECT * FROM Users";
            List<User> users = new List<User>();

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(2);
                        int age = reader.GetInt32(1);
                        User user = new User { Id = id, Age = age, Name = name };
                        users.Add(user);
                    }
                }
                reader.Close();
            }

            return users;
        }

        public User Get(int id)
        {
            string sqlExpression = $"SELECT * FROM Users WHERE Id = {id}";
            User user = null;

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        string name = reader.GetString(2);
                        int age = reader.GetInt32(1);
                        user = new User { Id = id, Age = age, Name = name };
                        return user;
                    }
                }
                reader.Close();
            }
            return user;
        }

        public void Remove(int id)
        {
            string sqlExpression = $"DELETE FROM Users WHERE Id={id}";

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Удалено объектов: {number}");
            }
        }

        public void Update(User entity)
        {
            string sqlExpression = $"UPDATE Users SET Age={entity.Age}, Name='{entity.Name}' WHERE Id={entity.Id}";

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Обновлено объектов: {number}");
            }
        }

        public int AddUserUsingProcedure(string name, int age)
        {
            // название процедуры
            string procName = "sp_InsertUser";
            int id;

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();

                IsExistProcQuery(procName);

                SqlCommand command2 = new SqlCommand(procName, connection);
                // указываем, что команда представляет хранимую процедуру
                command2.CommandType = CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = name
                };
                // добавляем параметр
                command2.Parameters.Add(nameParam);
                // параметр для ввода возраста
                SqlParameter ageParam = new SqlParameter
                {
                    ParameterName = "@age",
                    Value = age
                };
                command2.Parameters.Add(ageParam);

                // выполняем процедуру
                id = Convert.ToInt32(command2.ExecuteScalar());

            }
            return id;
        }

        /// <summary>
        /// Метод создаёт процеду, если её не существует
        /// </summary>
        /// <param name="procName"></param>
        private void IsExistProcQuery(string procName)
        {
            string proc = @"CREATE PROCEDURE [dbo].[sp_InsertUser]
                                @name nvarchar(50),
                                @age int
                            AS
                                INSERT INTO Users (Name, Age)
                                VALUES (@name, @age)
   
                                SELECT SCOPE_IDENTITY()
                            GO";
            string isExistProcQuery = $"Select * From INFORMATION_SCHEMA.ROUTINES Where ROUTINE_NAME = '{procName}'";

            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(isExistProcQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    SqlCommand command3 = new SqlCommand(proc, connection);

                    // добавляем процедуру
                    command3.ExecuteNonQuery();
                    Console.WriteLine("Хранимая процедура добавлена в базу данных.");
                }
            }
        }

    }
}
