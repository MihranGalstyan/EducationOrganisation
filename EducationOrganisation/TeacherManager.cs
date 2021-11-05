using System;

namespace EducationOrganisation
{
    class TeacherManager
    {
        /// <summary>
        /// Adds given object to the array
        /// </summary>
        /// <param name="teachersList">Given array</param>
        /// <param name="Teacher">Given object</param>
        /// <returns>Object array</returns>
        public Teacher[] AddTeacher(Teacher[] teachersList, Teacher teacher)
        {

            Teacher[] NewteachersList = new Teacher[teachersList.Length + 1];
            for (int i = 0; i < teachersList.Length; i++)
            {
                NewteachersList[i] = teachersList[i];
            }
            NewteachersList[teachersList.Length] = teacher;
            return NewteachersList;
        }

        /// <summary>
        /// Gets object by parameter "name"
        /// </summary>
        /// <param name="teachers">Given array</param>
        /// <param name="name">Given parameter</param>
        /// <returns>Object</returns>
        public Teacher GetByName(Teacher[] teachers, string name)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i]._name == name)
                    return teachers[i];
            }
            return null;
        }

        /// <summary>
        /// Gets object by parameter "age"
        /// </summary>
        /// <param name="teachers">Given array</param>
        /// <param name="age">Given parameter</param>
        /// <returns>Object</returns>
        public Teacher GetByAge(Teacher[] teachers, int age)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i]._age == age)
                    return teachers[i];
            }
            return null;
        }

        /// <summary>
        /// Gets an object by parameter "interest"
        /// </summary>
        /// <param name="teachers">Given array</param>
        /// <param name="interest">Given parameter</param>
        /// <returns>Object</returns>
        public Teacher GetByInterest(Teacher[] teachers, string spec)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i]._spec == spec)
                    return teachers[i];
            }
            return null;
        }

        /// <summary>
        /// Finds highest value of parameter "age"
        /// </summary>
        /// <param name="teachers">Given array</param>
        /// <returns>Object</returns>
        public Teacher GetOldest(Teacher[] teachers)
        {
            int age = teachers[0]._age;
            for (int i = 1; i < teachers.Length; i++)
            {
                if (teachers[i]._age > age)
                    return teachers[i];
            }
            return null;
        }

        /// <summary>
        /// Finds lowest value of parameter "age"
        /// </summary>
        /// <param name="teachers">Given array</param>
        /// <returns>Object</returns>
        public Teacher GetYoungest(Teacher[] teachers)
        {
            int age = teachers[0]._age;
            for (int i = 1; i < teachers.Length; i++)
            {
                if (teachers[i]._age < age)
                    return teachers[i];
            }
            return null;
        }

        /// <summary>
        /// Prints given array
        /// </summary>
        /// <param name="teachersList"></param>
        public void Print(Teacher[] teachersList)
        {
            for (int i = 0; i < teachersList.Length; i++)
                Console.WriteLine($"{ teachersList[i]._name}");
        }
    }
}
