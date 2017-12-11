using System.ComponentModel.DataAnnotations.Schema;

namespace Interview.Entities.Interfaces
{
  public interface IEntityBase
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    int? Id { get; set; }
  }
}