using System.Collections.Generic;

namespace Bus_API
{
    public class BusDepartureResponse
    {
        //getting the stuff we need (matched names to the actual api)
        public string Name { get; set; }
        public Departures Departures { get; set; }
    }
        public class Departures
        {
            public List<DepartureInfo> All { get; set; }
        
        }
            // broken down stuff from api departure section
        public class DepartureInfo
        {
            public string Line { get; set ; }
            public string Direction { get; set;}
            public string ExpectedDepartureTime { get; set;}
        }
}