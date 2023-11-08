namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            Console.WriteLine("Enter the person's name:");
            string name = Console.ReadLine();

            if (!personList.Contains(name))
            {
                personList.Add(name);
                Console.WriteLine("Person added to the list.");

                if (!personAgeDictionary.ContainsKey(name))
                {
                    Console.WriteLine("Enter the person's age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    personAgeDictionary.Add(name, age);
                    Console.WriteLine("Person added to the dictionary.");
                }
                else
                {
                    Console.WriteLine("Person already exists in the dictionary.");
                }
            }
            else
            {
                Console.WriteLine("Person already exists in the list.");
            }
        }
        public static void RemovePerson()
        {
            Console.WriteLine("Enter the person's name to remove:");
            string name = Console.ReadLine();

            if (personList.Contains(name))
            {
                personList.Remove(name);
                Console.WriteLine("Person removed from the list.");
            }
            else
            {
                Console.WriteLine("Person not found in the list.");
            }

            if (personAgeDictionary.ContainsKey(name))
            {
                personAgeDictionary.Remove(name);
                Console.WriteLine("Person removed from the dictionary.");
            }
            else
            {
                Console.WriteLine("Person not found in the dictionary.");
            }
        }
        public static void FindPerson()
        {
            Console.WriteLine("Enter the person's name to find:");
            string name = Console.ReadLine();

            if (personList.Contains(name))
            {
                Console.WriteLine($"{name} found in the list.");
            }
            else
            {
                Console.WriteLine($"{name} not found in the list.");
            }

            if (personAgeDictionary.ContainsKey(name))
            {
                Console.WriteLine($"{name} found in the dictionary. Age: {personAgeDictionary[name]}.");
            }
            else
            {
                Console.WriteLine($"{name} not found in the dictionary.");
            }
        }
        public static void DisplayAllPersons()
        {
            if (personList.Count > 0)
            {
                Console.WriteLine("Persons in the list:");
                foreach (var person in personList)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("No persons in the list.");
            }

            if (personAgeDictionary.Count > 0)
            {
                Console.WriteLine("Persons in the dictionary:");
                foreach (var kvp in personAgeDictionary)
                {
                    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("No persons in the dictionary.");
            }
        }
    }
}
