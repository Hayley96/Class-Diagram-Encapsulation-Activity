
public class Student
{
    public string Name { get; private set; }
    public Grades Grade { get; private set; }
    private int Group { get; set; }
    private string SecretNickName { get; set; }
    public enum Grades { F, E, D, C, B, A, };
    private static readonly int[] Groups = { 1, 2, 3, 4, 5, };

    public Student(string name, string grade, int group)
    {
        Name = name;
        IsValidGrade(grade);
        IsValidGroup(group);
        SecretNickName = "MySecretNickName";
    }

    private void IsValidGrade(string _grade)
    {
        _ = _grade switch
        {
            "A" => Grade = Grades.A,
            "B" => Grade = Grades.B,
            "C" => Grade = Grades.C,
            "D" => Grade = Grades.D,
            "E" => Grade = Grades.E,
            "F" => Grade = Grades.F,
            _ => throw new ArgumentException("Grade parameter out of range")
        };
    }

    private void IsValidGroup(int _group)
    {
        if (Groups.Contains(_group))
            Group = _group;
        else
            throw new ArgumentException("Group parameter out of range");
    }

    public void Upgrade() =>
        Grade++;

    public void Downgrade() =>
        Grade--;
}

