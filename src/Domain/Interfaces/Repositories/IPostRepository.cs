using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
