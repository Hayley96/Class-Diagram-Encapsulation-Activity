public class Student
{
    private string Name { get; set; }
    private string Grade { get; set; }
    private int Group { get; set; }
    private string secretNickName { get; set; }
    private string MySecretNickName = "HowdyDoodle";
    private static string[] validGrades = { "A", "B", "C", "D", "E", "F", };
    private static int[] validGroups = { 1, 2, 3, 4, 5, };

    private Student(string _name, string _grade, int _group)
    {
        Name = _name;
        Grade = _grade;
        Group = _group;
        secretNickName = MySecretNickName;
    }

    public static Student GetInstance(string _name, string _grade, int _group)
    {
        if (IsValidGrade(_grade) && IsValidGroup(_group))
        {
            Student student = new(_name, _grade, _group);
            return student;
        }
        else
        {
            return null;
        }
    }

    public void DisplayStudentName()
    {
        Console.WriteLine($"Student's name is {Name}");
    }

    public void DisplayStudentGrade()
    {
        Console.WriteLine($"Student's grade is {Grade}");
    }

    private static bool IsValidGrade(string grade)
    {
        return validGrades.Contains(grade);
    }

    private static bool IsValidGroup(int group)
    {
        return validGroups.Contains(group);
    }

    public void Upgrade()
    {
        char newGrade = Convert.ToChar(Grade);
        char upgradedGrade = (char)(newGrade - 1);
        Console.WriteLine($"The new grade following the upgrade is: {(char)(newGrade - 1)}");
        Grade = upgradedGrade.ToString();
    }

    public void Downgrade()
    {
        char newGrade = Convert.ToChar(Grade);
        char upgradedGrade = (char)(newGrade + 1);
        Console.WriteLine($"The new grade following the downgrade is: {(char)(newGrade + 1)}");
        Grade = upgradedGrade.ToString();
    }
}

