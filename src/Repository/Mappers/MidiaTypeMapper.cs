using Gama.RedeSocial.Domain.Entities;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    public class MidiaTypeMapper : BaseMapper<MidiaType>
    {
        public MidiaTypeMapper()
        {
            ToTable("TB_MIDIA_TYPE");
            Map(entity => entity.Description).ToColumn("DS_MIDIA_TYPE");
            Map(entity => entity.Extensions).ToColumn("DS_EXTENSIONS");
        }
    }
}
