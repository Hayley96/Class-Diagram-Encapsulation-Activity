Student student = new("Hayley", "C", 2);
Console.WriteLine(student.Name);
Console.WriteLine(student.Grade);
student.Upgrade();
Console.WriteLine(student.Grade);
student.Downgrade();
Console.WriteLine(student.Grade);