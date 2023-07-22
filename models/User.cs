namespace R_Chat_Server.models
{
    public class User
    {
        public int Id { get; set; }
        public string Uuid { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
    public class UserDetails
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
}
