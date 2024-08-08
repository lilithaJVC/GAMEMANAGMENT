using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerWPF
{
    internal class Node
    {
        public Node(int storyNumber, string storyText, Node next = null)
        {
            StoryNumber = storyNumber;
            StoryText = storyText;
            Next = next;
        }

        public int StoryNumber { get; set; }
        public string StoryText { get; set; }
        public Node Next { get; set; }
    }

    internal class StoryLinkedList
    {
        public Node Head { get; private set; }

        public void AddNode(int storyNumber, string storyText)
        {
            Node newNode = new Node(storyNumber, storyText);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Sorting the linked list using Bubble Sort for simplicity
        public void Sort()
        {
            if (Head == null || Head.Next == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = Head;
                Node previous = null;

                while (current != null && current.Next != null)
                {
                    if (current.StoryNumber > current.Next.StoryNumber)
                    {
                        Node next = current.Next;

                        // Swap nodes
                        if (previous == null)
                        {
                            current.Next = next.Next;
                            next.Next = current;
                            Head = next;
                        }
                        else
                        {
                            previous.Next = next;
                            current.Next = next.Next;
                            next.Next = current;
                        }

                        swapped = true;
                    }

                    previous = current;
                    current = current.Next;
                }
            } while (swapped);
        }

        public IEnumerable<string> GetSortedScript()
        {
            Node current = Head;
            while (current != null)
            {
                yield return current.StoryText;
                current = current.Next;
            }
        }
    }

}
