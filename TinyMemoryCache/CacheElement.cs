namespace TinyMemoryCache;

public class CacheElement<TKey, TValue>(TKey key, TValue value)
	where TKey : IEquatable<TKey>
{
	public TKey Key { get; } = key;
	public TValue Value { set; get; } = value;
	public ulong RefCount { internal set; get; } = 0;
}