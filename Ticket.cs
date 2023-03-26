public class Ticket
{
    public int ticketId { get; set; }
    public string summary { get; set; }
    public string status { get; set; }
    public string priority { get; set; }
    public string owner { get; set; }
    public string assign { get; set; }
    public string watch { get; set; }

    public string Display()
    {
        return $"Id: {ticketId}\nSummary: {summary}\nStatus: {status}\nPriority: {priority}\nSubmitted by: {owner}\nAssigned to: {assign}\nWatched by: {watch}\n";
    }
}

