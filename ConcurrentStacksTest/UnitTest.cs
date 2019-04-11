using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConcurrentStacksClasses;

namespace ConcurrentStacksTest
{
    [TestClass]
    public class UnitTestLockStack: UnitTestBase
    {
        [TestMethod]
        public void TestPush()
        {
            StackBase<string> stack = new LockStack<string>();
            base.TestPush(stack);
        }

        [TestMethod]
        public void TestPushPop()
        {
            StackBase<string> stack = new LockStack<string>();
            base.TestPushPop(stack);
            Assert.IsTrue(stack.IsEmpty, @"Stack must be empty!");                
        }
    }

    [TestClass]
    public class UnitTestMonitorStack: UnitTestBase
    {
        [TestMethod]
        public void TestPush()
        {
            StackBase<string> stack = new MonitorStack<string>();
            base.TestPush(stack);
        }

        [TestMethod]
        public void TestPushPop()
        {
            StackBase<string> stack = new MonitorStack<string>();
            base.TestPushPop(stack);
            Assert.IsTrue(stack.IsEmpty, @"Stack must be empty!");
        }
    }

    [TestClass]
    public class UnitTestLockFreeStack : UnitTestBase
    {
        [TestMethod]
        public void TestPush()
        {
            StackBase<string> stack = new LockFreeStack<string>();
            base.TestPush(stack);
        }

        [TestMethod]
        public void TestPushPop()
        {
            StackBase<string> stack = new LockFreeStack<string>();
            base.TestPushPop(stack);
            Assert.IsTrue(stack.IsEmpty, @"Stack must be empty!");
        }
    }

    [TestClass]
    public class UnitTestConcurrentStackWrapper : UnitTestBase
    {
        [TestMethod]
        public void TestPush()
        {
            StackBase<string> stack = new ConcurrentStackWrapper<string>();
            base.TestPush(stack);
        }

        [TestMethod]
        public void TestPushPop()
        {
            StackBase<string> stack = new ConcurrentStackWrapper<string>();
            base.TestPushPop(stack);
            Assert.IsTrue(stack.IsEmpty, @"Stack must be empty!");
        }
    }
}
