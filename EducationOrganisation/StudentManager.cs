using System;

namespace EducationOrganisation
{
    class StudentManager
    {
        /// <summary>
        /// Adds given object to the array
        /// </summary>
        /// <param name="studentsList">Given array</param>
        /// <param name="Student">Given object</param>
        /// <returns>Object array</returns>
        public Student[] AddStudent(Student[] studentsList, Student student)
        {

            Student[] NewStudentsList = new Student[studentsList.Length + 1];
            for (int i = 0; i < studentsList.Length; i++)
            {
                NewStudentsList[i] = studentsList[i];
            }
            NewStudentsList[studentsList.Length] = student;
            return NewStudentsList;
        }

        /// <summary>
        /// Gets an object by parameter "name"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <param name="name">Given parameter</param>
        /// <returns>Object</returns>
        public Student GetByName(Student[] students, string name)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._name == name)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Gets an object by parameter "age"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <param name="age">Given parameter</param>
        /// <returns>Object</returns>
        public Student GetByAge(Student[] students, int age)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._age == age)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Gets an object by parameter "interest"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <param name="interest">Given parameter</param>
        /// <returns>Object</returns>
        public Student GetByInterest(Student[] students, string interest)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._interest == interest)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Gets object by parameter "course"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <param name="course">Given parameter</param>
        /// <returns>Object</returns>
        public Student GetByCourse(Student[] students, int course)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._course == course)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Gets object by parameter "teacher"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <param name="Teacher">Given parameter</param>
        /// <returns>Object</returns>
        public Student GetByTeacher(Student[] students, Teacher teacher)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._teacher == teacher)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Finds highest value of parameter "age"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <returns>Object</returns>
        public Student GetOldest(Student[] students)
        {
            int age = students[0]._age;
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i]._age > age)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Finds lowest value of parameter "age"
        /// </summary>
        /// <param name="students">Given array</param>
        /// <returns>Object</returns>
        public Student GetYoungest(Student[] students)
        {
            int age = students[0]._age;
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i]._age < age)
                    return students[i];
            }
            return null;
        }

        /// <summary>
        /// Prints given array
        /// </summary>
        /// <param name="studentsList"></param>
        public void Print(Student[] studentsList)
        {
            for (int i = 0; i < studentsList.Length; i++)
                Console.WriteLine($"{ studentsList[i]._name}");
        }
    }
}
