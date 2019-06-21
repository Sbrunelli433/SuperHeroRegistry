using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperHeroRegistryProject.Models
{
    public class SuperHero
    {
        public int Id { get; set; }

        public string  Name { get; set; }
        public string AlterEgoName { get; set; }
        public string PrimaryAblity{ get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase{ get; set; }

    }
}