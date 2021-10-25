using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using static CharitySpacialSearcher.WebAPI.Models.charitiesViewModel;

namespace CharitySpacialSearcher.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CharityController : ControllerBase
    {
        private readonly SpatialDbContext _spatialDbContext;

        private readonly ILogger<CharityController> _logger;

        public CharityController(ILogger<CharityController> logger, SpatialDbContext spatialDbContext)
        {
            _logger = logger;
            this._spatialDbContext = spatialDbContext;
        }

        [HttpPost]
        public IEnumerable<CharitiesViewModel> Search(IndexPageViewModel indexModel)
        {
            var indexViewModel = new IndexPageViewModel
            {
                SearchInput = indexModel.SearchInput,
                Charities = indexModel.Charities
            };

            // Convert the input latitude and longitude to a Point  
            var location = new Point(indexModel.SearchInput.Latitude, indexModel.SearchInput.Longitude) { SRID = 4326 };
            // Fetch the tourist attractions and their  
            // distances from the input location   
            // using spatial queries.  
            var charities = _spatialDbContext
                .Chartities
                .Select(t => new { Place = t, Distance = t.Location.Distance(location) })
                .ToList();

            // Ordering the result in the ascending order of distance  
            indexViewModel.Charities = charities
                .OrderBy(x => x.Distance)
                .Select(t => new CharitiesViewModel
                {
                    Distance = Math.Round(t.Distance, 6),
                    Latitude = t.Place.Location.X,
                    Longitude = t.Place.Location.Y,
                    Name = t.Place.Name,
                    Tag = t.Place.Tag
                }).ToList();

            if (indexModel.Charities[0].Name != "")
            {
                indexViewModel.Charities = indexViewModel.Charities.Where(m => m.Name.Contains(indexModel.Charities[0].Name)).ToList();
            }

            if (indexModel.Charities[0].Tag != "")
            {
                indexViewModel.Charities = indexViewModel.Charities.Where(m => m.Tag.Contains(indexModel.Charities[0].Tag)).ToList();
            }

            return indexViewModel.Charities.ToArray();
        }

    }
}
