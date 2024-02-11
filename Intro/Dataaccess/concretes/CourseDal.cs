using Intro.Dataaccess.abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Dataaccess.concretes
{
	public class CourseDal : ICourseDal
	{
		List<Course> courses;
        public CourseDal()
        {
			Course course1 = new Course();
			course1.Id = 1;
			course1.Name = "C#";
			course1.Description = ".NET8";
			course1.Price = 10;

			Course course2 = new Course();
			course2.Id = 2;
			course2.Name = "Java17";
			course2.Description = "17...";
			course2.Price = 10;

			Course course3 = new Course();
			course3.Id = 3;
			course3.Name = "Python";
			course3.Description = "Phyton3.12....";
			course3.Price = 10;

			courses = new List<Course> { course1, course2, course3 };
		}
        public List<Course> GetAll()
		{
			//sql öğren 
			//burada db işlmeleri yapılır 
			return courses;
		}
		public void Add(Course course)
		{
			courses.Add(course);
		}
	}
}
