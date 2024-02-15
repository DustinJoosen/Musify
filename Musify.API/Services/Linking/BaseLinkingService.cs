using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Services.Linking
{
    public abstract class BaseLinkingService<T1, T2>
        where T1: class, IIdentifiable 
        where T2: class, IIdentifiable
    {

        /// <summary>
        /// Links two entities
        /// </summary>
        /// <param name="entity1">Entity 1 to be linked</param>
        /// <param name="entity2">Entity 2 to be linked</param>
        /// <returns>Boolean determining success</returns>
        public async Task<bool> Link(T1 entity1, T2 entity2) =>
            await this.Link(entity1.Id, entity2.Id);

        /// <summary>
        /// Unlinks two entities
        /// </summary>
        /// <param name="entity1">Entity 1 to be unlinked</param>
        /// <param name="entity2">Entity 2 to be unlinked</param>
        /// <returns>Boolean determining success</returns>
        public async Task<bool> Unlink(T1 entity1, T2 entity2) =>
            await this.Unlink(entity1.Id, entity2.Id);

        public abstract Task<bool> Link(int id1, int id2);
        public abstract Task<bool> Unlink(int id1, int id2);

    }
}
