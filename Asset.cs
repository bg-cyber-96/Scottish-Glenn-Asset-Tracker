using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scottish_Glen_Asset_Tracking
{
    internal class Asset
    {
        public int AssetID { get; set; }
        public string SystemName { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string AssetType { get; set; }
        public string IPAddress { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Notes { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
