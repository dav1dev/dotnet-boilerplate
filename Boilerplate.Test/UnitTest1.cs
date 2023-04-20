namespace Boilerplate.Test;

public class UnitTest1
{
    private readonly Class1 _testee;

    public UnitTest1()
    {
        _testee = new Class1();
    }

    [Fact]
    public void TestHelloWorld()
    {
        _testee
            .HelloWorld()
            .Should()
            .Be("Hello World!");
    }
}