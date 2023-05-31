using Day4Demo.Models;
using Day4Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4Demo.BusinessLogic
{
    public class ConvertionToVM
    {
        public static List<CourseVM> ConvertToCourseVM(List<Course> Courses)
        {
            List<CourseVM> courseVMs = new List<CourseVM>();
            ApplicationContext context = new ApplicationContext();
            foreach (var item in Courses)
            {
                CourseVM courseVM = new CourseVM();
                courseVM.Crs_Id = item.Crs_Id;
                courseVM.Crs_Name = item.Crs_Name;
                courseVM.Crs_Duration = item.Crs_Duration;

                if(item.Ins_Id != null)
                    courseVM.Inst_Name = context.Instructors.Find(item.Ins_Id).Ins_Name;

                if (item.Top_Id != null)
                    courseVM.Topic_Name = context.Topics.Find(item.Top_Id).Top_Name;

                courseVMs.Add(courseVM);
            }

            return courseVMs;
        }
    }
}