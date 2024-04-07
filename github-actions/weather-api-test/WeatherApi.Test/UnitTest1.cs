using FluentAssertions;

namespace WeatherApi.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        true.Should().BeFalse();
    }
}
