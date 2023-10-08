using EF_Test;
using Microsoft.EntityFrameworkCore;

using (Context context = new())
{
    Student student1 = new Student
    {
        Name = "User_01"
    };

    Student student2 = new Student
    {
        Name = "User_02"
    };

    Student student3 = new Student
    {
        Name = "User_03"
    };

    context.Students.AddRange
        (student1, student2, student3);


    Corse course1 = new Corse
    {
        Name = "Corse_1"
    };

    Corse course2 = new Corse
    {
        Name = "Corse_2"
    };

    Corse course3 = new Corse
    {
        Name = "Corse_3"
    };

    context.Corses.AddRange
        (course1, course2, course3);

    context.SaveChanges();


    student2.StudentCorse.Add
    (
        new StudentCorse
        {
            CorseId = course1.Id,
            StudentId = student2.Id
        }
    );

    student3.StudentCorse.Add
    (
       new StudentCorse
       {
           CorseId = course2.Id,
           StudentId = student3.Id
       }
   );

    student1.StudentCorse.Add
    (
      new StudentCorse
      {
          CorseId = course3.Id,
          StudentId = student1.Id
      }
  );
    context.SaveChanges();

    var courses = context.Corses
        .Include(x => x.StudentCorse)
        .ThenInclude(y => y.Student)
        .ToList();

    foreach (var item in courses)
    {
        Console.WriteLine(item.Name);

        var students = item.StudentCorse
            .Select(x => x.Student)
            .ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student.Name);
        }
    }

}