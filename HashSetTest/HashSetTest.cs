using HashSetClass;
using SPSStudentClass;


namespace HashSetTest;

[TestClass]
public sealed class HashSetTest
{
    [TestMethod]
    public void test_Add_and_IsPresent()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(10);
        hashSet.Add(5);
        hashSet.Add(10);
        hashSet.Add(5);
        Assert.IsTrue(hashSet.IsPresent(5));
        Assert.IsTrue(hashSet.IsPresent(10));
    }


    [TestMethod]
    public void test_Rebalance()
    {
        int initialSize = 5;
        MyHashSet<int> hashSet = new MyHashSet<int>(initialSize);
        for (int i = 0; i < 50; i++) { hashSet.Add(i); }
        hashSet.Rebalance();
        for (int i = 0; i < 50; i++) { Assert.IsTrue(hashSet.IsPresent(i), $"{i} was lost during rebalance."); }
        Assert.IsFalse(hashSet.IsPresent(100), "Non-existent item found after rebalance.");
    }
}
