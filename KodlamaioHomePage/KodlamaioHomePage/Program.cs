using KodlamaioHomePage.Business.Abstract;
using KodlamaioHomePage.Business.Concrete;
using KodlamaioHomePage.Data_Access_Layer.Concrete;
using KodlamaioHomePage.DataAccessLayer.Concrete;
using KodlamaioHomePage.Entity.Abstract;
using KodlamaioHomePage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kodlama.io Home Page";

            CourseManager courseManager = new CourseManager(new CourseDal());
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());

            while (true)
            {
                Console.WriteLine("Yapacağınız işlemi seçiniz..\n1-Kurs Listele\n2-Kurs Ekle\n3-Kurs Sil\n4-Kurs Güncelle\n5-Kategori Listele\n6-Kategori Ekle\n7-Kategori Sil\n8-Kategori Güncelle\n9-Eğitmen Listele\n10-Eğitmen Ekle\n11-Eğitmen Sil\n12-Eğitmen Güncelle\n13-Çıkış");
                int selectedProcess = Convert.ToInt16(Console.ReadLine());
                switch (selectedProcess)
                {
                    case 1:
                        {
                            printData(courseManager);
                        }; break;
                    case 2:
                        {
                            Console.WriteLine("Örnek kurs ekleme : 1,C#,.NET 8vs.,1,100,C#.jpg\nÖnemli : Veriler arasına virgül koyunuz..");
                            addData(courseManager);
                        }; break;
                    case 3:
                        {
                            Console.WriteLine("Örnek kurs silme : 2");
                            deleteData(courseManager);
                        }; break;
                    case 4:
                        {
                            Console.WriteLine("Örnek kurs güncelleme : 1(güncelleme yapılacak id değeri),C#,.NET8 vs,1,100,C#.jpg\nÖnemli : Veriler arasına virgül koyunuz..");
                            updateData(courseManager);
                        }; break;
                    case 5:
                        {
                            printData(categoryManager);
                        }; break;
                    case 6:
                        {
                            Console.WriteLine("Örnek kategori ekleme : 1,Web Programlama\nÖnemli : Veriler arasına virgül koyunuz..");
                            addData(categoryManager);
                        }; break;
                    case 7:
                        {
                            Console.WriteLine("Örnek kategori silme : 2");
                            deleteData(categoryManager);
                        }; break;
                    case 8:
                        {
                            Console.WriteLine("Örnek kategori güncelleme : 1(güncelleme yapılacak id değeri),Web Programlama\nÖnemli : Veriler arasına virgül koyunuz..");
                            updateData(categoryManager);
                        }; break;
                    case 9:
                        {
                            printData(instructorManager);
                        }; break;
                    case 10:
                        {
                            Console.WriteLine("Örnek eğitmen ekleme : 1,Engin,DEMİROĞ\nÖnemli : Veriler arasına virgül koyunuz..");
                            addData(instructorManager);
                        }; break;
                    case 11:
                        {
                            Console.WriteLine("Örnek eğitmen silme : 2");
                            deleteData(instructorManager);
                        }; break;
                    case 12:
                        {
                            Console.WriteLine("Örnek eğitmen güncelleme : 1(güncelleme yapılacak id değeri),Engin,DEMİROĞ\nÖnemli : Veriler arasına virgül koyunuz..");
                            updateData(instructorManager);
                        }; break;
                    case 13:
                        {
                            Environment.Exit(0);
                        }; break;
                }
            }

            void printData(IEntityService service)
            {
                Console.Clear();
                List<IEntity> entities = service.GetList();
                if (service is CourseManager)
                {
                    foreach (Course course in entities)
                    {
                        Console.WriteLine("Id: " + course.Id + " Ad: " + course.CourseName + " Açıklama: " + course.CourseDescription + " Eğitmen Id: " + course.InstructorId + " Ücret: " + course.Price + " Resim: " + course.CourseImage);
                    }
                }
                if(service is CategoryManager) 
                {
                    foreach (Category category in entities)
                    {
                        Console.WriteLine("Id: " + category.Id + " Ad: " + category.CategoryName);
                    }
                }
                if (service is InstructorManager)
                {
                    foreach (Instructor instructor in entities)
                    {
                        Console.WriteLine("Id: " + instructor.Id + " Ad: " + instructor.FirstName + " Soyad: " + instructor.LastName);
                    }
                }
            }
            void addData(IEntityService service)
            {
                string addEntitie = Console.ReadLine();
                Console.Clear();
                string[] addEntitieSplit = addEntitie.Split(',');
                if(service is CourseManager)
                {
                    service.Add(new Course { Id = int.Parse(addEntitieSplit[0]), CourseName = addEntitieSplit[1], CourseDescription = addEntitieSplit[2], InstructorId = int.Parse(addEntitieSplit[3]), Price = int.Parse(addEntitieSplit[4]), CourseImage = addEntitieSplit[5] });
                }
                if(service is CategoryManager)
                {
                    service.Add(new Category { Id = int.Parse(addEntitieSplit[0]), CategoryName = addEntitieSplit[1] });
                }
                if(service is InstructorManager)
                {
                    service.Add(new Instructor { Id = int.Parse(addEntitieSplit[0]), FirstName = addEntitieSplit[1], LastName = addEntitieSplit[2] });
                }
                printData(service);
            }
            void deleteData(IEntityService service)
            {
                int deleteEntitieIndex = Convert.ToInt16(Console.ReadLine());
                if(service is CourseManager)
                {
                    service.Delete(deleteEntitieIndex);
                }
                if(service is CategoryManager)
                {
                    service.Delete(deleteEntitieIndex);
                }
                if(service is InstructorManager)
                {
                    service.Delete(deleteEntitieIndex);
                }
                Console.Clear();
                printData(service);
            }
            void updateData(IEntityService service)
            {
                string updateEntitie = Console.ReadLine();
                Console.Clear();
                string[] updateEntitieSplit = updateEntitie.Split(',');
                if(service is CourseManager)
                {
                    service.Update((int.Parse(updateEntitieSplit[0])), new Course { Id = int.Parse(updateEntitieSplit[0]), CourseName = updateEntitieSplit[1], CourseDescription = updateEntitieSplit[2], InstructorId = int.Parse(updateEntitieSplit[3]), Price = int.Parse(updateEntitieSplit[4]), CourseImage = updateEntitieSplit[5] });
                }
                if(service is CategoryManager)
                {
                    service.Update((int.Parse(updateEntitieSplit[0])), new Category { Id = int.Parse(updateEntitieSplit[0]), CategoryName = updateEntitieSplit[1] });
                }
                if (service is InstructorManager)
                {
                    service.Update((int.Parse(updateEntitieSplit[0])), new Instructor { Id = int.Parse(updateEntitieSplit[0]), FirstName = updateEntitieSplit[1], LastName = updateEntitieSplit[2] });
                }
                printData(service);
            }
        }
    }
}
