using System;

namespace EducationOrganisation
{
    class Student
    {
        public string _uId;
        public string _name;
        public int _age;
        public string _interest;
        public int _course;
        public Teacher _teacher;

        public void GetProfile(Student student)
        {
            Console.WriteLine($"{student._name}'s profile \n\nuId: {student._uId} \nName: {student._name} \nAge: {student._age} \nInterest: {student._interest} \nTeacher: {student._teacher._name} \nCourse: {student._course}");
        }

        public void Speak(string text)
        {
            Console.WriteLine(text);
        }

        public Student(string uId, string name, int age, string interest, int course)
        {
            _uId = uId;
            _name = name;
            _age = age;
            _interest = interest;
            _course = course;
        }
    }
}
