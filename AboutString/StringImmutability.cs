namespace AboutString
{
    /// <summary>
    /// from pluralsight
    /// Internal state cannot be modified after initialization. Created object remains the same throughout its lifetime.
    /// After string is created, it is a read-only instance.
    /// Character buffer cannot grow which makes strings similar to array. It has fixed size after creation.
    /// Methods and operators do not change string but return a new string with modified size and characters.
    /// 
    /// Advantages
    /// * strings can be safely shared without the need to defensively copy them
    /// * easy to reason about that the state will never change midway through using it
    /// * thread-safe - allow multiple concurrent threads to share a reference to the same string without having it to consider any lockers
    /// * can be optimized by CLR
    /// 
    /// Disadvantages
    /// Immutability increases the number of objects in memory, which introduces a performance overhead
    /// </summary>
    public class StringImmutability
    {
    }
}
