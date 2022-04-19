using DataStructures.Queue;
using DataStructures.Tests.GeneralTests;
using DataStructures.Tests.TestHelpers;
using Xunit;

namespace DataStructures.Tests.Queue;

public class QueueTests : CollectionTests
{
    private readonly IQueue<int> _queue;

    // Change which implementation is tested by changing the instance passed into this()
    public QueueTests() : this(new Queue<int>()) { }

    #region Private Constructor

    private QueueTests(IQueue<int> queue) : base(queue)
    {
        _queue = queue;
    }

    #endregion
    
    #region Initialisation

    [Fact]
    public void NewList_ReturnsEmptyList()
    {
        Assert.Empty(_queue);
    }

    #endregion
    
    #region Enumeration

    [Fact]
    public void Enumeration_ReturnsElementsInAddedOrder()
    {
        AddElements(3);
        
        Assert.Collection(_queue,
            element => Assert.Equal(IntGenerator.First, element),
            element => Assert.Equal(IntGenerator.Second, element),
            element => Assert.Equal(IntGenerator.Third, element)
        );
    }

    #endregion

    #region Enqueue

    

    #endregion

    #region Dequeue

    

    #endregion

    #region Peek

    

    #endregion

    #region TryDequeue

    

    #endregion

    #region TryPeek

    

    #endregion
}