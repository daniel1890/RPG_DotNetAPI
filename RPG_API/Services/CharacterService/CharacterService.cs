using AutoMapper;
using RPG_API.DTOs.Character;
using RPG_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_API.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> _characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public async Task<List<GetCharacterDTO>> AddCharacter(AddCharacterDTO newCharacter)
        {
            _characters.Add(_mapper.Map<Character>(newCharacter));
            return _characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
        }

        public async Task<List<GetCharacterDTO>> GetAllCharacters()
        {
            return _characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
        }

        public async Task<GetCharacterDTO> GetCharacterById(int id)
        {
            return _mapper.Map<GetCharacterDTO>(_characters.FirstOrDefault(c => c.Id == id));
        }
    }
}