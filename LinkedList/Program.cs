using System;

 namespace LinkedList
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> n1 = new LinkedList<int>(10);
            LinkedList<int> n2 = new LinkedList<int>(20);
            LinkedList<int> n3 = new LinkedList<int>(30);
            
            n1.next = n2;
            LinkedList<int> ans= Insert(n1, 5, 0);
            Print(ans);



            
            //---------------------------
            //Print(LinkedList<int> head)
            //DeleteNode(deleteNode(LinkedList<int> head, int pos))
            //TakeInputImProved()
            //Insert(LinkedList<int> head,int elem,int pos)
        }
        public static LinkedList<int> DeleteNode(LinkedList<int> head, int pos)
        {
            LinkedList<int> prev = head;

            if (head == null)//IF IT IS AN EMPTY LINKED LIST
            {
                return head;
            }

            if (pos == 0)//DELETE THR FIRST NODE
            {

                head = head.next;
                return head;

            }
            else
            {
                int count = 0;
                while (prev != null && count < pos - 1)
                {
                    count++;
                    prev = prev.next;
                    if (prev == null)
                    {
                        return head;
                    }

                }


                if (prev.next == null)//IF THE COUNT EXCEED THE TAIL OF THE LINKED LIST
                {
                    return head;
                }
                else
                {
                    prev.next = prev.next.next;// REPLACING THE ADDRESS OF THE PREVOIUS NEXT TO TO ITS NEXT ,SO THE CURRENT POSITION WILL BE DELETED

                }
                return head;

            }
        }
        public static LinkedList<int> TakeInput()//TAKING INPUT FOR THE LINKED LIST AND ADDING IT TO THE TAIL ELEMENT
        {
            int data;

            bool success = int.TryParse(Console.ReadLine(), out data);



            LinkedList<int> head = null; //HEAD OF THE LINKEDLIST
            while (data != -1)
            {

                Console.WriteLine("enter the data");
                LinkedList<int> CurrentNode = new LinkedList<int>(data);
                if (head == null)
                {
                    head = CurrentNode;
                }
                else
                {
                    LinkedList<int> tail = head;
                    while (tail.next != null)
                    {
                        tail = tail.next;
                    }
                    tail.next = CurrentNode;
                }
                success = int.TryParse(Console.ReadLine(), out data);
            }
            return head;


        }
        public static LinkedList<int> TakeInputImProved()//IMPROVES THE TIME COMPLEXITY FROM O(n²) to O(n)
        {
            int data;

            bool success = int.TryParse(Console.ReadLine(), out data);



            LinkedList<int> head = null,tail=null; //head of the linkedList
            while (data != -1)
            {

                Console.WriteLine("enter the data");
                LinkedList<int> CurrentNode = new LinkedList<int>(data);
                if (head == null)
                {
                    head = CurrentNode;
                    tail = CurrentNode;
                }
                else
                {
                    tail.next = CurrentNode;
                    tail = CurrentNode;//tail=tail.next

                }
                success = int.TryParse(Console.ReadLine(), out data);
            }
            return head;


        }
        public static LinkedList<int> Insert(LinkedList<int> head,int elem,int pos)//TO INSERT AN ELEMENT IN THE LINKEDLIST IN A PARTICULAR POSITION 
        {
            
            LinkedList<int> NodeToBeInserted = new LinkedList<int>(elem);
            if (pos == 0)
            {
                NodeToBeInserted.next = head;
                return NodeToBeInserted;//NEW HEAD 
            }
            int count=0;
            LinkedList<int> Prev = head;
            while(count < pos - 1)
            {
                count++;
                Prev= Prev.next;
            }
            if (Prev.next != null)//TO AVOID NULL POINTER EXCEPTION
            {
                NodeToBeInserted.next = Prev.next;
                Prev.next = NodeToBeInserted;
            }
            return head;
        }
        public static void Print(LinkedList<int> head)
        {
            LinkedList<int> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
        public static int length(LinkedList<int> head) //TO FIND THE LENGTH OF THE LINKED LIST WHEN THE HEAD IS PASSED 
        {
            int count = 0;
            LinkedList<int> temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }


    }
    public class LinkedList<T>
    {
         internal T data;
         internal LinkedList<T> next;
        public LinkedList(T data)
        {
            this.data = data;
        }
        
        
        

    }
}
