﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _mark;

        public string Title { get; set; }

        public string TeacherFirstName { get; set; }

        public string TeacherLastName { get; set; }

        public Subject() { }

        public Subject(string title, int mark, string firstNameTeacher, string lastNameTeacher)
        {
            Title = title;
            Mark = mark;
            TeacherFirstName = firstNameTeacher;
            TeacherLastName = lastNameTeacher;
        }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException(
                        "Неверная оценка");
                }

                _mark = value;
            }
        }
        
    }
}
