using System.Text;

namespace Core.Trie;
public class Trie
{
    private List<TrieNode> _nodes = new List<TrieNode>();

    public void Insert(string item)
    {
        if (string.IsNullOrWhiteSpace(item)) return;

        var node = FindOrCreateNode(_nodes, item[0]);
        Insert(item, 1, node);
    }

    public void Delete(string item) 
    {
        if (string.IsNullOrWhiteSpace(item)) return;

        var i = 0;
        var node = FindNode(_nodes, item[i++]);
        if (node is null) return;

        while (node is not null && i < item.Length)
        {
            node = FindNode(node.Children, item[i]);
            ++i;
        }

        if (node is not null) node.IsWord = false;
    } 

    public List<string> Find(string partial) 
    {
        if (string.IsNullOrWhiteSpace(partial)) return new();

        var node = FindNode(_nodes, partial[0]);
        if (node is null) return new();

        return FindWord(partial, 1, node.Children);
    }

    private static void Insert(string item, int index, TrieNode node)
    {
        if (index >= item.Length)
        {
            node.IsWord = true;
            return;
        }

        var currentChar = item[index];
        var nextNode = FindOrCreateNode(node.Children, currentChar);
        Insert(item, ++index, nextNode);
    }

    private static List<string> FindWord(string word, int index, List<TrieNode> nodes)
    {
        if (index >= word.Length)
        {
            var words = new List<string>();
            var sb = new StringBuilder(word);
            for (var i = 0; i < nodes.Count; ++i)
            {
                FindWordExtensions(sb, nodes[i], words);
            }

            return words;
        }

        var character = word[index];
        var node = FindNode(nodes, character);
        ++index;
        return node is null ? new() : FindWord(word, index, node.Children);
    }

    private static void FindWordExtensions(StringBuilder word, TrieNode node, List<string> words)
    {
        word.Append(node.Value);
        if (node.IsWord) words.Add(word.ToString());

        for (var i = 0; i < node.Children.Count; ++i)
        {
            FindWordExtensions(word, node.Children[i], words);
        }

        word.Length--;
    }

    private static TrieNode? FindNode(List<TrieNode> nodes, char character)
    {
        TrieNode? foundNode = null;
        foreach (var node in nodes)
        {
            if (node.Value == character) { foundNode = node; break; }
        }

        return foundNode;
    }

    private static TrieNode FindOrCreateNode(List<TrieNode> nodes, char character)
    {
        var foundNode = FindNode(nodes, character);
        if (foundNode is null)
        {
            foundNode = new TrieNode(character);
            nodes.Add(foundNode);
        }

        return foundNode;
    }
}
