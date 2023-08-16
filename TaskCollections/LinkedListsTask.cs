class LinkedListsTask
{
    static public void AddAfter(LinkedList<int> list)
    {
        Console.WriteLine("LINKEDLIST task1");  
        var currentNode = list.First;
        while (currentNode != null)
        {
            if (currentNode.Value == 2)
            {
                list.AddAfter(currentNode, 10);
            }
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Next;
        }        
    }
}



