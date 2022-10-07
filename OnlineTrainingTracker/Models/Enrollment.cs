using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTrainingTracker.Models
{
    public class Enrollment
    {
        public enum TrainingStatus
        {
            NotStarted, Ongoing, Completed
        }

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int EmpId { get; set; }
        public TrainingStatus? CompletionStatus { get; set; }
        public Course Course { get; set; }
        public EmployeeDetails Student { get; set; }
        
    }
}

