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
        private readonly string path = $@"DAL\{typeof(T).Name}.json";


        /// <summary>
        ///Skapar upp en ny fil om det inte redan finns en och lägger in en tom placeholderlista
        /// </summary>
        public void CreateNewFile()
        {
           
            if (!File.Exists(path))
            {
                var entityFile = File.Create(path);
                entityFile.Close();
                var emptyList = new List<T>();
                AddEntity(emptyList);
            }
        }

        /// <summary>
        /// Hämtar alla objekt i en lista av förvald typ
        /// </summary>
        /// <returns></returns>
        /// 
        public List<T> GetEntities()
        {
            CreateNewFile();

            StreamReader sr = new StreamReader(path);

            string jsonString = sr.ReadToEnd();
            List<T> entities = JsonSerializer.Deserialize<List<T>>(jsonString);
            sr.Close();

            return entities;
        }

        public void AddEntity(List<T> entities)
        {
            CreateNewFile();
            StreamWriter sw = new StreamWriter(path);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,

            };

            var jsonString = JsonSerializer.Serialize(entities, options);

            sw.Write(jsonString);
            sw.Close();
        }
    }
}
