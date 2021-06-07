using Lab10.Context;
using Lab10.Models;
using Lab10.Services;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLUserRepository sqlUserRepository = new SQLUserRepository();

            User Alex = new User { Age = 19, Name = "Alex" };
            User AlexUpd = new User { Id = 2, Age = 22, Name = "AlexUpd" };
            User UserForRemove = new User { Age = 17, Name = "UserForRemove" };

            //sqlUserRepository.Add(Alex);
            //sqlUserRepository.Update(AlexUpd);
            //sqlUserRepository.Remove(1);

            // GetAll ------------------------------------------------------
            Console.WriteLine("\nТестирование метода GetAll:");
            List<User> users = sqlUserRepository.GetAll().ToList();
            foreach(User user in users)
            {
                Console.WriteLine(user.ToString());
            }

            // Get ----------------------------------------------------------
            Console.WriteLine("\nТестирование метода Get:");
            User TestGet = sqlUserRepository.Get(-1);
            if (TestGet == null)
                Console.WriteLine("Пользователь не найден");
            else
                Console.WriteLine(TestGet.ToString());

            // AddUserUsingProcedure -----------------------------------------
            Console.WriteLine($"\nТестирование метода AddUserUsingProcedure:");
            int id = sqlUserRepository.AddUserUsingProcedure("UserTestProc", 23);
            Console.WriteLine($"Id добавленного объекта: {id}");

            // Транзакзия ----------------------------------------------------
            Console.WriteLine($"\nТестирование транзакции:");
            TestTransaction();

            Console.Read();
        }

        private static void TestTransaction()
        {
            using (SqlConnection connection = SqlConnectionFactory.CreateDbContext())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    // выполняем две отдельные команды
                    command.CommandText = "INSERT INTO Users (Name, Age) VALUES('Tim', 34)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Users (Name, Age) VALUES('Kat', 31)";
                    command.ExecuteNonQuery();
                    // ошибка
                    command.CommandText = "INSERT INTO Users (Id, Name, Age) VALUES(1,'Kat', 31)";
                    command.ExecuteNonQuery();

                    // подтверждаем транзакцию
                    transaction.Commit();
                    Console.WriteLine("Данные добавлены в базу данных");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // если ошибка, откатываем назад все изменения
                    transaction.Rollback();
                }
            }
        }

    }
}
