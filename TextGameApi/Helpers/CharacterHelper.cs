using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TextGameApi.Models;

namespace TextGameApi.Helpers
{
    public class CharacterHelper : ICharacterHelper
    {
        private TextGameEntities db = new TextGameEntities();
        public Character GetCharacterById(int id)
        {
            //find out if it is possible to have entity framework do this for me
            var character = db.Characters
                    .Where(c => c.CharacterId == id)
                    .Include(c => c.Level)
                    .Include(c => c.Inventories)
                    .Include(c => c.Location)
                    .FirstOrDefault();

            return character;
        }

        public IQueryable<Character> GetCharacters()
        {
            return db.Characters;

        }
    }
}