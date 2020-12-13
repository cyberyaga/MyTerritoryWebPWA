using System;

namespace TerritoryWeb.Shared.Territory
{
    public class TerritoryDetails
    {
        public int Id { get; set; }
        public string TerritoryName { get; set; }
        public string TerritoryTypeStr { get; set; }
        public string City { get; set; }
        public string Notes { get; set; }
        public string AssignedPublisher { get; set; }
        public DateTime? CheckedOut { get; set; }
        public DateTime? CheckedIn { get; set; }
        public string LastCheckedInBy { get; set; }
        public int DoorCount { get; set; }
    }
}