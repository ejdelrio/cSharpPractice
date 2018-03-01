using System;
using System.Collections.Generic;
namespace cSharpPractice
{
  public class PersonTrieTree
  {
    //Mimics searching through contacts using a fuzzy search :D
    Dictionary<char, PersonTrieNode> root = new Dictionary<char, PersonTrieNode> { };

    class PersonTrieNode 
    {
      public Contact content = null;
      public Dictionary<char, PersonTrieNode> children = new Dictionary<char, PersonTrieNode> {};
    }



    public PersonTrieTree AddContact(string name, long phone) 
    {
      if (name.Length - 1 <= 0) throw new ArgumentException("String must have a length greater than 0");
      char firstChar = name[0];
      if (!root.ContainsKey(firstChar)) root.Add(firstChar, new PersonTrieNode());

      PersonTrieTree RecursiveNodePopulation(char alpha, int ind, PersonTrieNode node) 
      {

        if(ind == name.Length - 1) 
        {
          if (node.content != null) throw new ArgumentException("Duplicate contact names forbidden");
          node.content = new Contact(name, phone);
          return this;
        }

        char nextChar = name[ind + 1];
        bool hasChild = node.children.ContainsKey(nextChar);

        if (hasChild) return RecursiveNodePopulation(nextChar, ind + 1, node.children[nextChar]);
        node.children.Add(nextChar, new PersonTrieNode());

        return RecursiveNodePopulation(nextChar, ind + 1, node.children[nextChar]);
      }
     
      return RecursiveNodePopulation(firstChar, 0, root[firstChar]);
    }



    public List<Contact> fuzzySearch(string search) 
    {
      //Performs fuzzy search. 
      //If you type E, it will return all contacts with a name that starts with E
      //If you type Ed, it will return all contacts that starts with Ed and etc....
      if (search.Length == 0) throw new ArgumentException("Name must have length greater than 0");
      List < Contact > output = new List<Contact> { };
      char currentChar = search[0];

      if(!root.ContainsKey(currentChar)) return output;
      if (root[currentChar].content != null) output.Add(root[currentChar].content);

      List < Contact > RecursiveNodeSearch(int ind, PersonTrieNode node) 
      {
        bool endOfString = ind >= search.Length - 1;
        bool hasContent = node.content != null;

        if (!endOfString) 
        {
          return node.children.ContainsKey(search[ind + 1]) ?
                     RecursiveNodeSearch(ind + 1, node.children[search[ind + 1]]) :
                     output;
        }

        foreach (KeyValuePair<char, PersonTrieNode> entry in node.children) 
        {
          RecursiveNodeSearch(ind + 1, entry.Value);
        }
        if (hasContent) output.Add(node.content);

        return output;
      }

      return RecursiveNodeSearch(0, root[currentChar]);
    }



    public void displayFuzzySearchresults(string search)
    {
      List<Contact> searchResults = fuzzySearch(search);
      List<int[]> testList = new List<int[]> { };
      if (searchResults.Count == 0) return;

      for (int i = 0; i < searchResults.Count; i++) 
      {
        Console.Write(searchResults[i].name + " : ");
        Console.Write(searchResults[i].phoneNumber + "\n");
      }
    }
  }

}
