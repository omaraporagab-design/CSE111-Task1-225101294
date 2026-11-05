// Name: omar shereif shaban aburagab, Student ID: 225101294
// File: StudentList.cs

using System;

namespace CselllTask1
{
    public class StudentList
    {
        public Student? First { get; set; }
        public Student? Last { get; set; }
        public int Count { get; set; }

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        // AddFront: O(1) time
        public void AddFront(int id)
        {
            Student newStudent = new Student(id);
            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }
            Count++;
        }

        // AddEnd: O(1) time (using Last, no walking the line)
        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);
            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                if (Last != null)
                {
                    Last.Next = newStudent;
                    Last = newStudent;
                }
            }
            Count++;
        }

        // Remove: O(n) time
        public bool Remove(int id)
        {
            if (First == null) return false;

            Student? current = First;
            Student? previous = null;

            if (current != null && current.Id == id)
            {
                First = First.Next;
                Count--;
                if (First == null)
                {
                    Last = null;
                }
                return true;
            }

            while (current != null && current.Id != id)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null) return false;

            if (previous != null)
            {
                previous.Next = current.Next;
                if (current == Last)
                {
                    Last = previous;
                }
            }

            Count--;
            return true;
        }

        // Reverse: O(n) time
        public void Reverse()
        {
            if (First == null || First.Next == null) return;

            Student? prev = null;
            Student? current = First;
            Student? next = null;
            Student? originalFirst = First;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            First = prev;
            Last = originalFirst;
            Last.Next = null;
        }

        // Print: O(n) time
        public void Print()
        {
            Student? current = First;
            bool firstToPrint = true;

            while (current != null)
            {
                if (!firstToPrint)
                {
                    Console.Write(" ");
                }
                Console.Write(current.Id);
                current = current.Next;
                firstToPrint = false;
            }
            Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main(string5[] args)
        {
            StudentList list = new StudentList();

            // Step 0: start
            list.Print();

            // Step 1: AddFront(20)
            list.AddFront(20);
            list.Print();

            // Step 2: AddFront(10)
            list.AddFront(10);
            list.Print();

            // Step 3: AddEnd(30)
            list.AddEnd(30);
            list.Print();

            // Step 4: AddEnd(40)
            list.AddEnd(40);
            list.Print();

            // Step 5: Reverse()
            list.Reverse();
            list.Print();

            // Step 6: Remove(20)
            list.Remove(20);
            list.Print();
        }
    }
}