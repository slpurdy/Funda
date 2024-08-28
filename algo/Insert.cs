using System;
using System.Collections.Generic;

public class Solution {
    // Insertion Sort
    public List<List<int>> InsertionSort(List<int> grades) {
        int n = grades.Count;
        List<List<int>> result = new List<List<int>>();  // To store t

        for (int i = 0; i < n; i++) {
            int j = i - 1;

            // Move grades 1 position
            while (j >= 0 && grades[j] > grades[j + 1]) {
                int temp = grades[j];
                grades[j] = grades[j + 1];
                grades[j + 1] = temp;
                j--;
            }

            // Clone and save 
            List<int> cloneGrades = new List<int>(grades);
            result.Add(cloneGrades);
        }
        return result;
    }
}

class Program1 {
    static void Main(string[] args) {
        // List grades 
        List<int> grades = new List<int> { 85, 70, 95, 60, 75, 90 };

        //  sort the grades
        Solution solution = new Solution();
        List<List<int>> sortedGrades = solution.InsertionSort(grades);

        //console the grades 
        foreach (var gradeSet in sortedGrades) {
            Console.WriteLine("Grades:");
            foreach (var grade in gradeSet) {
                Console.Write(grade + " ");
            }
            Console.WriteLine();
        }
    }
}


public class ListNode1 {
    public int val;
    public ListNode1 next;
    public ListNode1() : this(0, null) {}
    public ListNode1(int x) : this(x, null) {}
    public ListNode1(int x, ListNode1 next) {
        this.val = x;
        this.next = next;
    }
}

public class Solution1 {
    public ListNode1 ReverseList(ListNode1 head) {
        ListNode1 prev = null;
        ListNode1 current = head;
        ListNode1 next = null;

        while (current != null) {
            // Store 
            next = current.next;
            // Reverse the current 
            current.next = prev;
            // Move prev and current one step forward
            prev = current;
            current = next;
        }

        return prev;
    }
}
