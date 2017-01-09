namespace TapeEquilibrium.Tests
{
    using Core;

    using Xunit;

    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4, 3 }, 1)]
        [InlineData(new int[] { 3, 1, 2, 1, 3, 5 }, 1)]
        [InlineData(new int[] { 5, 1, 3 }, 1)]
        public void GetTapeEquilibrium_ReturnsMinimalDifferenceForGivenArray(int[] array, int expected)
        {
            var sut = new Solution();
            var actual = sut.GetTapeEquilibrium(array);

            Assert.Equal(expected, actual);
        }
    }
}
