namespace R_Chat_Server.models
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<UserMessage> Messages { get; set; } = Enumerable.Empty<UserMessage>();
    }
}
