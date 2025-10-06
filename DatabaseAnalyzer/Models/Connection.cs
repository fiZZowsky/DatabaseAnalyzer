namespace DatabaseAnalyzer.Models
{
    public class Connection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? SID { get; set; }
        public string? ServiceName { get; set; }
    }
}
