using sms_web.Models;
using sms_web.Repository.Interface;

namespace sms_web.Repository.implementation
{
    public class StudentRepo : IStudent
    {
        public readonly AppDbContext db;
        public StudentRepo(AppDbContext db)
        {
            this.db = db;
        }
        public Student createStudent(Student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return student;
        }

        public void DeleteStudent(int id)
        {
            var std = db.students.Where(x => x.id == id).First();
            if (std != null)
            {
                db.students.Remove(std);
                db.SaveChanges();
            }
        }

        public Student EditStudent(int id, Student student)
        {
            var std = db.students.Where(x => x.id == id).First();
            if (std != null)
            {
                std.name = student.name;
                std.dob = student.dob;
                std.city = student.city;
                std.address = student.address;
                db.students.Update(std);
                db.SaveChanges();
                return std;
               
            }
            return new Student();
        }

        public Student GetStudent(int id)
        {
            var student = db.students.Where(x => x.id == id).First();

            return student;
        }

        public List<Student> GetStudents()
        {
            return db.students.ToList();
        }

        
    }
}
