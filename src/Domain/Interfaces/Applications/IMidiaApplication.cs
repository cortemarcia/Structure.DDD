using Gama.RedeSocial.Domain.Entities;
using System;
using System.IO;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IMidiaApplication : IApplicationBase<Midia>
    {
        FileStream GetAvatarByUserId(Guid userId, String rootPath);
    }
}
