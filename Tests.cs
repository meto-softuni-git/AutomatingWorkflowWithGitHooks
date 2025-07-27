using NUnit.Framework;

namespace AutomatingWorkflowWithGitHooks
{
    class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckMathSum()
        {
            var result = MathSum.Add(2, 3);
            Assert.Equals(5, result);
        }
    }
}
