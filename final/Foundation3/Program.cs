using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak Ave", "Sometown", "NY", "USA");

        // Create events
        Event event1 = new Lecture("Python Basics", "Introduction to Python programming", "2024-04-10", "10:00 AM", address1, "John Doe", 50);
        Event event2 = new Reception("Networking Mixer", "Join us for a networking event", "2024-04-15", "6:00 PM", address2, "rsvp@example.com");
        Event event3 = new OutdoorGathering("Picnic in the Park", "Enjoy a day in the park with food and games", "2024-04-20", "12:00 PM", address1);

        // Display marketing messages
        Console.WriteLine("Event 1:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(event1.GetShortDescription());

        Console.WriteLine("\nEvent 2:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(event2.GetShortDescription());

        Console.WriteLine("\nEvent 3:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(event3.GetShortDescription());
    }
}
