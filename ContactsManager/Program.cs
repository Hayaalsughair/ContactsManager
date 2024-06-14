using System.ComponentModel;
using System.Text;

namespace ContactsManager
{
    public class Program
    {
        static Dictionary<string, string> Contacts = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Contacts.Add("haya", "0780088552");
            Contacts.Add("raneem", "0790000000");
            Contacts.Add("reem", "0790077889");
            Contacts.Add("nory", "079555555");

            ContactManager();
        }
        public static void ContactManager()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Welcome to Our Contact Manager! \nChoose Service to Start:");
 
            bool validInput = false;
            while (!validInput) {
                Console.WriteLine("======================================\n");
                Console.WriteLine("[A] Add New Contact.\n[D] Delete a Contact. \n[S] Search for a Specific Contact. \n[V] View All Contacts\n[Q] Quit. ");
                string userInput = Console.ReadLine().ToUpper();
          
                if (userInput == "A" || userInput == "D" || userInput == "V" || userInput == "S" || userInput == "Q" )
                {
                    services(userInput);
                }
                else
                {
                    Console.WriteLine("Invalid Iuput!! You Should Write a Valid Service.");
                }

            }
        }
        public static void services (string input)
        {
            switch (input)
            {
                case "A":
                    Console.WriteLine(" Enter name : ");
                    string userName = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter phone number : ");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine(AddContact(userName, phoneNumber));
                    break;

                case "D":
                    Console.WriteLine(" Enter the contact name that you want to delete  : ");
                    userName = Console.ReadLine().ToLower();
                    Console.WriteLine(DeleteContact(userName));
                    break;

                case "S":
                    SearchContact();
                    break;

                case "V":
                    Dictionary<string,string> ShowContacts = new Dictionary<string,string>();
                    ShowContacts = ViewContacts();
                    if (ShowContacts.Count == 0)
                    {
                        Console.WriteLine("No contacts available.");
                    }
                    else
                    {
                        foreach (var item in ShowContacts)
                        {
                            Console.WriteLine($"Name: {item.Key}, Phone Number: {item.Value}");
                        }
                    }
                    break;

                case "Q":
                    Quit();
                    break;
            }
        }

        public static string AddContact(string userName, string phoneNumber)
        {
   
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "You add empty value, please Try Again ";
            }
            else
            {
                    if (!Contacts.ContainsKey(userName))
                    {

                        Contacts.Add(userName, phoneNumber);
                        Console.WriteLine("done");
                        return "Contact added successfully.";
                    }
                    else
                    {
                    return "Contact with this name already exists.";
                    }

            }
        
            
        }
        public static string DeleteContact(string item)
        {
            if (Contacts.ContainsKey(item))
            {
                Contacts.Remove(item);
                return "Contact Deleted successfully.";
            }
            else
            {
                return "Contact with this name does not exists.";
            }

        }
        public static Dictionary<string,string> ViewContacts()
        {
            return Contacts;
        }
        public static void SearchContact()
        {
            Console.WriteLine("Enter the name you want to search : ");
            string userName = Console.ReadLine().ToLower();
            if (Contacts.ContainsKey(userName))
            {
                Console.WriteLine($"Name :{userName} , Phone Number : {Contacts[userName]}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
        public static void Quit()
        {
            Console.WriteLine("Quit The Application....");
            Environment.Exit(0);

        }
    }
}
