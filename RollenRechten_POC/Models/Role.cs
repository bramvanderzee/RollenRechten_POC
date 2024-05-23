namespace RollenRechten_POC.Models
{
    public class Role(int ID, string Name, IList<RightsGroup> RightsGroups)
    {
        public int ID { get; set; } = ID;
        public string Name { get; set; } = Name;
        public IList<RightsGroup> RightsGroups { get; set; } = RightsGroups;
    }
}
