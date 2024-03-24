using FluentAssertions;

namespace BioBixCinema.Tests; 

public class UnitTest1 {

    [Fact]
    public void Test1() {
        false.Should().BeTrue();
    }
}