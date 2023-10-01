using Core.SinglyLinkedList;

namespace KataMachine;
public class SinglyLinkedListTests
{
    [Fact]
    public void CheckSinglyLinkedList()
    {
        var list = new SinglyLinkedList<int>();
        ListTests.TestList(list);
    }
}
