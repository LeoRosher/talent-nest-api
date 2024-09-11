public class Client 
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public List<Project> Projects { get; set; }
    public List<string> SocialNetworks { get; set; }

    public Client(Guid id, string fullname, string email)
    {
        Id = id;
        FullName = fullname;
        Email = email;
    }
}