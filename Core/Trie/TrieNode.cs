namespace Core.Trie;
internal class TrieNode
{
    public char Value { get; set; }
    public List<TrieNode> Children { get; set; }
    public bool IsWord { get; set; }

    public TrieNode(char value)
    {
        Value = value;
        Children = new List<TrieNode>();
    }

}
