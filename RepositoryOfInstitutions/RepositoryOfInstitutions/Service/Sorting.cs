
using System.Collections.Generic;
using System.Linq;
using RepositoryOfInstitutions.Model;

namespace RepositoryOfInstitutions.Service
{
    public static class Sorting
    {
        /// <summary>
        /// Сортировка по категории, а внутри по алфавиту.
        /// </summary>
        /// <param name="institutions">Искомое значение.</param>
        /// <returns>Отсортированный список.</returns>
        public static List<Institution> Sort(List<Institution> institutions)
        {
            var sortedInstitution = from value in institutions
                                    orderby value.Category, value.Title
                                    select value;
            institutions = sortedInstitution.ToList();

            return institutions;
        }
    }
}
