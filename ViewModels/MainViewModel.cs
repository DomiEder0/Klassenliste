using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Klassenliste.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenliste.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        Random gen = new Random();

        [ObservableProperty]
        ObservableCollection<Student> _students = 
            new ObservableCollection<Student>();


        [ObservableProperty]
        Student _student = new Student() { 
            Firstname = "",
            Surname = "",
            ProfilePhoto = "",
            Birthdate = DateTime.Now
        };

        public MainViewModel()
        {
            Student s1 = new Student()
            {
                Firstname = "Daniela",
                Surname = "Muster",
                Birthdate = DateTime.Parse("2000-10-11"),
                ProfilePhoto = "daniela.jpg"
            };
            this.Students.Add(s1);

            Student s2 = new Student()
            {
                Firstname = "Max",
                Surname = "Huber",
                Birthdate = DateTime.Parse("2003-11-11"),
                ProfilePhoto = "max.jpg"
            };
            this.Students.Add(s2);

            Student s3 = new Student()
            {
                Firstname = "Tina",
                Surname = "Muster",
                Birthdate = DateTime.Parse("2010-10-11"),
                ProfilePhoto = "tina.jpg"
            };
            this.Students.Add(s3);

            Student s4 = new Student()
            {
                Firstname = "Tom",
                Surname = "Mayer",
                Birthdate = DateTime.Parse("2000-11-25"),
                ProfilePhoto = "max.jpg"
            };
            this.Students.Add(s4);

        }

        [RelayCommand]
        void SelectStudent()
        {
            int num = gen.Next(0, this.Students.Count); // von 0 bis 3
            this.Student = this.Students[num];
        }

    }
}
