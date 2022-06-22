using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Центр кольца.</param>
        /// <param name="outerRadius">Внешний радиус кольца.</param>
        /// <param name="innerRadius">Внутренний радиус кольца.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        /// <summary>
        /// Возвращает и задает координаты центра кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца.<br/>Значение должно быть больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, _innerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус кольца.<br/>
        /// Значение должно быть меньше большего внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, _outerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площать кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
            }
        }
    }
}
