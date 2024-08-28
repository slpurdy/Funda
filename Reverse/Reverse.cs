using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode() : this(0, null) {}
    public ListNode(int x) : this(x, null) {}
    public ListNode(int x, ListNode next) {
        this.val = x;
        this.next = next;
    }
}

//  reversing list
public class Solution2 {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while (current != null) {
            // Store next node
            next = current.next;
            // Reverse the current node's pointer
            current.next = prev;
            // Move prev and current one step forward
            prev = current;
            current = next;
        }

        return prev;
    }

    // Convert list 
    public List<int> ConvertListNodeToList(ListNode head) {
        List<int> result = new List<int>();
        ListNode current = head;
        while (current != null) {
            result.Add(current.val);
            current = current.next;
        }
        return result;
    }
}

// reversing  list 
class Program {
    static void Main(string[] args) {
        // Create a  list of grades
        ListNode head = new ListNode(85, new ListNode(70, new ListNode(95, new ListNode(60, new ListNode(75, new ListNode(90))))));

        // Reverse the list
        Solution2 solution2 = new Solution2();
        ListNode reversedHead = solution2.ReverseList(head);

        // Convert to integers
        List<int> reversedGrades = solution2.ConvertListNodeToList(reversedHead);

        // console reversed grades
        Console.WriteLine("Reversed Grades:");
        foreach (var grade in reversedGrades) {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
    }
}
