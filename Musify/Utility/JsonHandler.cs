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
        public static async Task<List<T>> GetAll<T>()
        {
            // Determine the file name.
            string filepath = $"{typeof(T).Name.ToLower()}.json";

            // Get all contents of the file.
            string content = await JsonHandler.GetFileContents(filepath);
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

        // Saves given model.
        public static async Task<bool> Add<T>(T model)
        {
            // Won't save 'nothing'.
            if (model == null)
                return false;

            // Get all current models, and add the new one.
            var models = await JsonHandler.GetAll<T>();
            models.Add(model);

            // Determine the file name.
            string filepath = $"{typeof(T).Name.ToLower()}.json";

            // Tries to convert the contents to plain text, and saves it.
            try
            {
                string json = JsonSerializer.Serialize(models, JsonHandler._options);
                return await JsonHandler.SaveFileContents(filepath, json);
            }
            catch (JsonException ex)
            {
                return false;
            }
        }


        // Gives you all text content in the specified file.
        private static async Task<string> GetFileContents(string filepath)
        {
            // Quick check to ensure the file actually exists.
            if (!File.Exists(filepath)) 
                return string.Empty;

            using FileStream stream = new(filepath, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new(stream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }

        // Saves all text content given, in the specified file.
        // TODO: do something with the return value.
        private static async Task<bool> SaveFileContents(string filepath, string content)
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
        }

    }
}