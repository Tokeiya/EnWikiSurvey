namespace TinyMemoryCache;

public class Cache<TKey, TValue> : IDisposable
	where
	TKey : IEquatable<TKey>
{
	public Cache(uint capacity, uint threshold, IAdapter<TKey, TValue> adapter)
	{
		//TODO:Implement
#warning NotImplemented
		throw new NotImplementedException();
	}

	public uint Capacity { get; } = 0;
	public uint Threshold { get; } = 0;


	public void Dispose()
	{
		// TODO release managed resources here
	}

	public TValue GetValue(TKey key)
	{
		//TODO:Implement
#warning NotImplemented
		throw new NotImplementedException();
	}
}