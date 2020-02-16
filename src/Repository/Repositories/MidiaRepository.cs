using Dapper;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Linq;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class MidiaRepository : RepositoryBase<Midia>, IMidiaRepository
    {
        public Midia GetAvatarByUserId(Guid userId)
        {
            var sql = @"SELECT 
                        TB_MIDIA.*,
                        TB_MIDIA_TYPE.*

                        FROM TB_MIDIA

                        INNER JOIN TB_USER ON TB_USER.ID_AVATAR = TB_MIDIA.ID

                        INNER JOIN TB_MIDIA_TYPE ON TB_MIDIA.ID_MIDIA_TYPE = TB_MIDIA_TYPE.ID

                        WHERE TB_USER.ID = @userId ";

            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Query<Midia, MidiaType, Midia>(sql, (midia, midiatype) => 
                {
                    midia.MidiaType = midiatype;

                    midia.MidiaTypeId = midiatype.Id;

                    return midia;
                },
                splitOn: "ID",
                param: new {userId}
                )
                .First();
            }
        }
    }
}
