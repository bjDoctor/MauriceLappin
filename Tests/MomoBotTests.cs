namespace Tests;

public class MomoBotTests
{
    [Fact]
    public void CanSayHello()
    {
        // Arrange
        var bot = new MomoBot("Amouzy");

        // Act
        var result = bot.SayHello();

        // Assert
        Assert.Equal("Hello, my name is Amouzy", result);
    }

    [Fact]
    public void CanChangeName()
    {
        // Arrange
        var bot = new MomoBot("Amouzy");

        // Act
        bot.ChangeName("Nash");
        var result = bot.SayHello();

        // Assert
        Assert.Equal("Hello, my name is Nash", result);
    }
}
