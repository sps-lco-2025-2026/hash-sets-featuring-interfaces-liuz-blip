using SPSStudentClass;


namespace SPSStudentTest;

[TestClass]
public sealed class SPSStudentTest
{
    [TestMethod]
    public void test_ToString()
    {
        SPSStudent student = new SPSStudent("John Doe", "2024", "Ms. Smith");
        string expected = "John Doe - Year: 2024 , Tutor: Ms. Smith";
        Assert.AreEqual(expected, student.ToString());
    }

    [TestMethod]
    public void test_GetHashCode()
    {
        SPSStudent student = new SPSStudent("John Doe", "2024", "Ms. Smith");
        int expected = student.ToString().GetHashCode();
        Assert.AreEqual(expected, student.GetHashCode());
    }
}
