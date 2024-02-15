using AutoMapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.Infra;

namespace Musify.API.Services
{
    public abstract class CrudService<TModel, TDto> : ICrudService<TModel, TDto> 
        where TModel: class, IIdentifiable
        where TDto : class, IIdentifiable
    {
        protected IMapper _mapper;
        protected ApplicationDbContext _context;
        protected DbSet<TModel> _entity;

        public CrudService(ApplicationDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
            this._entity = context.Set<TModel>();
        }

        /// <summary>
        /// Fetches entity based on an Id
        /// </summary>
        /// <param name="id">Id to check for</param>
        /// <returns>Found <typeparamref name="TDto"/></returns>
        public virtual async Task<TDto> GetById(int id)
        {
            TModel? model = await this._entity.FindAsync(id);
            return this._mapper.Map<TDto>(model);
        }

        /// <summary>
        /// Fetches all entities
        /// </summary>
        /// <returns>A list of <typeparamref name="TDto"/></returns>
        public virtual async Task<List<TDto>> GetAll()
        {
            var models = await this._entity.ToListAsync();
            return this._mapper.Map<List<TDto>>(models);
        }

        /// <summary>
        /// Create entity
        /// </summary>
        /// <param name="dto">Entity to be created</param>
        /// <returns>Boolean determining success</returns>
        public virtual async Task<bool> Create(TDto dto)
        {
            var model = this._mapper.Map<TModel>(dto);

            this._entity.Add(model);
            int changed = await this._context.SaveChangesAsync();

            dto.Id = model.Id;
            return changed == 1;
        }

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="dto">Entity to be updated</param>
        /// <returns>Boolean determining success</returns>
        public virtual async Task<bool> Update(TDto dto)
        {
            var model = this._mapper.Map<TModel>(dto);

            this._entity.Update(model);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="id">Id of entity to be deleted</param>
        /// <returns>Boolean determining success</returns>
        public virtual async Task<bool> Delete(int id)
        {
            var model = await this._entity.FindAsync(id);

            this._entity.Remove(model);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }

        /// <summary>
        /// Checks wether an entity exists
        /// </summary>
        /// <param name="id">Id to be checked</param>
        /// <returns>Boolean determining if the entity exists</returns>
        public virtual bool Exists(int id) =>
            this._entity.Find(id) != null;

        /// <summary>
        /// Counts the amount of entities found
        /// </summary>
        /// <returns>Number of records</returns>
        public virtual int Count() =>
            this._entity.Count();
    }
}
