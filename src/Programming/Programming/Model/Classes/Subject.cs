using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Subject
    {
        private int _mark;

        public string Title { get; set; }

        public string FirstNameTeacher { get; set; }

        public string MiddleNameTeacher { get; set; }

        public string LastNameTeacher { get; set; }

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
