using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string DefaultInstructor = "STAFF";
        private string courseName;
        private byte numCredits;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = DefaultInstructor;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get => courseName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    courseName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                };
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numCredits;
            set
            {
                if (value < 30 && value > 0)
                {
                    numCredits = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}