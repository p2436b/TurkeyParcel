using NetTopologySuite.Geometries;

public class CrsProperties
{
  public string Name { get; set; } = string.Empty;
}

public class Crs
{
  public string Type { get; set; }
  public CrsProperties Properties { get; set; }
}

public class FeatureProperties
{
  public string Id { get; set; }
  public string Type { get; set; }
}

public class FFeature
{
  public string Type { get; set; }
  public Geometry Geometry { get; set; }
  public FeatureProperties Properties { get; set; }
}

public class Response
{
  public List<FFeature> Features { get; set; }
  public string Type { get; set; }
  public Crs Crs { get; set; }

}