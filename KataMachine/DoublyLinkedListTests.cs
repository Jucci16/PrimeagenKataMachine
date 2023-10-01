using Core.DoublyLinkedList;

namespace KataMachine;
public class DoublyLinkedListTests
{
    [Fact]
    public void CheckSinglyLinkedList()
    {
        var list = new DoublyLinkedList<int>();
        ListTests.TestList(list);
    }
}
