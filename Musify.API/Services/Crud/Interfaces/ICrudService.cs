namespace Musify.API.Services
{
    public interface ICrudService<TModel, TDto>
    {
        /// <summary>
        /// Fetches all entities
        /// </summary>
        /// <returns>A list of <typeparamref name="TDto"/></returns>
        public Task<List<TDto>> GetAll();

        /// <summary>
        /// Fetches entity based on an Id
        /// </summary>
        /// <param name="id">Id to check for</param>
        /// <returns>Found <typeparamref name="TDto"/></returns>
        public Task<TDto> GetById(int id);

        /// <summary>
        /// Create entity
        /// </summary>
        /// <param name="model">Entity to be created</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Create(TDto model);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="model">Entity to be updated</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Update(TDto model);

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="id">Id of entity to be deleted</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Delete(int id);

        /// <summary>
        /// Checks wether an entity exists
        /// </summary>
        /// <param name="id">Id to be checked</param>
        /// <returns>Boolean determining if the entity exists</returns>
        public bool Exists(int id);

        /// <summary>
        /// Counts the amount of entities found
        /// </summary>
        /// <returns>Number of records</returns>
        public int Count();
    }
}
