using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    internal class Songs
    {
        static void Main(string[] args)
        {
            int numOfReads = int.Parse(Console.ReadLine());

            List<MySongs> songList = new List<MySongs>();

            for (int i = 1; i <= numOfReads; i++)
            {
                string[] read = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToArray();

                MySongs song = new MySongs();

                song.TypeListing = read[0];
                song.Name = read[1];
                song.Time = read[2];

                songList.Add(song);

            }

            string typeList = Console.ReadLine();


            if (typeList != "all")
            {

                List<MySongs> filteredSongs = songList.Where(s => s.TypeListing == typeList).ToList();

                foreach (MySongs song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }

            }
            else
            {
                foreach (MySongs song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public class MySongs
    {
        public string TypeListing { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
