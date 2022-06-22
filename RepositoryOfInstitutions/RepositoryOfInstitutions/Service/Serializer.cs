using System.Collections.Generic;
using System.IO;
using RepositoryOfInstitutions.Model;
using Newtonsoft.Json;

namespace RepositoryOfInstitutions.Service
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Сериализует коллекцию <see cref="Institution"/> в файл json.
        /// </summary>
        /// <param name="institutions">Учреждения.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void NotesToJson(List<Institution> institutions, string filePath)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, institutions);
            }
        }

        /// <summary>
        /// Сериализует файл json в <see cref="Institution"/>.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns></returns>
        public static List<Institution> FromJson(string path)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(path, false))
            using (var reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Institution>>(reader) ?? new List<Institution>();
            }
        }
    }
}
