namespace SPSStudentClass;

public class SPSStudent
{
    public string Name { get; }
    public string Year { get; }
    public string Tutor { get; }

    public SPSStudent(string name, string year, string tutor)
    {
        Name = name;
        Year = year;
        Tutor = tutor;
    }

    public override string ToString()
    {
        return $"{Name} - Year: {Year} , Tutor: {Tutor}";
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}
