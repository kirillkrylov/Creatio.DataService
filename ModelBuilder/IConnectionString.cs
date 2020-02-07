namespace ModelBuilder
{
    public interface IConnectionString
    {
        string Password { get; set; }
        string Uri { get; set; }
        string Username { get; set; }
    }
}