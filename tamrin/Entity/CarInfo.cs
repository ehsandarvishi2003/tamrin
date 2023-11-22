using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace tamrin.Entity
{
    public class CarInfo
    {
        [Key]
        public int Id { get; set; }
        public string CarName { get; set; }
        public string Color { get; set; }
        public string CarTag { get; set; }
        public int YearMade { get; set; }
    }
}
