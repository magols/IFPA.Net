using Xunit;

namespace IFPA.Net.Test
{
	[CollectionDefinition("Test collection")]
	public class TestCollection : ICollectionFixture<IfpaTestFixture>
	{
	}
}