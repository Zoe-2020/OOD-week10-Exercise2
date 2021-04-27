using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week10_Exercise2;

namespace dataMangment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ComputerGameData db = new ComputerGameData();
            using (db)
            {

                ComputerGame g1 = new ComputerGame() { ComputerGameID = 1, ComputerGameName = "Animal Crossing: New Horizons" };
                ComputerGame g2 = new ComputerGame() { ComputerGameID = 2, ComputerGameName = "Final Fantasy VII" };

                Character c1 = new Character() { CharacterID = 1, Name = "Cloud Strife", ComputerGameID = 2, ComputerGame = g2, characterImage= "/images/Cloud_Strife.png" };
                Character c2 = new Character() { CharacterID = 2, Name = "Sephiroth", ComputerGameID = 2, ComputerGame = g2 , characterImage= "/images/Sephiroth.png" };
                Character c3 = new Character() { CharacterID = 3, Name = "Tom Nook", ComputerGameID = 1, ComputerGame = g1 , characterImage = "/images/Tom_Nook.png" };
                Character c4 = new Character() { CharacterID = 4, Name = "K.K. Slider", ComputerGameID = 1, ComputerGame = g1, characterImage= "/images/Kk_Slider.png" };

                db.ComputerGames.Add(g1);
                db.ComputerGames.Add(g2);
                Console.WriteLine("Added ComputerGames to db");
                db.Characters.Add(c1);
                db.Characters.Add(c2);
                db.Characters.Add(c3);
                db.Characters.Add(c4);
                Console.WriteLine("Added Characters to db");

                db.SaveChanges();
                Console.WriteLine("Saved to db");
            }
        }
    }
}
