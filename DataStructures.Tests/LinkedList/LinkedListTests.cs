using System.Collections.Generic;
using Xunit;

namespace DataStructures.Tests.LinkedList;

public class LinkedListTests
{
    private readonly IList<int> _linkedList;

    public LinkedListTests()
    {
        _linkedList = new List<int>();
    }

    [Fact]
    public void NewList_ReturnsEmptyList()
    {
        Assert.Empty(_linkedList);
    }
}