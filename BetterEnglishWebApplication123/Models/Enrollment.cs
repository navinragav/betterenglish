using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BetterEnglishWebApplication123.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        [Key]
        [Required]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "EnrollmentID")]
        public string EnrollmentID { get; set; }

        public string CourseID { get; set; }
        public string StudentID { get; set; }
        public Grade Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }


    }
}