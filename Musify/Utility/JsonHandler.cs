using Musify.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Musify.Utility
{
    public static class JsonHandler
    {
        // Generic json options.
        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        // Gives you all items of given type.
        public static List<T> GetAll<T>()
        {
            // Determine the file name.
            string filepath = $"../../../Lib/Data/{typeof(T).Name.ToLower()}.json";

            // Get all contents of the file.
            string content = JsonHandler.GetFileContents(filepath).Result;
            if (content == string.Empty)
                return new();

            // Tries to convert the contents to Json, and returns it.
            try
            {
                var result = JsonSerializer.Deserialize<List<T>>(content, JsonHandler._options);
                return result ?? new();
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.GetBaseException());
                return new();
            }
        }

        // Gives by specific ID.
        public static T GetById<T>(Guid id) where T: IIdentifiable
        {
            var items = JsonHandler.GetAll<T>();

            return (from item in items
                       where item.Id == id
                       select item).First();
        }

        // Saves given model.
        public static bool Add<T>(T model)
        {
            // Won't save 'nothing'.
            if (model == null)
                return false;

            // Get all current models, and add the new one.
            var models = JsonHandler.GetAll<T>();
            models.Add(model);

            return JsonHandler.Save(models);
        }

        // Overwrites all existing data with a lsit
        public static bool Save<T>(List<T> models)
        {
            if (models == null)
                return false;

            // Determine the file name.
            string filepath = $"../../../Lib/Data/{typeof(T).Name.ToLower()}.json";

            // Tries to convert the contents to plain text, and saves it.
            try
            {
                string json = JsonSerializer.Serialize(models, JsonHandler._options);
                return JsonHandler.SaveFileContents(filepath, json).Result;
            }
            catch (JsonException ex)
            {
                return false;
            }
        }

        // Gives you all text content in the specified file.
        private static Task<string> GetFileContents(string filepath)
        {
            return Task.Run(async () =>
            {
                // Quick check to ensure the file actually exists.
                if (!File.Exists(filepath))
                    return string.Empty;

                // Open a filestream and return the data.
                using FileStream stream = new(filepath, FileMode.Open, FileAccess.Read);
                using (StreamReader reader = new(stream, Encoding.UTF8))
                {
                    return await reader.ReadToEndAsync();
                }
            });
        }

        // Saves all text content given, in the specified file.
        private static Task<bool> SaveFileContents(string filepath, string content)
        {
            return Task.Run(async () =>
            {
                using FileStream stream = new(filepath, FileMode.Create, FileAccess.Write);
                using (StreamWriter writer = new(stream, Encoding.UTF8))
                {
                    try
                    {
                        await writer.WriteAsync(content);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            });
        }

    }
}