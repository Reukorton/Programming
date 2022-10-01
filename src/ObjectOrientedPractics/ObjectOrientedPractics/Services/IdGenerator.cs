namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации Id.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Стартовый id.
        /// </summary>
        private static int _id = 0;

        /// <summary>
        /// При вызове клааса, id личивается на 1.
        /// </summary>
        /// <returns>Уникальный id.</returns>
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}
