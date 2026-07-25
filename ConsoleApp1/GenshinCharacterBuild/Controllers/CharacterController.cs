using GenshinCharacterBuild.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenshinCharacterBuild.Controllers
{
    // This attribute secures all actions inside this controller
    [Authorize]
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            var characters = GetCharacters();
            return View(characters);
        }

        // Mock data method - replace this with database queries later
        private List<Character> GetCharacters()
        {
            return new List<Character>
            {
                // Main DPS
                new Character { Id = 1, Name = "Arlecchino", Role = "Main DPS", Element = "Pyro", BestWeapon = "Crimson Moon's Semblance", BestArtifact = "Fragment of Harmonic Whimsy" },
                new Character { Id = 2, Name = "Neuvillette", Role = "Main DPS", Element = "Hydro", BestWeapon = "Tome of the Eternal Flow", BestArtifact = "Marechaussee Hunter" },
                new Character { Id = 3, Name = "Mavuika", Role = "Main DPS", Element = "Pyro", BestWeapon = "A Thousand Blazing Suns", BestArtifact = "Obsidian Codex" },
                new Character { Id = 4, Name = "Alhaitham", Role = "Main DPS", Element = "Dendro", BestWeapon = "Light of Foliar Incision", BestArtifact = "Gilded Dreams" },
                new Character { Id = 5, Name = "Hu Tao", Role = "Main DPS", Element = "Pyro", BestWeapon = "Staff of Homa", BestArtifact = "Crimson Witch of Flames" },
 
                // Sub-DPS
                new Character { Id = 6, Name = "Furina", Role = "Sub-DPS", Element = "Hydro", BestWeapon = "Splendor of Tranquil Waters", BestArtifact = "Golden Troupe" },
                new Character { Id = 7, Name = "Yelan", Role = "Sub-DPS", Element = "Hydro", BestWeapon = "Aqua Simulacra", BestArtifact = "Emblem of Severed Fate" },
                new Character { Id = 8, Name = "Citlali", Role = "Sub-DPS", Element = "Cryo", BestWeapon = "Astral Vulture's Feather", BestArtifact = "Scroll of the Hero of Cinder City" },
                new Character { Id = 9, Name = "Xingqiu", Role = "Sub-DPS", Element = "Hydro", BestWeapon = "Sacrificial Sword", BestArtifact = "Emblem of Severed Fate" },
                new Character { Id = 10, Name = "Xiangling", Role = "Sub-DPS", Element = "Pyro", BestWeapon = "\"The Catch\"", BestArtifact = "Emblem of Severed Fate" },
 
                // Support
                new Character { Id = 11, Name = "Kaedehara Kazuha", Role = "Support", Element = "Anemo", BestWeapon = "Freedom-Sworn", BestArtifact = "Viridescent Venerer" },
                new Character { Id = 12, Name = "Bennett", Role = "Support", Element = "Pyro", BestWeapon = "Aquila Favonia", BestArtifact = "Noblesse Oblige" },
                new Character { Id = 13, Name = "Nahida", Role = "Support", Element = "Dendro", BestWeapon = "A Thousand Floating Dreams", BestArtifact = "Deepwood Memories" },
                new Character { Id = 14, Name = "Xilonen", Role = "Support", Element = "Geo", BestWeapon = "Peak Patrol Song", BestArtifact = "Scroll of the Hero of Cinder City" },
                new Character { Id = 15, Name = "Zhongli", Role = "Support", Element = "Geo", BestWeapon = "Black Tassel", BestArtifact = "Tenacity of the Millelith" }
            };
        }
    }
}