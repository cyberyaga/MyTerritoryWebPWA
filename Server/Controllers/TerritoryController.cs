using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TerritoryWeb.Server.Data;
using TerritoryWeb.Shared.Territory;
using System.Linq;

namespace TerritoryWebPWA.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TerritoryController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public TerritoryController(ApplicationDbContext context)
        {
            db = context;
        }


        [HttpGet("GetTerritories")]
        public IEnumerable<TerritoryIndexView> GetTerritories()
        {
            var ter = 
                from t in db.Territories
                select new TerritoryIndexView() {
                    TerritoryId = t.Id,
                    TerritoryName = t.TerritoryName,
                    City = t.City,
                    TerritoryType = t.TerritoryType.Description,
                    DoorCount = t.Doors.Count                    
                };

            return ter;
        }

        [HttpGet("GetTerritoryDetails/{TerritoryId}")]
        public TerritoryDetails GetTerritoryDetails(int TerritoryId)
        {
            var td = 
                from t in db.Territories
                where t.Id == TerritoryId
                select new TerritoryDetails()
                {
                    Id = t.Id,
                    TerritoryName = t.TerritoryName,
                    City = t.City,
                    TerritoryTypeStr = t.TerritoryType.Description,
                    Notes = t.Notes,
                    DoorCount = t.Doors.Count,
                    //AssignedPublisher = t.
                    CheckedOut = t.CheckedOut,
                    CheckedIn = t.CheckedIn,
                    LastCheckedInBy = t.LastCheckedInBy
                };

            return td.SingleOrDefault();
        }
    }
}