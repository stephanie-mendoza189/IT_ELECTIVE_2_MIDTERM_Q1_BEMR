namespace GenshinCharacterBuild.Models
{
    public class Character
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // "DPS", "Sub-DPS", or "Support"
        public string Element { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BestWeapon { get; set; } = string.Empty;
        public string BestArtifact { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
