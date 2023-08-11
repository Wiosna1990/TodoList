
class TODOLIST
{

    static void Main(string[] args)
    {
        List<string> todoList = new List<string>();
        bool exit = false;
        string todo;
        string index;
        int index1;
        int index2;
        Console.WriteLine("Hello!\r\nWhat do you want to do?");
        do
        {

            Console.WriteLine("\r\n[S]ee all TODOs\r\n[A]dd a TODO\r\n[R]emove a TODO\r\n[E]xit\r\n");
            var input = Console.ReadLine();
            var toUpperInput = input.ToUpper();



            switch (toUpperInput)
            {
                case "S":
                    if (todoList.Count > 0)
                    {
                        for (var i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{todoList[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No TODOs have been added yet.");
                    }
                    Console.WriteLine("What do you want to do?");
                    break;
                case "A":
                    Console.WriteLine("Enter the TODO description:");
                    todo = Console.ReadLine();

                    if (todo == " ")
                    {
                        Console.WriteLine("The description cannot be empty.");
                        Console.WriteLine("Enter the TODO description");
                    }
                    else if (todoList.Contains(todo))

                    {
                        Console.WriteLine("The description must be unique.");
                        Console.WriteLine("Enter the TODO description");
                    }
                    else

                    {
                        todoList.Add(todo);
                        Console.WriteLine($"TODO successfully added: {todo}");
                        Console.WriteLine($"Lista to: ");
                        for (var i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{todoList[i]}");
                        }
                        Console.WriteLine("What do you want to do?");
                    }

                    break;

                case "R":

                    Console.WriteLine("Select the index of the TODO you want to remove:");
                    if (todoList.Count > 0)
                    {
                        for (var i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{todoList[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No TODOs have been added yet.");
                        break;
                    }

                    try
                    {
                        do
                        {
                            index = Console.ReadLine();
                            index1 = int.Parse(index);
                            index2 = index1 - 1;

                            if (index1 > todoList.Count)
                            {
                                Console.WriteLine("The given index is not valid.");
                                Console.WriteLine("Select the index of the TODO you want to remove");
                            }
                            else if (index1 == todoList.Count)
                            {
                                Console.WriteLine($"TODO removed: {todoList[index2]} ");
                                todoList.RemoveAt(index2);
                                Console.WriteLine("What do you want to do?");
                                break;
                            }

                        } while (index1 != todoList.Count);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Selected index cannot be empty.");
                        Console.WriteLine("Select the index of the TODO you want to remove");
                    }
                    break;
                case "E":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        } while (exit == false);

    }
}