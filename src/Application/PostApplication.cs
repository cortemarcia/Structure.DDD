using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Application
{
    public class PostApplication : ApplicationBase<Post>, IPostApplication
    {
        private readonly IPostService _service;

        public PostApplication(IPostService Service) : base(Service)
        {
            _service = Service;
        }

        public IEnumerable<Post> GetFeedByUserId(Guid userId)
        {
            return _service.GetFeedByUserId(userId);
        }
    }
}
