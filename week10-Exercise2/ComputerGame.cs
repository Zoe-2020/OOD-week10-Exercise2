using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace week10_Exercise2
{
    public class ComputerGame
    {
        public int ComputerGameID { get; set; }
        public string ComputerGameName { get; set; }

        public string ReleaseDate { get; set; }


        public virtual List<Character> Characters { get; set; }
    }

    public class Character
    {

        public int CharacterID { get; set; }
        public string Name { get; set; }

        public string characterImage { get; set; }

        public int ComputerGameID { get; set; }
        public virtual ComputerGame ComputerGame { get; set; }

    }

    public class ComputerGameData : DbContext
    {
        public ComputerGameData() : base("MyComputerGameData") { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<ComputerGame> ComputerGames { get; set; }
    }

}
    

