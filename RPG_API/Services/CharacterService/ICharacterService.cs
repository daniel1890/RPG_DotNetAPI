using RPG_API.DTOs.Character;
using RPG_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_API.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<GetCharacterDTO>> GetAllCharacters();

        Task<GetCharacterDTO> GetCharacterById(int id);

        Task<List<GetCharacterDTO>> AddCharacter(AddCharacterDTO newCharacter);
    }
}