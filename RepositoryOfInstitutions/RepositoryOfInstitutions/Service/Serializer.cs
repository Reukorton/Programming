using System;
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
        public const string _filePath = "List Of institution\\save_institution.json";

        /// <summary>
        /// Сериализует коллекцию <see cref="Institution"/> в файл json.
        /// </summary>
        /// <param name="institutions">Учреждения.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Serialize(List<Institution> institutions, string filePath)
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
        public static List<Institution> Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(path, false))
            using (var reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Institution>>(reader) ?? new List<Institution>();
            }
        }

        /// <summary>
        /// Создает мета-данные приложения в папке AppData.
        /// </summary>
        public static void CreateFilesToAppData()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var directory = Path.Combine(appDataPath, "List Of institution");

            if (Directory.Exists(directory)) return;
            Directory.CreateDirectory(directory);

            var filePath = Path.Combine(appDataPath, _filePath);

            if (File.Exists(filePath)) return;
            using (FileStream _ = File.Create(filePath)) { }  
        }

        /// <summary>
        /// Загрузка данных из файла на форму.
        /// </summary>
        public static List<Institution> LoadInstitutionFromJson()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(appDataPath, _filePath);
            var institutions = Serializer.Deserialize(filePath);

            return institutions;
        }

        /// <summary>
        /// Сохраняет значения списка.
        /// </summary>
        /// <param name="institution">Сохраняемый список.</param>
        public static void SaveInfo(List<Institution> institution)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(appDataPath, _filePath);
            Serialize(institution, filePath);
        }
    }
}
