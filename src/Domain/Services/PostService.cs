﻿using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Services
{
    public class PostService : ServiceBase<Post>, IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Post> GetFeedByUserId(Guid userId)
        {
            return _repository.GetFeedByUserId(userId);
        }
    }
}
