using NUnit.Framework;

namespace Algorithms.CSharp.Test.Strings
{
    [TestFixture]
    internal class WordFrequency
    {
        [TestCase("The quick brown fox jumps over the lazy dog", "the", 2)]
        [TestCase("The quick brown fox jumps over the lazy dog", "cat", 0)]
        [TestCase("This is a TEST", "Test", 1)] // Case insensitive test
        [TestCase("This      string has multiple spaces", "string", 1)] // Handles multiple spaces
        public void TestWordFrequency_ShouldGetExpectedResult(string wholePhrase,string word,int expected)
        {
            var result = Algorithms.Strings.WordFrequency.WordFrequencyCount(text);
            Assert.AreEqual(expected, result);
        }
    }
}
