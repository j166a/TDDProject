namespace TDDProject.Tests;

public class StringManipulatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReverseString_TurnStringToCharArray()
    {
        //ARRANGE
        
        string testString = "cow";
        char[] testStringToCharArray = testString.ToCharArray();

        //ACT
        char[] result = StringManipulator.ReverseString(testString);


        //ASSERT
        Assert.That(result, Is.EqualTo(testStringToCharArray));
    }
}
