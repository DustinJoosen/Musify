namespace Musify.API.Services
{
    public interface ICrudService<TModel, TDto>
    {
        public Task<List<TDto>> GetAll();
        public Task<TDto> GetById(int id);
        public Task<bool> Create(TDto model);
        public Task<bool> Update(TDto model);
        public Task<bool> Delete(int id);
        public bool Exists(int id);
        public int Count();
    }
}
