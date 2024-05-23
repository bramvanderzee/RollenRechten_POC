using Microsoft.EntityFrameworkCore;
using RollenRechten_POC.EFConfigurations;

namespace RollenRechten_POC.Models
{
    [EntityTypeConfiguration(typeof(RightConfiguration))]
    public class Right(int ID, string Name, bool Create = false, bool Read = false, bool Write = false, bool Delete = false)
    {
        public int ID { get; } = ID;
        public string Name { get; set; } = Name;
        public bool Create { get; set; } = Create;
        public bool Read { get; set; } = Read;
        public bool Write { get; set; } = Write;
        public bool Delete { get; set; } = Delete;
    }
}
