using TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        string testDate = "01/12/2023";
        string result = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("2023-12-01", result);
    }

    [Test]
    public void IncorrectContent()
    {
        string testDate = "abc/xyz/123";
        string result = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("Invalid date", result);
    }

    [Test]
    public void OverRange()
    {
        string testDate = "32/13/3000";
        string result = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("Invalid date", result);
    }

    [Test]
    public void WhiteSpace()
    {
        string testDate = "";
        string result = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("Invalid date", result);
    }
}
