using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace NetworkGenerator
{
    public class Geometry
    {
        [ScriptIgnore]
        public GeometryType GeoType { get; set; }
        public string Type { get { return GeoType.ToString(); } }
        public IList<Coordinate> Coordinates { get; set; }
    }

    public enum GeometryType
    {
        Point,
        Polyline,
        Polygon
    }

    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
