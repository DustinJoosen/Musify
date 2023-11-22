using Musify.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Musify.Utility
{
    public static class JsonHandler
    {
        /// <summary>
        /// Options for writing to the json file.
        /// </summary>
        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
        };

        /// <summary>
        /// Returns a specific model
        /// </summary>
        /// <typeparam name="T">Type to get</typeparam>
        /// <param name="id">The Id fitting the model</param>
        /// <returns>Specified model</returns>
        public static T GetById<T>(Guid id) where T : IIdentifiable
        {
            var items = JsonHandler.GetAll<T>();

            return (from item in items
                    where item.Id == id
                    select item).First();
        }

        /// <summary>
        /// Returns all models out of file.
        /// </summary>
        /// <typeparam name="T">Type to get</typeparam>
        /// <returns>List of all models</returns>
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

        /// <summary>
        /// Adds the model to the file.
        /// </summary>
        /// <typeparam name="T">Type to add the model.</typeparam>
        /// <param name="model">Model to add</param>
        /// <returns>Boolean indicating success</returns>
        public static bool Add<T>(T model)
        {
            // Won't save 'nothing'.
            if (model == null)
                return false;

            // Get all current models, and add the new one.
            var models = JsonHandler.GetAll<T>();
            models.Add(model);

            return JsonHandler.SaveAll(models);
        }

        /// <summary>
        /// Saves all models. This overwrites the existing data.
        /// </summary>
        /// <typeparam name="T">Type to add the models.</typeparam>
        /// <param name="models">List of models to add</param>
        /// <returns>Boolean indicating success</returns>
        public static bool SaveAll<T>(List<T> models)
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

        /// <summary>
        /// Updates a given model
        /// </summary>
        /// <typeparam name="T">Type to update the model. Required to implement IIdentifiable</typeparam>
        /// <param name="id">Id of the model to update.</param>
        /// <param name="model">Model to update.</param>
        /// <returns>Boolean indicating success</returns>
        public static bool Update<T>(Guid id, T model) where T : IIdentifiable
        {
            // No updating to something empty.
            if (model == null)
                return false;

            // Id's should match
            if (!id.Equals(model.Id))
                return false;

            var items = JsonHandler.GetAll<T>();

            for (int i = 0; i < items.Count(); i++)
            {
                // if it's no match, continue.
                if (!items[i].Id.Equals(id))
                    continue;

                // It's a match. Overwrite with given model.
                items[i] = model;
                break;
            }

            // Update the list to the file.
            return JsonHandler.SaveAll<T>(items);
        }

        /// <summary>
        /// Deletes based on given Id.
        /// </summary>
        /// <typeparam name="T">Type to remove model from. Required to implement IIdentifiable</typeparam>
        /// <param name="id">Id of the model to be deleted.</param>
        /// <returns>Boolean indicating success</returns>
        public static bool Delete<T>(Guid id) where T : IIdentifiable
        {
            var items = JsonHandler.GetAll<T>();

            for (int i = 0; i < items.Count(); i++)
            {
                // if it's no match, continue.
                if (!items[i].Id.Equals(id))
                    continue;

                // It's a match. Remove it.
                items.RemoveAt(i);
                break;
            }

            // Update the list to the file.
            return JsonHandler.SaveAll<T>(items);
        }

        /// <summary>
        /// Deletes given model.
        /// </summary>
        /// <typeparam name="T">Type to remove model from. Required to implement IIdentifiable</typeparam>
        /// <param name="model">Model to be deleted.</param>
        /// <returns>Boolean indicating success</returns>
        public static bool Delete<T>(T model) where T : IIdentifiable
        {
            return JsonHandler.Delete<T>(model.Id);
        }

        /// <summary>
        /// Returns all content of the file async.
        /// </summary>
        /// <param name="filepath">File to read the content from</param>
        /// <returns>Content out of the file</returns>
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

        /// <summary>
        /// Saves all given text async.
        /// </summary>
        /// <param name="filepath">File to save the content in</param>
        /// <param name="content">Content to be saved</param>
        /// <returns>Boolean indicating success</returns>
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