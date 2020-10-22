﻿using Logic.Entities;
using Logic.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Logic.DAL
{
    public class DataAccess<T>
    {
        //Path == T:s beteckning. Exempelvis DataAccess<User> gör så att pathen blir Dal\User.Json
        private string path = $@"DAL\{typeof(T).Name}.json";



        public DataAccess()
        {
            //Skapar upp en ny fil om det inte redan finns en fil för den valda datatypen.
            if (!File.Exists(path))
            {
                var entityfile = File.Create(path);
                entityfile.Close();

                if (typeof(T) == typeof(User))
                {
                    AddStandardUser();
                }
                if (typeof(T) == typeof(Mechanic))
                {
                    AddStandardMechanic();
                }
            }
        }

        /// <summary>
        /// Hämtar alla objekt i en lista av förvald typ
        /// </summary>
        /// <returns></returns>
        /// 
        public List<T> GetEntities()
        {
            StreamReader sr = new StreamReader(path);

            string jsonString = sr.ReadToEnd();
            List<T> entities = JsonSerializer.Deserialize<List<T>>(jsonString);
            sr.Close();

            return entities;
        }

        public void AddEntity(List<T> entities)
        {
            StreamWriter sw = new StreamWriter(path);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,

            };

            var jsonString = JsonSerializer.Serialize(entities, options);

            sw.Write(jsonString);
            sw.Close();
        }

        /// <summary>
        /// Overloadar addentity metoden om det inte finns några users i databasen.
        /// </summary>
        /// <param name="users"></param>
        private void AddEntity(List<User> users)
        {
            StreamWriter sw = new StreamWriter(path);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,

            };

            var jsonString = JsonSerializer.Serialize(users, options);

            sw.Write(jsonString);
            sw.Close();
        }  
        private void AddEntity(List<Mechanic> users)
        {
            StreamWriter sw = new StreamWriter(path);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,

            };

            var jsonString = JsonSerializer.Serialize(users, options);

            sw.Write(jsonString);
            sw.Close();
        }

        /// <summary>
        /// Körs bara om det inte finns några användare i JSONfilen. bör ändras på eller flyttas på.
        /// </summary>
        private void AddStandardUser()
        {
            var service = new UserService();
            List<Mechanic> mechanics = service.GetMechanics();

            foreach (var mechanic in mechanics)
            {
                if (mechanic.MechanicID == "BOSV670723") ;
                {
                    var user = new User(mechanic);
                    user.Username = "Bosse";
                    user.Password = "Meckarn123";
                    var users = new List<User>() { user };
                    AddEntity(users);
                    break;
                }
            }

        }
        private void AddStandardMechanic()
        {
            var mechanic = new Mechanic("Bosse", "Svensson", new DateTime(1967, 07, 23));
            var mechanics = new List<Mechanic>() { mechanic };
            AddEntity(mechanics);
        }

    }
}
