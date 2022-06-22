namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о предмете.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка за предмет.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Название предмета.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Имя учителя по предмету.
        /// </summary>
        public string TeacherFirstName { get; set; }


        /// <summary>
        /// Фамилия учителя по предмету.
        /// </summary>
        public string TeacherLastName { get; set; }

        /// <summary>
        /// Создает пустой класс <see cref="Subject"/>
        /// </summary>
        public Subject() { }

        /// <summary>
        /// Создает класс <see cref="Subject"/>
        /// </summary>
        /// <param name="title">Предмет.</param>
        /// <param name="mark">Оценка.</param>
        /// <param name="firstNameTeacher">Имя учителя.</param>
        /// <param name="lastNameTeacher">Фамилия учителя.</param>
        public Subject(string title, int mark, string firstNameTeacher, string lastNameTeacher)
        {
            Title = title;
            Mark = mark;
            TeacherFirstName = firstNameTeacher;
            TeacherLastName = lastNameTeacher;
        }

        /// <summary>
        /// Возвращает и задает оценки за предмет.<br/> Значение должно быть от 0 до 5.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Mark));
                _mark = value;
            }
        }
    }
}