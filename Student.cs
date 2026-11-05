// File: Student.cs
namespace CselllTask1
{
    public class Student
    {
        public int Id { get; set; }
        public Student? Next { get; set; }

        public Student(int id)
        {
            Id = id;
            Next = null;
        }
    }
}