using System;

namespace Artists
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh";
            Console.WriteLine($"{message}");

            string newmessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            Console.WriteLine(newmessage);

            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                int indexOfSpace = artist.IndexOf(' ');
                msg2 = artist.ToUpper()[0] + artist.ToLower().Substring(1, indexOfSpace)
                + artist.ToUpper()[indexOfSpace + 1] + artist.ToLower().Substring(indexOfSpace + 2);
                Console.WriteLine(msg2);

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                string newArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1) + " " +
                                   lastName.ToUpper()[0] + lastName.ToLower().Substring(1);
                Console.WriteLine(newArtist);
                Console.WriteLine();
            }

        }
    }
}
