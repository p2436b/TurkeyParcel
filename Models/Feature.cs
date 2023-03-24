using NetTopologySuite.Geometries;
using TurkeyParcel.Domain;

public class Feature
{
  public Guid Id { get; set; }
  public Guid ParentId { get; set; }
  public string Text { get; set; } = string.Empty;
  public FeatureType Type { get; set; } = FeatureType.Feature;
  public Geometry? Geometry { get; set; }
}