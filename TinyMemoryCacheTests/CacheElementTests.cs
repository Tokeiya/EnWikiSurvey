namespace TinyMemoryCacheTests;

using TinyMemoryCache;

public class CacheElementTests
{
	[Fact]
	public void CtorTest()
	{
		var fixture = new CacheElement<string,int>("hello", 10);
		fixture.Key.Is("hello");
		fixture.Value.Is(10);
		fixture.RefCount.Is(0ul);

	}
}