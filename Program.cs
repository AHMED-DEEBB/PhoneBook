using PhoneBookConsole;

Console.WriteLine("\t\tWelcome To Phone Book App\n");
Console.WriteLine("Select Operation");
Console.WriteLine("1. Add Contact");
Console.WriteLine("2. Display Contact By Number");
Console.WriteLine("3. View All Contacts");
Console.WriteLine("4. Search For Contact For A Given Name");




var phoneBook = new PhoneBook();

char c;
do
{
    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.Write("Contact Name: ");
            var name = Console.ReadLine();
            Console.Write("Contact Number: ");
            var number = Console.ReadLine();

            var newContact = new Contact(name, number);

            phoneBook.AddContact(newContact);
            break;

        case "2":
            Console.Write("Contact Number To Search: ");
            var searchNumber = Console.ReadLine();
            phoneBook.DisplayContact(searchNumber);
            break;

        case "3":
            phoneBook.DisplayAllContacts();
            break;

        case "4":
            Console.WriteLine("Name Search Phrase: ");
            var searchPhrase = Console.ReadLine();
            phoneBook.DisplayMatchingContact(searchPhrase);
            break;

        default:
            Console.WriteLine("Invalid Operation");
            break;
    }


    Console.WriteLine("Do you want to perform another operation ? (Y / N)");
    c = Convert.ToChar(Console.ReadLine());

} while (c != 'n' && c != 'N');






Console.ReadKey();




