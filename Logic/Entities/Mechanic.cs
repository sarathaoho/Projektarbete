﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class Mechanic
    {
        public string MechanicID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<String> Competences { get; set; }

        //public List<Errands> CurrentErrands { get; set; }
        public Mechanic(string firstname, string lastname, DateTime dateofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            Competences = new List<string>(); //Skills?
            CalculateAge();
            SetMechanicID();
        }

        /// <summary>
        /// Sätter mekanikerns ID till mekanikerns initialer och födelseår.
        /// </summary>
        private void SetMechanicID()
        {
            //Behöver läggas till någon safety check så att det inte går att lägga till ett mekanikerid med samma värde.
            var sb = new StringBuilder();

            //Lägger till förnamnets första två bokstäver
            var chars = FirstName.ToUpper().ToCharArray();
            sb.Append(chars[0] + chars[1].ToString());

            //Lägger in efternamnets första två bokstäver
            chars = LastName.ToUpper().ToCharArray();
            sb.Append(chars[0] + chars[1].ToString());

         
            //Lägger in datumet;
            sb.Append(DateOfBirth.ToString("yyMMdd"));

           
            //Skickar ut hela strängen till mekanikerID:et
            MechanicID = sb.ToString();
        }

        /// <summary>
        /// Räknar ut åldern baserat på mekanikerns födelsedag
        /// </summary>
        private void CalculateAge()
        {
            var today = DateTime.Today;

            Age = today.Year - DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                Age = Age - 1;
            }
        }

    }
}
