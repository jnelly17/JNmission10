using System.ComponentModel.DataAnnotations;

namespace APImish10.Data
{
    public class Teams
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }
}
