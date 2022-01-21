// See https://aka.ms/new-console-template for more information
using MyLinkedListProblems;
using System.Collections.Generic;

bool flag = true;
while (flag)
{
    Console.WriteLine("\nEnter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.UC-5, \n 6.UC-6, \n 7.UC-7, \n 8.UC-8, \n 9.UC-9, \n 10.UC-10, \n 11.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            break;
        case 2:
            LinkedList list1 = new LinkedList();
            list1.Add(56);
            list1.Add(30);
            list1.Add(70);
            list1.Display();
            break;
        case 3:
            LinkedList link = new LinkedList();
            link.Add(56);
            link.Add(30);
            link.Add(70);
            link.InsertAtParticularPosition(2, 30);
            link.Display();
            break;
        case 4:
            LinkedList link1 = new LinkedList();
            link1.Add(56);
            link1.Add(30);
            link1.Add(70);
            link1.Display();
            break;
        case 5:
            LinkedList link2 = new LinkedList();
            link2.Add(56);
            link2.Add(30);
            link2.Add(70);
            link2.RemoveFirstNode();
            Console.WriteLine("After removing is : ");
            link2.Display();
            break;
        case 6:
            LinkedList link3 = new LinkedList();
            link3.Add(56);
            link3.Add(30);
            link3.Add(70);
            link3.RemoveLastNode();
            Console.WriteLine("After removing is : ");
            link3.Display();
            break;
        case 7:
            LinkedList link4 = new LinkedList();
            link4.Add(56);
            link4.Add(30);
            link4.Add(70);
            int search = link4.Search(30);
            Console.WriteLine(search);
            break;
        case 8:
            LinkedList link5 = new LinkedList();
            link5.Add(56);
            link5.Add(30);
            link5.Add(70);
            int position = link5.Search(30);
            position++;
            link5.InsertAtParticularPosition(position, 40);
            link5.Display();
            break;
        case 9:
            LinkedList link6 = new LinkedList();
            link6.Add(56);
            link6.Add(30);
            link6.Add(70);
            link6.Display();
            int position1 = link6.Search(40);
            link6.DeleteNodeAtParticularPosition(position1);
            break;
        case 10:
            LinkedList link7 = new LinkedList();
            link7.push(56);
            link7.push(70);
            link7.push(40);
            link7.push(30);
            Console.WriteLine("Linked List before Sorting..");
            link7.printlist(link7.head);
            link7.insertionSort(link7.head);
            Console.WriteLine("\nLinkedList After sorting");
            link7.printlist(link7.head);
            break;
        case 11:
            flag = false;
            break;
    }
}
