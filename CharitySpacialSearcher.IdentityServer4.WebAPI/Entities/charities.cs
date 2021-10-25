using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitySpacialSearcher.WebAPI.Entities
{
    public class chartities
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Tag { get; set; }

        [Column(TypeName = "geometry")]
        public Point Location { get; set; }
    }
}
