using Xunit;

namespace Loken.TestLib
{
    public class StringExtensionTests
    {
        [Fact]
        public void SplitList_Works()
        {
            string[] expected = { "some", "other", "thing" };
            var actual = "some;other;;thing".SplitList();

            Assert.Equal(expected, actual);
        }
    }
}
