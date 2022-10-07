using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTrainingTracker.Models
{
    public class EmployeeDetails
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentStartDate { get; set; }
        public DateTime EnrollmentEndDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public string CourseStatus { get; set; }

    }
}
