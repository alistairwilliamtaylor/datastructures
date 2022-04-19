using DataStructures.Stack;
using DataStructures.Tests.GeneralTests;
using DataStructures.Tests.TestHelpers;
using Xunit;

namespace DataStructures.Tests.Stack;

public class StackTests : CollectionTests
{
    private readonly IStack<int> _stack;

    // Change which implementation is tested by changing the instance passed into this()
    public StackTests() : this(new Stack<int>()) { }

    #region Private Constructor

    private StackTests(IStack<int> stack) : base(stack)
    {
        _stack = stack;
    }

    #endregion
    
    #region Initialisation

    [Fact]
    public void NewList_ReturnsEmptyList()
    {
        Assert.Empty(_stack);
    }

    #endregion
    
    #region Enumeration

    [Fact]
    public void Enumeration_ReturnsElementsInAddedOrder()
    {
        AddElements(3);
        
        Assert.Collection(_stack,
            element => Assert.Equal(IntGenerator.First, element),
            element => Assert.Equal(IntGenerator.Second, element),
            element => Assert.Equal(IntGenerator.Third, element)
        );
    }

    #endregion

    #region Push

    

    #endregion

    #region Pop

    

    #endregion

    #region Peek

    

    #endregion

    #region TryPop

    

    #endregion

    #region TryPeek

    

    #endregion
}