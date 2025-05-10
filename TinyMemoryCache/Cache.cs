namespace TinyMemoryCache;

public class Cache<TKey, TValue> : IDisposable
	where
	TKey : IEquatable<TKey>
{
	//Capacity >= Threshold
	public Cache(int capacity, int threshold, IAdapter<TKey, TValue> adapter)
	{
		//TODO:Implement
#warning NotImplemented
		throw new NotImplementedException();
	}

	public int Capacity { get; } = 0;
	public int Threshold { get; } = 0;

	public int Count
	{
		get
		{
			//TODO:Implement
#warning NotImplemented
			throw new NotImplementedException();
		}
	}


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