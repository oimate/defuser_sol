using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defuser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona p;
            //personas = new Dictionary<string, Persona>();

            //p = new Persona();
            //p.Arcana = Arcanum.Fool;
            //p.IsMaterial = true;
            //p.IsSpecialFusion = false;
            //p.Level = 1;
            //p.Skills = new Dictionary<string, int>();
            //p.Skills.Add("Zio", 0);
            //p.Skills.Add("Cleave", 0);
            //p.Skills.Add("Rakukaja", 0);
            //p.Skills.Add("Rakunda", 3);
            //p.Skills.Add("Tarukaja", 5);
            //personas.Add("Izanagi", p);
            //System.Diagnostics.Debug.WriteLine(s);

            //p = new Persona();
            //p.Arcana = Arcanum.Magician;
            //p.IsMaterial = true;
            //p.IsSpecialFusion = true;
            //p.Level = 38;
            //p.Skills = new Dictionary<string, int>();
            //p.Skills.Add("Maragion", 0);
            //p.Skills.Add("Bufula", 0);
            //p.Skills.Add("Ice Boost", 0);
            //p.Skills.Add("Mind Charge", 40);
            //p.Skills.Add("Masukunda", 41);
            //p.Skills.Add("Fire Amp", 42);
            //p.Skills.Add("Agidyne", 43);
            //p.Skills.Add("Mudoon", 44);
            //p.FusionRecipes = new List<List<string>>();
            //p.FusionRecipes.Add(new List<string>());
            //p.FusionRecipes[0].Add("Jack Frost");
            //p.FusionRecipes[0].Add("Pyro Jack");
            //p.FusionRecipes[0].Add("King Frost");
            //p.FusionRecipes[0].Add("Pixie");
            //p.FusionRecipes[0].Add("Ghoul");
            //p.FusionRecipes.Add(new List<string>());
            //p.FusionRecipes[1].Add("persona1");
            //p.FusionRecipes[1].Add("persona2");
            //p.FusionRecipes[1].Add("persona3");
            //p.FusionRecipes[1].Add("persona4");
            //personas.Add("Black Frost", p);
            
            //s = Newtonsoft.Json.JsonConvert.SerializeObject(personas, Newtonsoft.Json.Formatting.Indented);
            //System.Diagnostics.Debug.WriteLine(s);

            PersonaManager pm = new PersonaManager();
            pm.Init();

            FusionsManager fm = new FusionsManager();
            Arcanum? ar1 = fm.Fusion(Arcanum.Magician, Arcanum.Fool);
            Arcanum? ar2 = fm.Fusion(Arcanum.Lovers, Arcanum.Fool, Arcanum.Hanged);

            Console.ReadKey();
        }
    }
}
