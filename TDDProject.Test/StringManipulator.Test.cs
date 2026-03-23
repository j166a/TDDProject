namespace TDDProject.Tests;

public class StringManipulatorTests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void ReverseString_CheckIfStringReversed()
    {
        //ARRANGE

        string testString = "cow";

        //ACT
        string result = StringManipulator.ReverseString(testString);


        //ASSERT
        Assert.That(result, Is.EqualTo("woc"));
    }
    [Test]
    public void IsPalindrome_CheckBooleanOutput()
    {
        //ARRANGE

        string testString1 = "cow";
        string testString2 = "pop";
        string testStringReversed1 = StringManipulator.ReverseString(testString1);
        string testStringReversed2 = StringManipulator.ReverseString(testString2);

        //ACT
        bool result1 = StringManipulator.IsPalindrome(testStringReversed1);
        bool result2 = StringManipulator.IsPalindrome(testStringReversed2);

        //ASSERT
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(false));
            Assert.That(result2, Is.EqualTo(true));
        });
    }
}
