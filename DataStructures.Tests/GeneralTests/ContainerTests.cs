using DataStructures.Shared.Interfaces;

namespace DataStructures.Tests.GeneralTests;

public class ContainerTests : CollectionTests
{
    private readonly IContainer<int> _container;

    protected ContainerTests(IContainer<int> container) : base(container)
    {
        _container = container;
    }

    #region EnsureCapacity

    

    #endregion

    #region TrimExcess

    

    #endregion
}