//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.School
{
    using System;

    public partial class HealthInformation : IEntity, ITrackable
    {
        public int Id { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }

        public decimal? VisionL { get; set; }

        public decimal? VisionR { get; set; }

        public int? Dental { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Teeth { get; set; }

        public virtual Student Student { get; set; }
    }
}
