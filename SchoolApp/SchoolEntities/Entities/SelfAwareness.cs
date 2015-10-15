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

namespace Domain.School {
    using System;
    using System.Collections.Generic;

    public partial class SelfAwareness : IEntity, ITrackable {
        public int Id { get; set; }
        [MaxLength]
        public string Goals { get; set; }
        [MaxLength]
        public string Strengths { get; set; }
        [MaxLength]
        public string Interests { get; set; }
        [MaxLength]
        public string Responsibilities { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Student Student { get; set; }
    }
}
