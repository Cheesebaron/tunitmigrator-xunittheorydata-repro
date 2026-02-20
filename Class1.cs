using Xunit;

namespace tunitmigrator_xunittheorydata_repro;

public class ExampleTests
{
    [Theory]
    [MemberData(nameof(MyData))]
    public void MyTest(
        string a, int b)
    {
        Assert.NotNull(a);
        Assert.NotEqual(0, b);   
    }

    public static TheoryData<string, int> MyData
    {
        get
        {
            var data = new TheoryData<string, int>
            {
                {
                    "a",
                    1
                },
            };

            return data;
        }
    }
}
