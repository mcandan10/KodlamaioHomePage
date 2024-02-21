using KodlamaioHomePage.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Entity.Concrete
{ 
    public class Course:IEntity
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int InstructorId { get; set; }
        public int Price { get; set; }
        public string CourseImage { get; set; }
    }
}
