using Musify.Infra.Dtos;

namespace Musify.API.Services.Link
{
    public interface ILinkingService<T1, T2>
    {
        public Task Link(T1 model1, T2 model2);
        public Task Unlink(T1 model1, T2 model2);
        public Task<bool> Link(int id1, int id2);
        public Task<bool> Unlink(int id1, int id2);

    }
}