namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает класс <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класс <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle() 
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота.</param>
        /// <param name="width">Ширина.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты левой верхней точки.</param>
        public Rectangle(int height, int width, string color, Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            _id = _allRectanglesCount;
            Center = center;
        }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника.<br/>Значение должно быть неотрицательным.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника.<br/>Значение должно быть неотрицательным.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Задает и возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создание скроки вида: "Rectangle {id}"
        /// </summary>
        /// <returns>Строка с идентификатором прямоугольника.</returns>
        public override string ToString()
        {
            return $"Rectangle {_id}";
        }

        /// <summary>
        /// Возвращает количество всех прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
    }
}
