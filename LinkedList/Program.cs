using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Execute();
            Console.Read();
        }        

        public static class Menu
        {
            public static void Execute()
            {
                int choice, data, value, position;

                LinkedList list = new LinkedList();
                CreateList(list);

                while (true)
                {
                    Console.WriteLine("1.Display");
                    Console.WriteLine("2.Append");
                    Console.WriteLine("3.Prepend");
                    Console.WriteLine("4.InsertBeforeValue ");
                    Console.WriteLine("5.InsertAfterValue");
                    Console.WriteLine("6.InsertBeforePosition");
                    Console.WriteLine("7.InsertAfterPosition");
                    Console.WriteLine("8.Delete");
                    Console.WriteLine("9.DeleteAtPosition");
                    Console.WriteLine("10.DeleteFirst");
                    Console.WriteLine("11.DeleteLast");
                    Console.WriteLine("12.Length");
                    Console.WriteLine("13.Search");
                    //Console.WriteLine("14.Buble sort by exchanging links");
                    //Console.WriteLine("15.MergeSort");
                    //Console.WriteLine("16.Insert Cycle");
                    //Console.WriteLine("17.Detect Cycle");
                    //Console.WriteLine("18.Remove Cycle");
                    //Console.WriteLine("19.Quit");

                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 19)
                        break;
                    switch (choice)
                    {
                        case 1: list.Display(); break;
                        case 2:
                            Console.Write("Enter the value to Append: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.Append(data);
                            break;
                        case 3:
                            Console.Write("Enter the value to Prepend: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.Prepend(data);
                            break;
                        case 4:
                            Console.Write("Enter the value to insert: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("before value: ");
                            value = Convert.ToInt32(Console.ReadLine());
                            list.InsertBeforeValue(data, value);
                            break;
                        case 5:
                            Console.Write("Enter the value to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("after value: ");
                            value = Convert.ToInt32(Console.ReadLine());
                            list.InsertAfterValue(data, value);
                            break;
                        case 6:
                            Console.Write("Enter the value to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("before position: ");
                            position = Convert.ToInt32(Console.ReadLine());
                            list.InsertBeforePosition(data, position);
                            break;
                        case 7:
                            Console.Write("Enter the value to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("after position: ");
                            position = Convert.ToInt32(Console.ReadLine());
                            list.InsertAfterPosition(data, position);
                            break;
                        case 8:
                            Console.Write("Enter the value to Delete: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.Delete(data);
                            break;
                        case 9:
                            Console.Write("Enter the position to Delete: ");
                            position = Convert.ToInt32(Console.ReadLine());
                            list.DeleteAtPosition(position);
                            break;
                        case 10: list.DeleteFirst(); break;
                        case 11: list.DeleteLast();  break;
                        case 12: list.Length(); break;
                        case 13:
                            Console.Write("Enter the value to Search: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.Search(data);
                            break;
                        default: Console.WriteLine("Wrong Choice"); break;
                    }                    
                    Console.WriteLine();                    
                }
                Console.WriteLine("Exiting");
            }

            public static void CreateList(LinkedList list)
            {
                Console.Write("Enter the number of nodes: ");
                var n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                    return;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter the element to be inserted: ");
                    var data = Convert.ToInt32(Console.ReadLine());
                    list.Append(data);
                }
                list.Display();
            }


        }
    }
}
