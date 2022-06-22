namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит координаты объекта.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата Х.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D">.
        /// </summary>
        /// <param name="x">Координата Х.</param>
        /// <param name="y">Координата Y.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задает координату Х.<br/>Значение должно быть неотрицательным.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Х.<br/>Значение должно быть неотрицательным.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }
    }
}
