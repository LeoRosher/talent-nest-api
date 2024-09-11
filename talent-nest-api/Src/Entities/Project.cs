public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ProjectLink { get; set; }
    public List<string> ProjectImages { get; set; }

    public Project(Guid id, string name, string description, string projectLink)
    {
        Id = id;
        Name = name;
        Description = description;
        ProjectLink = projectLink;
    }
}