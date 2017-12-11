using System;

namespace Interview.Entities.Interfaces
{
  public interface IEntitySystemAttrs
  {
    DateTime DateCreatedUTC { get; set; }
    Guid CreatedBy { get; set; }
    DateTime DateModifiedUTC { get; set; }
    Guid ModifiedBy { get; set; }
    bool IsDeleted { get; set; }

  }
}