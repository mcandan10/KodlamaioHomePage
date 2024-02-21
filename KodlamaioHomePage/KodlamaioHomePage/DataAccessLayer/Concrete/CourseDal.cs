using KodlamaioHomePage.Data_Access_Layer.Abstract;
using KodlamaioHomePage.Entity.Abstract;
using KodlamaioHomePage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Data_Access_Layer.Concrete
{
    public class CourseDal : IData
    {
        List<IEntity> courses;
        public CourseDal()
        {
            courses = new List<IEntity>() {
                new Course
                {
                    Id = 1,
                    CourseName = "Senior Yazılım Geliştirici Kampı",
                    CourseDescription = ".NET",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = ".NET.jpg"
                },
                new Course {
                    Id = 2,
                    CourseName = "Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "C#+ANGULAR",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = "C#+ANGULAR.jpg"
                },
                new Course {
                    Id = 3,
                    CourseName = "(2023)Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "Python & Selenium",
                    InstructorId = 2,
                    Price = 0,
                    CourseImage = "Python&Selenium.jpg"
                },
                new Course {
                    Id = 4,
                    CourseName = "(2022)Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "JAVA",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = "JAVA.jpg"
                },
                new Course {
                    Id = 5,
                    CourseName = "Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "Javascript",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = "Javascript.jpg"
                },
                new Course {
                    Id = 6,
                    CourseName = "Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "JAVA+REACT",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = "JAVA+REACT.jpg"
                },
                new Course {
                    Id = 7,
                    CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "C#",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = "C#.jpg"
                },
                new Course {
                    Id = 8,
                    CourseName = "Programlamaya Giriş İçin Temel Kurs",
                    CourseDescription = "Base Course",
                    InstructorId = 1,
                    Price = 0,
                    CourseImage = "BaseCourse.jpg"
                }
            };
        }

        public void Add(IEntity course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
            IEntity deletedCourse = courses.Where(c => c.Id == id).First();
            courses.Remove(deletedCourse);
        }

        public List<IEntity> GetList()
        {
            return courses;
        }

        public void Update(int id, IEntity entity)
        {
            foreach (Course course in courses)
            {
                if(course.Id == id)
                {
                    courses.RemoveAt(course.Id-1);
                    courses.Add(entity);
                    break;
                }
            }
        }
    }
}
