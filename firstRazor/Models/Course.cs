using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using firstRazor.BuddyClass;
using Microsoft.AspNetCore.Mvc;

namespace firstRazor.Models
{

    [ModelMetadataType(typeof(CourseBuddyClass))]
    public partial class Course
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public int? Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}