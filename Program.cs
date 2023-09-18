// See https://aka.ms/new-console-template for more information
bool isOpen = true;

while (isOpen)
{
    Console.WriteLine("Main Menu :");
    Console.WriteLine("1. Youth Or Pensioner");
    Console.WriteLine("2. Calculate Total Price");
    Console.WriteLine("3. Repeat Ten Times");
    Console.WriteLine("4. The Third word");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "0":
            {
                isOpen = false;
                break;
            }
        case "1":
            {
                checkAge();
                break;
            }
        case "2":
            {
                calculateTotalCost();
                break;
            }
        case "3":
            {
                RepeatTenTimes();
                break;
            }
        case "4":
            {
                GetThirdWord();
                break;
            }
        default:
            Console.WriteLine("Invalid choice.Please try again.");
            break;

    }
}

/*TO check the category of person by age*/
void checkAge()
{
    Console.WriteLine("Enter the age: ");
    if (int.TryParse(Console.ReadLine(), out int age))
    {
        if (age > 0)
        {
            if ((age < 5) || (age > 100))
            {
                Console.WriteLine("Free");
            }
            else if (age < 20)
            {
                Console.WriteLine("Youth's Price: SEK 80");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensioner's Price: SEK 90");
            }
            else
            {
                Console.WriteLine("Standard Price: SEK 120");
            }
        }
        else
        {
            Console.WriteLine("Age should be greater than Zero!");
        }
    }
    else
    {
        Console.WriteLine("Please Enter a valid age.");
    }
}


/*To calculate total amount and count of people*/
void calculateTotalCost()
{
    Console.WriteLine("Enter total number of people");
    if (int.TryParse(Console.ReadLine(), out int peopleCount))
    {
        int totalCost = 0;
        for (int i = 0; i < peopleCount; i++)
        {
            Console.WriteLine($"Enter age for person {i + 1}:  ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 5 || age > 100) // children under 5 and senior above 100 go for free
                {
                    continue;
                }
                else if (age < 20)
                {
                    totalCost += 80;
                }
                else if (age > 64)
                {
                    totalCost += 90;
                }
                else
                {
                    totalCost += 120;
                }
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter again.");

            }
        }
        Console.WriteLine($"Number Of People: {peopleCount}");
        Console.WriteLine($"Total Amount: {totalCost}");
    }
    else
    {
        Console.WriteLine("Please enter a valid input.");
    }
}


/*TO repeat text ten times*/
void RepeatTenTimes()
{
    Console.WriteLine("Enter a text: ");
    string inputText = Console.ReadLine();
    for (int i = 0; i <= 10; i++)
    {
        Console.Write($"{i}. {inputText} ");
    }
    Console.WriteLine();
}


/*To print the third word*/
void GetThirdWord()
{
    Console.WriteLine("Enter a sentence with atleast 3 words: ");
    string text = Console.ReadLine();
    string[] words = System.Text.RegularExpressions.Regex.Split(text, @"\s+");

    if (words.Length >= 3)
    {
        string thirdword = words[2];
        Console.WriteLine($"The Third Word is: {thirdword}");
    }
    else
    {
        Console.WriteLine("Please enter valid text. ");
    }
}

