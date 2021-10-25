using CharitySpacialSearcher.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace CharitySpacialSearcher.WebAPI
{
    public class SpatialDbContext : DbContext
    {
        public DbSet<chartities> Chartities { get; set; }

        public SpatialDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            modelBuilder.Entity<chartities>()
                .HasData(
                    new chartities
                    {
                        Id = 1,
                        Name = "Besat",
                        Tag = "test",
                        Location = geometryFactory.CreatePoint(new Coordinate(27.175015, 78.042155))
                    },
                    new chartities
                    {
                        Id = 2,
                        Name = "Shazde",
                        Tag = "test",
                        Location = geometryFactory.CreatePoint(new Coordinate(31.619980, 74.876485))
                    },
                    new chartities
                    {
                        Id = 3,
                        Name = "Darvaze",
                        Tag = "test",
                        Location = geometryFactory.CreatePoint(new Coordinate(28.656159, 77.241020))
                    },
                    new chartities
                    {
                        Id = 4,
                        Name = "Podonak",
                        Tag = "test",
                        Location = geometryFactory.CreatePoint(new Coordinate(18.921984, 72.834654))
                    },
                    new chartities
                    {
                        Id = 5,
                        Name = "Chamran",
                        Tag = "test",
                        Location = geometryFactory.CreatePoint(new Coordinate(12.305025, 76.655753))
                    },
                    new chartities
                    {
                        Id = 6,
                        Name = "Alzahra",
                        Tag = "test",
                        Location = geometryFactory.CreatePoint(new Coordinate(28.524475, 77.185521))
                    }
                );
        }
    }

}
