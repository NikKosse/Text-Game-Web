using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextGameApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGameApi.Models;

namespace TextGameApi.Helpers.Tests
{
    [TestClass()]
    public class CharacterHelperTests
    {
        [TestMethod()]
        public void CalculateDynamicFieldsTest_WhereFieldsEqualToBaseValues_ReturnsUnchangedCharacter()
        {
            var testCharacter = new Character();
            //find out if it is possible to do 
        }

        private Character createTestCharacter()
        {

            Level level = CreateTestLevel();

            Location location = CreateTestLocation();

            Inventory inventory = CreateTestInventory();

            Character character = new Character() {

            };

            return character;
        }

        private Level CreateTestLevel()
        {
            Level level = new Level()
            {
                Level1 = 1,
                BaseHealth = 10,
                BaseMagic = 10,
                ExperienceRequired = 0,
                BaseHitChance = 10
            };

            return level;
        }

        private Location CreateTestLocation()
        {
            Location location = new Location()
            {
                LocationId = 0,
                Name = "camp",
                NPCMinLevel = 0,
                NPCMaxLevel = 1,
                Description = "testing"
            };

            return location;
        }

        private Inventory CreateTestInventory()
        {
            Inventory inventory = new Inventory() {
                Armor = null,
                ArmorEnchantment = null,
                Weapon = null,
                WeaponEnchantment = null,
                Spell = null,

            };

            return inventory;
        }
    }
}