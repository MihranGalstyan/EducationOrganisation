using System;

namespace EducationOrganisation
{
    class UniversityManager
    {
        public static void Main(string[] args)
        {
            Student aram = new Student("q1w2e3", "Aram", 20, "Sport", 3);
            Student vahan = new Student("r4w2y6", "Vahan", 17, "IT", 1);
            Student vazgen = new Student("u7i8o9", "Vazgen", 21, "Cars", 4);
            Student hayk = new Student("w3e4r5", "Aram", 20, "Sport", 3);
            Student haykaram = new Student("w1t1u8", "Haykaram", 17, "Sport", 1);

            Teacher anna = new Teacher("o0e3i9", "Anna", 35, "Philosophy", 4);
            Teacher garegin = new Teacher("w1t1o6", "Garegin", 31, "Programming", 3);

            anna._students[0] = aram;
            anna._students[1] = vahan;
            garegin._students[0] = vazgen;
            garegin._students[1] = hayk;
            garegin._students[2] = haykaram;

            aram._teacher = anna;
            vahan._teacher = anna;
            vazgen._teacher = garegin;
            hayk._teacher = garegin;
            haykaram._teacher = garegin;

            TeacherManager teachManager = new TeacherManager();
            Teacher[] teachersList = new Teacher[2];
            teachersList[0] = anna;
            teachersList[1] = garegin;
            Console.WriteLine();
            teachManager.Print(teachersList);
            Console.WriteLine();

            StudentManager stManager = new StudentManager();
            Student[] studentsList = new Student[5];
            studentsList[0] = aram;
            studentsList[1] = vahan;
            studentsList[2] = vazgen;
            studentsList[3] = hayk;
            studentsList[4] = haykaram;
            Console.WriteLine();
            stManager.Print(studentsList);
            Console.WriteLine();


            aram.GetProfile(aram);
            Console.WriteLine();
            anna.GetProfile(garegin);
            Console.WriteLine();

            Console.WriteLine($"The oldest student is {stManager.GetOldest(studentsList)._name}, {stManager.GetOldest(studentsList)._name}'s age is {stManager.GetOldest(studentsList)._age}");
            Console.WriteLine();
            Console.WriteLine($"{garegin._name}'s studen is: {stManager.GetByTeacher(studentsList, garegin)._name}");
            Console.WriteLine();

            anna.Speak("Anna says: Hi all!!!");
            Console.WriteLine();
            garegin.Speak("Garegin says: Please mute!!!");



        }
    }
}
