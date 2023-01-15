using BackendTest.Data;
using BackendTest.Dtos;
using BackendTest.Models;
using BackendTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _service;
        private readonly DataContext _datacontext;

        public UserController(IUser service, DataContext datacontext)
        {
            _service = service;
            _datacontext = datacontext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var user =  _service.GetUsers().Select(item => item.AsUserDto());
            return  Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateUser(UserDto userdto)
        {
            User user = new()
            {
                UserId = userdto.UserId,
                Nom = userdto.Nom,
                Prenom = userdto.Prenom,
                Email = userdto.Email,
                Password = userdto.Password,
                AnneeScholaire = userdto.AnneeScholaire,
                Filiere = userdto.Filiere,
            };

            _service.CreateUser(user);

            return CreatedAtAction(nameof(GetUsers), new { id = user.UserId }, user.AsUserDto());
        }
    }
}
