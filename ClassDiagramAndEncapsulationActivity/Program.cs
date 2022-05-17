Student student = Student.GetInstance("Hayley", "C", 1);

if (student != null)
{
    student.DisplayStudentName();
    student.DisplayStudentGrade();
    student.Downgrade();
    student.Upgrade();
    student.Upgrade();
}
else
{
    Console.WriteLine("Error: Please try again with valid inputs for Grade or Group");
}
