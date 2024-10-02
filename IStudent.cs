using System;
using SampleSecuredWeb.Models;


namespace SampleSecuredWeb.Data;

    public interface IStudent
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(string Nim);
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        Student DeleteStudent(string Nim);

    }
