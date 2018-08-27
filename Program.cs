using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a List, named goodSongs, that will hold tuples consisting of two strings.
                List <(string artist,string song)> goodSongs = new List <(string,string)>();
            // Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
                HashSet<(string artist, string song)> allSongs = new HashSet <(string,string)>();
            // The name of an artist
            // A song by that artist
            // // Example
            // HashSet<(string, string)> songs = new HashSet<(string, string)>();
            // Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.
                allSongs.Add(("NickleBack","How You Remind Me"));
                allSongs.Add(("NickleBack","Rockstar"));
                allSongs.Add(("NickleBack","Savin' Me"));
                allSongs.Add(("Train","Drops of Jupiter"));
                allSongs.Add(("Radiohead","Creep"));
                allSongs.Add(("Rage Against the Machine","Killing in the Name"));
                allSongs.Add(("Rolling Stones","Paint it Black"));
            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
                foreach (var item in allSongs)
                {
            // If the band is not Nickelback, then add it to the goodSongs list.
                    if(item.artist != "NickleBack"){
                        goodSongs.Add(item);
                    }
                    
                }

            // USe another foreach loop to print out all the good songs.
            foreach (var item in goodSongs)
            {
                
            Console.WriteLine("good songs"  + $" {item.song} by {item.artist}");
            }
        }
    }
}
