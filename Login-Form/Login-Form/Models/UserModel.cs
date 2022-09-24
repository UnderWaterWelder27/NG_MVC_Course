namespace Login_Form.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLogged { get; set; }
    }
}
