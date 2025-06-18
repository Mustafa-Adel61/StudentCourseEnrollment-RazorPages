using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using firstRazor.BuddyClass;
using Microsoft.AspNetCore.Mvc;

namespace firstRazor.Models
{
    [ModelMetadataType(typeof(StudentBuddyClass))]
    public partial class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public DateTime? EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}