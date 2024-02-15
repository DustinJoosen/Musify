using Musify.Infra.Dtos;

namespace Musify.API.Services.Link
{
    public interface ILinkingService<T1, T2>
    {
        /// <summary>
        /// Links two entities
        /// </summary>
        /// <param name="id1">ID of Entity 1 to be linked</param>
        /// <param name="id2">ID of Entity 2 to be linked</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Link(int id1, int id2);

        /// <summary>
        /// Unlinks two entities
        /// </summary>
        /// <param name="id1">ID of Entity 1 to be unlinked</param>
        /// <param name="id2">ID of Entity 2 to be unlinked</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Unlink(int id1, int id2);

    }
}