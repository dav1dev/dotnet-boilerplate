namespace Boilerplate.Specification
{
    public class UnitTest1
    {
        [Scenario]
        public void Test1(
            Class1 testee,
            string result)
        {
            "given class1".x(() =>
                testee = new Class1());

            "when call hello world".x(() =>
                result = testee.HelloWorld());

            "should return hello world".x(() =>
                result.Should().Be("Hello World!"));
        }
    }
}