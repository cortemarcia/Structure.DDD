using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.IO;

namespace Gama.RedeSocial.Application
{
    public class MidiaApplication : ApplicationBase<Midia>, IMidiaApplication
    {
        private readonly IMidiaService _service;
        private readonly IMidiaRepository _repository;

        public MidiaApplication(IMidiaService service, IMidiaRepository repository) : base(service)
        {
            _service = service;
            _repository = repository;
        }

        public FileStream GetAvatarByUserId(Guid userId, String rootPath)
        {
            var midia = _repository.GetAvatarByUserId(userId);

            var fullpath = rootPath + midia.Path;

            return  File.OpenRead(fullpath);
        }
    }
}
