using System.Collections.Generic;
using DataStructures.Tests.TestHelpers;
using Xunit;

namespace DataStructures.Tests.GeneralTests;

public class EnumerableTests
{
    private readonly IEnumerable<int> _enumerable;

    protected EnumerableTests(IEnumerable<int> enumerable)
    {
        _enumerable = enumerable;
    }
    
    [Fact]
    public void GetEnumerator_ReturnsEnumerator()
    {
        var enumerator = _enumerable.GetEnumerator();
        
        Assert.NotNull(enumerator);
    }
}
