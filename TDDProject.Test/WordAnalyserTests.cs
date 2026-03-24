namespace TDDProject.Tests;

public class WordAnalyserTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FindLongestWord_ReturnLongestWord()
    {
        //ARRANGE
        List<string> testList = new List<string>();
        string testString = "This is a an exercise in the Northcoders bootcamp.";


        //ACT
        List<string> result = WordAnalyser.FindLongestWords(testString);


        //ASSERT
        Assert.That(result[0], Is.EqualTo("Northcoders"));
    }
    [Test]
    public void FindLongestWord_ReturnLongestWords_WhenMoreThanOneOfSameLength()
    {
        //ARRANGE
        string testString = "This is a fairly boring thing.";


        //ACT
        List<string> result = WordAnalyser.FindLongestWords(testString);


        //ASSERT
        Assert.Multiple(() =>
        {
            Assert.That(result, Does.Contain("fairly"));
            Assert.That(result, Does.Contain("boring"));

        });
    }

}
