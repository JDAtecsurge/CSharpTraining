
Console.WriteLine("Hello!");

List<string> todolist = new List<string>();

do
{
    Console.WriteLine("");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee All todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine();

    if (userInput == "S" || userInput == "s")
    {
        if (todolist.Count == 0)
        {
            Console.WriteLine("No TODOs have been added yet.");
        }

        for (int i = 0; i < todolist.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + todolist[i]);
        }

    }
    else if (userInput == "A" || userInput == "a")
    {
        string inputTODO;
        do
        {
            Console.WriteLine("Enter the TODO description");
            inputTODO = Console.ReadLine();

            if (inputTODO == "")
            {
                Console.WriteLine("The description cannot be empty.");
            }
            else if (todolist.Contains(inputTODO))
            {
                Console.WriteLine("The description must be unique.");
                inputTODO = "";
            }
            else
            {
                todolist.Add(inputTODO);
                Console.WriteLine("Todo successfully added: " + inputTODO);

            }


        }
        while (inputTODO == "");


    }
    else if (userInput == "R" || userInput == "r")
    {
        string inputRemove;
        do
        {
            if (todolist.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                break;
            }

            Console.WriteLine("Select the index of the TODO you want to remove.");

            for (int i = 0; i < todolist.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + todolist[i]);
            }

            inputRemove = Console.ReadLine();
            if (inputRemove == "")
            {
                Console.WriteLine("Selected index cannot be empty.");
                continue;
            }

            //int parsenum = int.Parse(inputRemove);

            bool isNum = int.TryParse(inputRemove, out int result);

            if (todolist.Count < result || result <= 0 || isNum == false)
            {
                Console.WriteLine("The given index is not valid.");
                inputRemove = "";
                continue;
            }

            Console.WriteLine("TODO removed: " + todolist[result - 1]);
            todolist.RemoveAt(result - 1);

        }
        while (inputRemove == "");
    }
    else if (userInput == "E" || userInput == "e")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Choice.");
        continue;
    }
}
while (true);
Console.ReadKey();