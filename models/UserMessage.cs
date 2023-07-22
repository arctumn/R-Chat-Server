namespace R_Chat_Server.models
{
    public class UserMessage
    {
        public string Message { get; set; } = string.Empty;
        public DateTime SentDate { get; set; }
        public UserDetails User { get; set; } = new();
    }
}
