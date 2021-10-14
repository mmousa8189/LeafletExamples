
public class GeojsonTypeRootobject
{
    public string type { get; set; }
    public Feature[] features { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Geometry geometry { get; set; }
    public Properties properties { get; set; }
    public int id { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public float[][][] coordinates { get; set; }
}

public class Properties
{
    public int id { get; set; }
    public string nazwa { get; set; }
}
