using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_predefinidas_de_pila_stack_y_cola
{
    internal class Program
    {     
    
    static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Popped: " + stack.Pop()); // Output: 30
            Console.WriteLine("Popped: " + stack.Pop()); // Output: 20
        }
    }
   
class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Dequeued: " + queue.Dequeue()); // Output: 10
            Console.WriteLine("Dequeued: " + queue.Dequeue()); // Output: 20
        }
    }

}
class LinkedListExample
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        linkedList.AddLast(10);
        linkedList.AddLast(20);
        linkedList.AddLast(30);

        linkedList.RemoveFirst();

        Console.WriteLine("Second item: " + linkedList.First.Value); // Output: 20
    }
}
