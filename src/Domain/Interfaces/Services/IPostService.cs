using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IPostService : IServiceBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
