namespace BlogMvc.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public Tag(Guid id, string name, string displayName)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
        }
    }
}
