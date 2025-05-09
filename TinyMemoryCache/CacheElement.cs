namespace TinyMemoryCache;

public class CacheElement<TKey,TValue>(TKey key,TValue value)
where TKey:IEquatable<TKey>
{
	public TKey Key { get; }= key;
	public TValue Value { get; }= value;
	public ulong RefCount { private set; get; } = 0;
}