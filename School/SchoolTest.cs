using System;
using System.Collections.Generic;

namespace School
{
    class SchoolTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = new List<Student>
            {
                new Student("Георги Пешев", 1),
                new Student("Димитър Иванов", 2),
                new Student("Иван Цветанов", 5),
                new Student("Гергана Зафирова", 3),
                new Student("Стела Маринова", 4)
            };

            IList<Discipline> someDisciplines = new List<Discipline>();
            IList<Student> someStudents = new List<Student>();
            IList<Student> studentsInClass = new List<Student>();

            var html = new Discipline("HTML", 6, someStudents);
            html.AddStudent(students[0]);
            html.AddStudent(students[2]);
            html.AddStudent(students[4]);
            html.Details = "Вечерни курсове";

            var css = new Discipline("CSS", 5, someStudents);
            css.AddStudent(students[0]);
            css.AddStudent(students[1]);
            css.AddStudent(students[2]);

            var java = new Discipline("Java", 4, someStudents);
            java.AddStudent(students[1]);
            java.AddStudent(students[3]);
            java.AddStudent(students[4]);

            var javaScript = new Discipline("JavaScript", 5, someStudents);

            var webDevelopmentTeacher = new Teacher("Владимир Георгиев", someDisciplines);
            webDevelopmentTeacher.AddDiscipline(html);
            webDevelopmentTeacher.AddDiscipline(css);
            webDevelopmentTeacher.AddDiscipline(javaScript);

            var JavaDevelopmentTeacher = new Teacher("Тодор Куртев", someDisciplines);
            JavaDevelopmentTeacher.AddDiscipline(java);

            var classA = new Class("A", new List<Teacher> { webDevelopmentTeacher, JavaDevelopmentTeacher }, studentsInClass);
            classA.AddStudentsInClass(students[0]);
            classA.AddStudentsInClass(students[1]);
            classA.AddStudentsInClass(students[2]);
            classA.AddStudentsInClass(students[3]);
            classA.AddStudentsInClass(students[4]);

            string str = classA.ToString();
            Console.WriteLine(classA);
        }
    }
}
