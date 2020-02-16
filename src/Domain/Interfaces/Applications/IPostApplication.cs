using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IPostApplication : IApplicationBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
