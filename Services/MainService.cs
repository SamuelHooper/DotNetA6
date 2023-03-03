using DotNetA6.Models;

namespace ApplicationTemplate.Services
{
    public class MainService : IMainService
    {

        // Main Program code goes here
        public void Invoke()
        {
            MediaContext mediaContext = new();
            List<Media> mediaList = new();
            string menuOption;

            do
            {
                Console.WriteLine("\nSelect a media type to display:");
                Console.WriteLine("1. Movies");
                Console.WriteLine("2. Shows");
                Console.WriteLine("3. Videos");
                Console.WriteLine("Enter any other key to exit.\n");
                menuOption = Console.ReadLine();

                if (menuOption == "1")
                {
                    mediaList = mediaContext.Movies;
                } else if (menuOption == "2")
                {
                    mediaList = mediaContext.Shows;
                } else if (menuOption == "3")
                {
                    mediaList = mediaContext.Videos;
                }

                Console.WriteLine(); // Spacer line

                foreach (Media media in mediaList)
                {
                    Console.WriteLine(media.Display());
                }
            } while (menuOption == "1" || menuOption == "2" || menuOption == "3");
        }
    }
}