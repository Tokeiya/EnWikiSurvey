namespace TinyMemoryCache;

public interface IAdapter<TKey,TValue>:IDisposable
where TKey:IEquatable<TKey>
{
	CacheElement<TKey, TValue> Query(TKey key);
	void Write(CacheElement<TKey, TValue> value);
}