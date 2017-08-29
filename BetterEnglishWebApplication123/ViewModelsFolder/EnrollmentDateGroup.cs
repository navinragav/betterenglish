using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetterEnglishWebApplication123.ViewModelsFolder
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        public int StudentCount { get; set; }
    }
}