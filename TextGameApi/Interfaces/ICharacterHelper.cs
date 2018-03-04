using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGameApi.Models;

namespace TextGameApi
{
    public interface ICharacterHelper
    {
        Character GetCharacterById(int id);
        IQueryable<Character> GetCharacters();
    }
}
