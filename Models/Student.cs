using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenliste.Models
{
    public class Student
    {
        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string DisplayName => $"{Firstname} {Surname}";

        public DateTime Birthdate { get; set; }

        public string ProfilePhoto { get; set; }

        public int Age
        {
            get
            {
                // Geburtstag: 1. Dez. 2000
                // jetzt: 23. Nov. 2022
                // =>  jetzt - Geburtsjahr = 22

                // age = 22
                var age = DateTime.Now.Year - Birthdate.Year;

                // 2022-11-23 09:15
                var now = DateTime.Now;

                // year = 2022
                var year = now.Year;

                // 2022-12-01
                var nextBirthMonthDay = DateTime.Parse(
                    String.Format("{0}-{1}-{2}", year, 
                    Birthdate.Month, Birthdate.Day)
                    );

                // 22 - 1 = 21
                if (nextBirthMonthDay > now)
                {
                    age = age - 1;
                }


                return age;
            }
        }


    }
}
