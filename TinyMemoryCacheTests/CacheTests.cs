using FakeItEasy;
using TinyMemoryCache;

namespace TinyMemoryCacheTests;

using Fixture = Cache<string, uint>;

public class CacheTests
{
	[Fact]
	public void CtorTest()
	{
		var fake = A.Fake<IAdapter<string, uint>>();
		Fixture fixture = new(10, 5, fake);

		fixture.Capacity.Is(10);
		fixture.Threshold.Is(5);
		fixture.Count.Is(0);
	}

	[Fact]
	public void InvalidCtorTest()
	{
		var fake = A.Fake<IAdapter<string, uint>>();
		Assert.Throws<ArgumentOutOfRangeException>(() => new Fixture(0, 5, fake));
		Assert.Throws<ArgumentOutOfRangeException>(() => new Fixture(10, 0, fake));
		Assert.Throws<ArgumentOutOfRangeException>(() => new Fixture(5, 10, fake));
		Assert.Throws<ArgumentOutOfRangeException>(() => new Fixture(-5, 5, fake));
		Assert.Throws<ArgumentOutOfRangeException>(() => new Fixture(5, -5, fake));
	}

	[Fact]
	public void GetValueTest()
	{
		//TODO:Implement
#warning NotImplemented
		throw new NotImplementedException();
	}

	[Fact]
	public void WriteBackTest()
	{
		//TODO:Implement
#warning NotImplemented
		throw new NotImplementedException();
	}

	[Fact]
	public void DisposeTest()
	{
		//TODO:Implement
#warning NotImplemented
		throw new NotImplementedException();
	}
}