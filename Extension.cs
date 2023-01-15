using BackendTest.Dtos;
using BackendTest.Models;

namespace BackendTest
{
    public static class Extension
    {
        public static UserDto AsUserDto(this User user)
        {
            return new UserDto
            {
                UserId = user.UserId,
                Nom = user.Nom,
                Prenom = user.Prenom,
                Email = user.Email,
                Password = user.Password,
                AnneeScholaire = user.AnneeScholaire,
                Filiere = user.Filiere,
            };
        }
    }
}
