using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeafletExamples.Web.Models
{
    public class EgyptStanfordGeojson
    {
        public string type { get; set; }
        public int totalFeatures { get; set; }
        public Feature[] features { get; set; }
        public Crs crs { get; set; }
        public float[] bbox { get; set; }
    }

    public class Crs
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public string name { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public string geometry_name { get; set; }
        public Properties1 properties { get; set; }
        public string id { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public float[][][][] coordinates { get; set; }
    }

    public class Properties1
    {
        public int id { get; set; }
        public string lbl { get; set; }
        public string fip { get; set; }
        public string mmt_id { get; set; }
        public string short__frm { get; set; }
        public string long_frm { get; set; }
        public string adm0 { get; set; }
        public string adm1 { get; set; }
        public string adm2 { get; set; }
        public string adm3 { get; set; }
        public string adm4 { get; set; }
        public string adm5 { get; set; }
        public int stl0 { get; set; }
        public int stl1 { get; set; }
        public int stl2 { get; set; }
        public string stl3 { get; set; }
        public string stl4 { get; set; }
        public string stl5 { get; set; }
        public float[] bbox { get; set; }
    }
}




