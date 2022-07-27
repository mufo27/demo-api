using System;
using Microsoft.AspNetCore.Mvc;
using demoapi.Models;

namespace demoapi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<UsersModel>  Get()
        {
            List<UsersModel> list = new List<UsersModel>();
            list.Add(new UsersModel
            {
                Id = 1,
                Name = "User1",
                Age = 10
            });
            list.Add(new UsersModel
            {
                Id = 2,
                Name = "User2",
                Age = 20
            });
            return list;
        }

        [HttpGet("{id}")]
        public UsersModel Get(int id)
        {
            return new UsersModel
            {
                Id = id,
                Name = "User1",
                Age = 20
            };
        }

        [HttpDelete("{id}")]
        public UsersModel Delete(int id)
        {
            return new UsersModel
            {
                Id = id,
                Name = "Deleted",
                Age = 20
            };
        }

        [HttpPost]
        public UsersModel Create(UsersModel data)
        {
            data.Name += " Created";
            return data;
        }

        [HttpPut]
        public UsersModel Update(UsersModel data)
        {
            data.Name += " Updated";
            return data;
        }
    }
}