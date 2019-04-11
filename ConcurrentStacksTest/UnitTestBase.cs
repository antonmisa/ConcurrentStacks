using ConcurrentStacksClasses;
using System.Linq;
using System.Threading;

namespace ConcurrentStacksTest
{
    public class UnitTestBase
    {
        private int threadCount = 2;
        private int iterations = 100;
        private int iterationDepth = 100;

        public void TestPush(StackBase<string> stack)
        {
            var threads = Enumerable
                .Range(0, threadCount)
                .Select(
                    n => new Thread(
                        () =>
                        {
                            for (var j = 0; j < iterations; j++)
                            {
                                for (var i = 0; i < iterationDepth; i++)
                                {
                                    stack.Push(i.ToString());
                                }
                            }
                        }))
               .ToArray();

            foreach (var thread in threads)
            {
                thread.Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        public void TestPushPop(StackBase<string> stack)
        {
            var threads = Enumerable
                .Range(0, threadCount)
                .Select(
                    n => new Thread(
                        () =>
                        {
                            for (var j = 0; j < iterations; j++)
                            {
                                for (var i = 0; i < iterationDepth; i++)
                                {
                                    stack.Push(i.ToString());
                                }

                                string res;

                                for (var i = 0; i < iterationDepth; i++)
                                {
                                    stack.TryPop(out res);
                                }
                            }
                        }))
               .ToArray();

            foreach (var thread in threads)
            {
                thread.Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
    }
}
