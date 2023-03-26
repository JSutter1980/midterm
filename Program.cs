using System.Linq;
using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";

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
        Console.WriteLine("Enter the number for the type of ticket:\n 1.Bug/Defect\n 2.Enhancement\n 3.Task ");
        string type = Console.ReadLine();
        
        
        Ticket ticket = new Ticket();

        ticket.ticketId = ticketList.Count == 0 ? 1 : ticketList.Max(t => t.ticketId) + 1;

        Console.WriteLine("Ticket Summery");
        ticket.summary = Console.ReadLine().ToUpper();

        Console.WriteLine("Enter Ticket Status");
        ticket.status = Console.ReadLine().ToUpper();

        Console.WriteLine("Enter Ticket Priority(High,Medium,Low)");
        ticket.priority = Console.ReadLine().ToUpper();

        Console.WriteLine("Who Submitted Ticket?");
        ticket.owner = Console.ReadLine().ToUpper();

        Console.WriteLine("Who To Assign to Ticket?");
        ticket.assign = Console.ReadLine().ToUpper();

        Console.WriteLine("Who is Watching Ticket?");
        ticket.watch = Console.ReadLine().ToUpper();

        if (type == "1")
        {
        Console.WriteLine("What is the Severity of the ticket?(High,Medium,Low)");
        ticket.severity = Console.ReadLine().ToUpper();
        }

        else if (type == "2")
    {
        Console.WriteLine("What is the software you are editing?");
       string edit = Console.ReadLine();

       Console.WriteLine("What is the cost?");
       string dollars = Console.ReadLine();

       Console.WriteLine("What is the reason for the enhancement?");
       string why = Console.ReadLine();

       Console.WriteLine("What is the estimated cost?");
       string estimatedCost = Console.ReadLine();

        Enhancement enhancement = new Enhancement
        {
           software = edit,
           cost = dollars,
           reason = why,
           estimate = estimatedCost
        };

    }    
    

    else if (type == "3")
    {
        Console.WriteLine("What is the Project Name?");
       string name = Console.ReadLine();

       Console.WriteLine("What is the due date of the project?");
       string date = Console.ReadLine();

       Task task = new Task
       {
        project = name,
        dueDate = date
       };
    }
    ticketList.Add(ticket);
    }
        
    
    else if (choice == "2")
 {
        foreach(Ticket ticket in ticketList){
            
            Console.WriteLine(ticket.Display());
        }
    }
} while (choice == "1" || choice == "2");

//logger.Info("Program ended");
