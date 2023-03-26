using System.Linq;
string choice;
List<Ticket> ticketList = new List<Ticket>();

do
{

    Console.WriteLine("1) Create New Ticket.");
    Console.WriteLine("2) View Ticket Information");
    Console.WriteLine("Enter any other key to exit.");
    
    choice = Console.ReadLine();

    if (choice == "1")

    {
        Ticket ticket = new Ticket();

        ticket.ticketId = ticketList.Count == 0 ? 1 : ticketList.Max(t => t.ticketId) + 1;

        Console.WriteLine("Ticket Summery");
        ticket.summary = Console.ReadLine().ToUpper();

        Console.WriteLine("Enter Ticket Status");
        ticket.status = Console.ReadLine().ToUpper();

        Console.WriteLine("Enter Ticket Priority");
        ticket.priority = Console.ReadLine().ToUpper();

        Console.WriteLine("Who Submitted Ticket?");
        ticket.owner = Console.ReadLine().ToUpper();

        Console.WriteLine("Who To Assign to Ticket?");
        ticket.assign = Console.ReadLine().ToUpper();

        Console.WriteLine("Who is Watching Ticket?");
        ticket.watch = Console.ReadLine().ToUpper();

        ticketList.Add(ticket);

    }
    
    else if (choice == "2")
 {
        foreach(Ticket ticket in ticketList){
            
            Console.WriteLine(ticket.Display());
        }
    }
} while (choice == "1" || choice == "2");
