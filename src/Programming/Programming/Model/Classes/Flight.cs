namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о рйсах самолетов.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета в минутах.<br/>
        /// Должно состоять из целых чисел.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string Departure { get; set; }


        /// <summary>
        /// Возвращает и задает место назначения.
        /// </summary>
        public string Destination { get; set; }
        
        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="flightTimeMinutes">Время полета в минутах.<br/> Должно состоять только из целых чисел</param>
        /// <param name="departure">Место отправления.</param>
        /// <param name="destination">Место назначения.</param>
        public Flight(int flightTimeMinutes, string departure, string destination)
        {
            FlightTimeMinutes = flightTimeMinutes;
            Departure = departure;
            Destination = destination;
        }

        /// <summary>
        /// Возращает и задает время полета в минутах.
        /// </summary>
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeMinutes));
                _flightTimeMinutes = value;
            }
        } 
    }
}
