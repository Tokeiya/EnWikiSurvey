using TinyMemoryCache;

namespace TinyMemoryCacheTests;

using TestFixture = CacheElement<string, int>;

public class CacheElementTests
{
	[Fact]
	public void CtorTest()
	{
		var fixture = new CacheElement<string, int>("hello", 10);
		fixture.Key.Is("hello");
		fixture.Value.Is(10);
		fixture.RefCount.Is(0ul);
	}

	[Fact]
	public void ValuePropTest()
	{
		TestFixture fixture = new("hello", 10);
		fixture.Value = 20;
		fixture.Value.Is(20);
		fixture.RefCount.Is(0ul);
		fixture.Key.Is("hello");
	}

	[Fact]
	public void RefCountTest()
	{
		var fixture = new CacheElement<string, int>("hello", 10);
		fixture.RefCount = 5;
		fixture.RefCount.Is(5ul);

		fixture.Value.Is(10);
		fixture.Key.Is("hello");
	}
}