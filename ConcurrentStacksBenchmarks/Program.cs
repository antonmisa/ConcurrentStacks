using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ConcurrentStacksClasses;

namespace ConcurrentStacksBenchmarks
{
    public class ConcurrentPushPopCollectionsBenchmark : BenchmarkBase
    {
        [Benchmark(Description = "LockStack pushpop with 2 threads")]
        public void LockStackPushPopW2Threads()
        {
            StackBase<string> stack = new LockStack<string>();
            base.TestPushPop(stack, 2);
        }

        [Benchmark(Description = "MonitorStack pushpop with 2 threads")]
        public void MonitorStackPushPopW2Threads()
        {
            StackBase<string> stack = new MonitorStack<string>();
            base.TestPushPop(stack, 2);
        }

        [Benchmark(Description = "LockFreeStack pushpop with 2 threads")]
        public void LockFreeStackPushPopW2Threads()
        {
            StackBase<string> stack = new LockFreeStack<string>();
            base.TestPushPop(stack, 2);
        }

        [Benchmark(Description = "ConcurrentStackWrapper pushpop with 2 threads")]
        public void ConcurrentStackWrapperPushPopW2Threads()
        {
            StackBase<string> stack = new ConcurrentStackWrapper<string>();
            base.TestPushPop(stack, 2);
        }

        [Benchmark(Description = "LockStack pushpop with 4 threads")]
        public void LockStackPushPopW4Threads()
        {
            StackBase<string> stack = new LockStack<string>();
            base.TestPushPop(stack, 4);
        }

        [Benchmark(Description = "MonitorStack pushpop with 4 threads")]
        public void MonitorStackPushPopW4Threads()
        {
            StackBase<string> stack = new MonitorStack<string>();
            base.TestPushPop(stack, 4);
        }

        [Benchmark(Description = "LockFreeStack pushpop with 4 threads")]
        public void LockFreeStackPushPopW4Threads()
        {
            StackBase<string> stack = new LockFreeStack<string>();
            base.TestPushPop(stack, 4);
        }

        [Benchmark(Description = "ConcurrentStackWrapper pushpop with 4 threads")]
        public void ConcurrentStackWrapperTestPushPopW4Threads()
        {
            StackBase<string> stack = new ConcurrentStackWrapper<string>();
            base.TestPushPop(stack, 4);
        }
    }

    public class ConcurrentPushCollectionsBenchmark: BenchmarkBase
    {
        [Benchmark(Description = "LockStack push with 2 threads")]
        public void LockStackPushW2Threads()
        {
            StackBase<string> stack = new LockStack<string>();
            base.TestPush(stack, 2);
        }

        [Benchmark(Description = "MonitorStack push with 2 threads")]
        public void MonitorStackPushW2Threads()
        {
            StackBase<string> stack = new MonitorStack<string>();
            base.TestPush(stack, 2);
        }

        [Benchmark(Description = "LockFreeStack push with 2 threads")]
        public void LockFreeStackPushW2Threads()
        {
            StackBase<string> stack = new LockFreeStack<string>();
            base.TestPush(stack, 2);
        }

        [Benchmark(Description = "ConcurrentStackWrapper push with 2 threads")]
        public void ConcurrentStackWrapperPushW2Threads()
        {
            StackBase<string> stack = new ConcurrentStackWrapper<string>();
            base.TestPush(stack, 2);
        }

        [Benchmark(Description = "LockStack push with 4 threads")]
        public void LockStackPushW4Threads()
        {
            StackBase<string> stack = new LockStack<string>();
            base.TestPush(stack, 4);
        }

        [Benchmark(Description = "MonitorStack push with 4 threads")]
        public void MonitorStackPushW4Threads()
        {
            StackBase<string> stack = new MonitorStack<string>();
            base.TestPush(stack, 4);
        }

        [Benchmark(Description = "LockFreeStack push with 4 threads")]
        public void LockFreeStackPushW4Threads()
        {
            StackBase<string> stack = new LockFreeStack<string>();
            base.TestPush(stack, 4);
        }

        [Benchmark(Description = "ConcurrentStackWrapper push with 4 threads")]
        public void ConcurrentStackWrapperPushW4Threads()
        {
            StackBase<string> stack = new ConcurrentStackWrapper<string>();
            base.TestPush(stack, 4);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ConcurrentPushCollectionsBenchmark>();
            BenchmarkRunner.Run<ConcurrentPushPopCollectionsBenchmark>();
        }
    }
}
