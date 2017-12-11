using System.ComponentModel.DataAnnotations.Schema;
using Interview.Entities.Interfaces;

namespace Interview.Entities
{
  public class AssetFields : IEntityBase
  {
    public AssetFields()
    {
      
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string Name { get; set; }
    public string StringVal { get; set; }
    public int? IntVal { get; set; }
    public bool? BoolVal { get; set; }
    public float? FloatVal { get; set; }
    public double? DblVal { get; set; }

  }
}