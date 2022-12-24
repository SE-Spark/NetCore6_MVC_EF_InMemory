using sms_web.Models;

namespace sms_web.Repository.Interface
{
    public interface IStudent
    {
        List<Student> GetStudents();

        Student GetStudent(int id);

        Student EditStudent(int id, Student student);

        Student createStudent(Student student);

        void DeleteStudent(int id);

    }
}
