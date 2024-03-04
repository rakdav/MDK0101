using Lesson11;
Student[] students = new Student[5];
students[0] = new Student
{
    FirstName = "Маша",
    LastName = "Кручинина",
    BirthDay = new DateTime(2007, 1, 13)
};
students[1] = new Student
{
    FirstName = "Вася",
    LastName = "Дудка",
    BirthDay = new DateTime(1880, 4, 12)
};
students[2] = new Student
{
    FirstName = "Руслан",
    LastName = "Кальмаров",
    BirthDay = new DateTime(1242, 11, 23)
};
students[3] = new Student
{
    FirstName = "Егор",
    LastName = "Недобитов",
    BirthDay = new DateTime(1945, 1, 1)
};
students[4] = new Student
{
    FirstName = "Петр",
    LastName = "Прибрежный",
    BirthDay = new DateTime(902, 8, 16)
};
Teacher teacher = new Teacher();
foreach(Student i in students)
{
    teacher.examEvent += i.Exam;
}
teacher.Exam("Физика");
public delegate void ExamDelegate ( string st );

