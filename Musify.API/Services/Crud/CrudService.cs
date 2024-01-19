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

        public virtual async Task<TDto> GetById(int id)
        {
            TModel? model = await this._entity.FindAsync(id);
            return this._mapper.Map<TDto>(model);
        }

        public virtual async Task<List<TDto>> GetAll()
        {
            var models = await this._entity.ToListAsync();
            return this._mapper.Map<List<TDto>>(models);
        }

        public virtual async Task<bool> Create(TDto dto)
        {
            var model = this._mapper.Map<TModel>(dto);

            this._entity.Add(model);
            int changed = await this._context.SaveChangesAsync();

            dto.Id = model.Id;
            return changed == 1;
        }

        public virtual async Task<bool> Update(TDto dto)
        {
            var model = this._mapper.Map<TModel>(dto);

            this._entity.Update(model);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }

        public virtual async Task<bool> Delete(int id)
        {
            var model = await this._entity.FindAsync(id);

            this._entity.Remove(model);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }

        public virtual bool Exists(int id) =>
            this._entity.Find(id) != null;

        public virtual int Count() =>
            this._entity.Count();
    }
}
