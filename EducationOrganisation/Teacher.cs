using System;

namespace EducationOrganisation
{
    class Teacher
    {
        public string _uId;
        public string _name;
        public int _age;
        public string _spec;
        public static int _studentsNum = 3;
        public Student[] _students = new Student[_studentsNum];

        public void GetProfile(Teacher teacher)
        {
            Console.WriteLine($"{teacher._name}'s profile \n\nuId: {teacher._uId} \nName: {teacher._name} \nAge: {teacher._age} \nSpecialisation: {teacher._spec}");
        }

        public void Speak(string text)
        {
            Console.WriteLine(text);
        }

        public Teacher(string uId, string name, int age, string spec, int studentsNum)
        {
            _uId = uId;
            _name = name;
            _age = age;
            _spec = spec;
            _studentsNum = studentsNum;
        }
    }
}
