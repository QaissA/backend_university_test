namespace BackendTest.Dtos
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string AnneeScholaire { get; set; } = string.Empty;
        public string Filiere { get; set; } = string.Empty;
    }
}
