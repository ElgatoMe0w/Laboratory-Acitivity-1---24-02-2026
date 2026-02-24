using System;

class Song
{
    // Fields
    private string title;
    private string artist;
    private double duration;

    // Simple Constructor
    public Song(string t, string a, double d)
    {
        title = t;
        artist = a;
        duration = d;
    }

    public double GetDuration()
    {
        return duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1,-15} {2,6:F2}", title, artist, duration);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int n = int.Parse(Console.ReadLine());

        Song[] playlist = new Song[n];

        double total = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nSong #{0}", i + 1);

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            double duration = double.Parse(Console.ReadLine());

            playlist[i] = new Song(title, artist, duration);

            total += duration;
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20} {1,-15} {2,6}", "Title", "Artist", "Time");
        Console.WriteLine("-----------------------------------------------------");

        for (int i = 0; i < n; i++)
        {
            playlist[i].DisplaySong();
        }

        double average = total / n;

        Console.WriteLine("\nTotal Duration: {0:F2} mins", total);
        Console.WriteLine("Average Duration: {0:F2} mins", average);
    }
}
