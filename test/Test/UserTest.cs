using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Gama.RedeSocial.Test
{
    [TestClass]
    public class UserTest : BaseTest
    {
        private readonly IUserService _service;
        
        public UserTest()
        {
            var repository = new UserRepository();

            _service = new UserService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameNull()
        {
            var user = new User();

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailNull()
        {
            var user = new User() 
            {
                Name = "Ana"
            };

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmailInvalid()
        {
            var user = new User()
            {
                Name = "Ana",
                Email = "teste"
            };

            _service.Insert(user);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var user = new User()
            {
                Birthday = new DateTime(1990, 08, 08),
                Name = "TESTE",
                Email = "teste@gmail.com",
                Password = "12345678",
                AvatarId = new Guid("16A1BCE4-2F14-455A-97FE-164589E32E46"),
                GenderId = new Guid("D42AA751-73C0-4BA6-A072-60261D74B58A"),
            };

            var id = _service.Insert(user);

            //_service.Delete(id);
        }

        [TestMethod]
        public void GetById()
        {
            var result = _service.Get(new Guid("DAAEE0A1-3E61-431F-A1AF-5BC373D6754C"));
        }
    }
}
