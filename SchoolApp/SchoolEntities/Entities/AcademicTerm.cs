//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.School {
    using System;
    using System.Collections.Generic;

    public partial class AcademicTerm : IEntity, ITrackable {
        public AcademicTerm() {
            this.AssesmentSchemas = new HashSet<AssessmentSchema>();
            this.ActivityGrades = new HashSet<ActivityGrade>();
            this.ActivityResults = new HashSet<ActivityResult>();
        }

        public int Id { get; set; }
        [MaxLength]
        public string Label { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Order { get; set; }

        [ForeignKey("AcademicYear")]
        public int AcademicYear_Id { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ICollection<AssessmentSchema> AssesmentSchemas { get; set; }
        public virtual ICollection<ActivityGrade> ActivityGrades { get; set; }
        public virtual ICollection<ActivityResult> ActivityResults { get; set; }
    }
}
