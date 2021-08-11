using System;
using System.Collections.Generic;

namespace GameApi.Models{
    public class Game : IEquatable<Game>{
        public int Id {get;set;}
        public string Title {get;set;}
        public string Platform {get;set;}
        public int Price {get;set;}
        public string Description {get;set;}
        public string Released {get;set;} //DateTime
        public List<string> Category {get;set;}

        public bool Equals(Game game)
        {
            return this.Id == game.Id;
        }
    }

}