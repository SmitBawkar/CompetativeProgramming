/*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/
boolean hasCycle(Node head) {
HashMap<Node,Integer> visited = new HashMap<Node,Integer>();
Integer i = new Integer(1);
    
    if(head == null)
        return false;
    
    visited.put(head,i);
    while(head.next != null)
    {
       if(visited.containsKey(head.next))
           return true;
        else
            visited.put(head.next,i++);
        
        head = head.next;
    }
    
    return false;

}