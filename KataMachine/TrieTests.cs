using Core.Trie;

namespace KataMachine;
public class TrieTests
{
    [Fact]
    public void TestTrie()
    {
        var trie = new Trie();
        trie.Insert("foo");
        trie.Insert("fool");
        trie.Insert("foolish");
        trie.Insert("bar");

        var find1 = trie.Find("fo");
        var expected1 = new List<string> { "foo", "fool", "foolish" };
        ValidateStringList(expected1, find1);

        trie.Delete("fool");
        var find2 = trie.Find("fo");
        var expected2 = new List<string> { "foo", "foolish" };
        ValidateStringList(expected2, find2);
    }

    private void ValidateStringList(List<string> a, List<string> b) 
    {
        Assert.Equal(a.Count, b.Count);
        for (var i = 0; i < a.Count; ++i)
        {
            var word1 = a[i];
            var word2 = b[i];

            Assert.Equal(word1, word2);
        }
    }
}
