using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class AssignedCourseData
    {
        public int CourseID { set; get; }
        public string Title { set; get; }
        public bool Assigned { get; set; }
    }
}