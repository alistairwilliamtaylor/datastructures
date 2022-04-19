namespace DataStructures.Stack;

public interface IStack<T> : ICollection<T>
{
    /// <summary>
    /// Returns the object at the top of the IStack&lt;T&gt; without removing it.
    /// </summary>
    /// <returns>The object at the top of the IStack&lt;T&gt;.</returns>
    /// <exception cref="InvalidOperationException">The IStack&lt;T&gt; is empty.</exception>
    public T Peek();
    
    /// <summary>
    /// Removes and returns the object at the top of the IStack&lt;T&gt;.
    /// </summary>
    /// <returns>The object removed from the top of the IStack&lt;T&gt;.</returns>
    /// <exception cref="InvalidOperationException">The IStack&lt;T&gt; is empty.</exception>
    public T Pop();
    
    /// <summary>
    /// Inserts an object at the top of the IStack&lt;T&gt;.
    /// </summary>
    /// <param name="item">The object to push onto the IStack&lt;T&gt;. The value can be null for reference types.</param>
    public void Push(T item);
    
    /// <summary>
    /// Ensures that the capacity of this stack is at least the specified capacity. If the current capacity is less than capacity, it is successively increased to twice the current capacity until it is at least the specified capacity.
    /// </summary>
    /// <param name="capacity">The minimum capacity to ensure.</param>
    /// <returns>The new capacity of this stack.</returns>
    public int EnsureCapacity(int capacity);
    
    /// <summary>
    /// Sets the capacity to the actual number of elements in the IStack&lt;T&gt;, if that number is less than 90 percent of current capacity.
    /// </summary>
    public void TrimExcess();
    
    /// <summary>
    /// Returns a value that indicates whether there is an object at the top of the IStack&lt;T&gt;, and if one is present, copies it to the result parameter. The object is not removed from the IStack&lt;T&gt;.
    /// </summary>
    /// <param name="result">If present, the object at the top of the IStack&lt;T&gt;; otherwise, the default value of T.</param>
    /// <returns><b>true</b> if there is an object at the top of the IStack&lt;T&gt;; <b>false</b>  if the IStack&lt;T&gt; is empty.</returns>
    public bool TryPeek(out T result);
    
    /// <summary>
    /// Returns a value that indicates whether there is an object at the top of the IStack&lt;T&gt;, and if one is present, copies it to the result parameter, and removes it from the IStack&lt;T&gt;.
    /// </summary>
    /// <param name="result">If present, the object at the top of the IStack&lt;T&gt;; otherwise, the default value of T.</param>
    /// <returns><b>true</b> if there is an object at the top of the IStack&lt;T&gt;; <b>false</b> if the IStack&lt;T&gt; is empty.</returns>
    public bool TryPop(out T result);
}
