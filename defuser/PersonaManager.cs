using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defuser
{
    class Persona
    {
        public Persona(
            string name,
            int level,
            Arcanum arcanum,
            bool isMaterial = true,
            bool isSpecialFusion = false)
        {
            Name = name;
            Level = level;
            Arcana = arcanum;
            IsMaterial = isMaterial;
            IsSpecialFusion = isSpecialFusion;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsMaterial { get; set; }
        public bool IsSpecialFusion { get; set; }
        public Arcanum Arcana { get; set; }
        public Dictionary<string, int> Skills { get; set; }
        public List<List<string>> FusionRecipes { get; set; }
    }

    class PersonaManager
    {
        Dictionary<string, Persona> personas;

        public void Init()
        {
            personas = new Dictionary<string, Persona>();
            Arcanum a;
            Persona p;

            #region Arcanum.Fool
            a = Arcanum.Fool;

            p = new Persona("Izanagi", 1, a);
            personas.Add(p.Name, p);

            p = new Persona("Yomotsu-Shikome", 7, a);
            personas.Add(p.Name, p);

            p = new Persona("Obariyon", 13, a);
            personas.Add(p.Name, p);

            p = new Persona("Legion", 21, a);
            personas.Add(p.Name, p);

            p = new Persona("Ose", 31, a);
            personas.Add(p.Name, p);

            p = new Persona("Black Frost", 38, a, true, true);
            p.FusionRecipes = new List<List<string>>();
            p.FusionRecipes.Add(new List<string>());
            p.FusionRecipes[0].Add("Jack Frost");
            p.FusionRecipes[0].Add("Pyro Jack");
            p.FusionRecipes[0].Add("King Frost");
            p.FusionRecipes[0].Add("Pixie");
            p.FusionRecipes[0].Add("Ghoul");
            personas.Add(p.Name, p);

            p = new Persona("Decarabia", 46, a);
            personas.Add(p.Name, p);

            p = new Persona("Shiki-Ouji", 56, a);
            personas.Add(p.Name, p);

            p = new Persona("Loki", 64, a, true, true);
            //p.FusionRecipes = new List<List<string>>();
            //p.FusionRecipes.Add(new List<string>());
            //p.FusionRecipes[0].Add("Decarabia");
            //p.FusionRecipes[0].Add("Nidhoggr");
            //p.FusionRecipes[0].Add("Mother Harlot");
            //p.FusionRecipes.Add(new List<string>());
            //p.FusionRecipes[1].Add("Ishtar");
            //p.FusionRecipes[1].Add("Isis");
            //p.FusionRecipes[1].Add("Horus");
            //p.FusionRecipes.Add(new List<string>());
            //p.FusionRecipes[2].Add("Ishtar");
            //p.FusionRecipes[2].Add("Shiki-Ouji");
            //p.FusionRecipes[2].Add("Vasuki");
            //p.FusionRecipes.Add(new List<string>());
            //p.FusionRecipes[3].Add("Trumpeter");
            //p.FusionRecipes[3].Add("Black Frost");
            //p.FusionRecipes[3].Add("Byakko");
            personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Magician
            a = Arcanum.Magician;

            p = new Persona("Pixie", 2, a);
            personas.Add(p.Name, p);

            p = new Persona("Orobas", 8, a);
            personas.Add(p.Name, p);

            p = new Persona("Jack Frost", 16, a);
            personas.Add(p.Name, p);

            p = new Persona("Hua Po", 25, a);
            personas.Add(p.Name, p);

            p = new Persona("Pyro Jack", 32, a);
            personas.Add(p.Name, p);

            p = new Persona("Dis", 39, a);
            personas.Add(p.Name, p);

            p = new Persona("Rangda", 47, a);
            personas.Add(p.Name, p);

            p = new Persona("Jinn", 62, a);
            personas.Add(p.Name, p);

            p = new Persona("Surt", 69, a);
            personas.Add(p.Name, p);

            p = new Persona("Mada", 78, a, true, true);
            personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Priestess
            a = Arcanum.Priestess;

            p = new Persona("Saki Mitama", 11, a);
            personas.Add(p.Name, p);

            p = new Persona("Sarasvati", 17, a);
            personas.Add(p.Name, p);

            p = new Persona("High Pixie", 0, a);
            personas.Add(p.Name, p);

            p = new Persona("Ganga", 29, a);
            personas.Add(p.Name, p);

            p = new Persona("Parvati", 37, a);
            personas.Add(p.Name, p);

            p = new Persona("Kikuri-Hime", 48, a);
            personas.Add(p.Name, p);

            p = new Persona("Hariti", 59, a);
            personas.Add(p.Name, p);

            p = new Persona("Tzitzimitl", 70, a);
            personas.Add(p.Name, p);

            p = new Persona("Scathach", 79, a, true, true);
            personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Empress
            a = Arcanum.Empress;

            p = new Persona("Senri", 9, a);
            personas.Add(p.Name, p);

            p = new Persona("Yaksini", 18, a);
            personas.Add(p.Name, p);

            p = new Persona("Titania", 26, a);
            personas.Add(p.Name, p);

            p = new Persona("Gorgon", 34, a);
            personas.Add(p.Name, p);

            p = new Persona("Gabriel", 44, a);
            personas.Add(p.Name, p);

            p = new Persona("Skadi", 52, a);
            personas.Add(p.Name, p);

            p = new Persona("Mother Harlot", 60, a);
            personas.Add(p.Name, p);

            p = new Persona("Alilat", 70, a);
            personas.Add(p.Name, p);

            p = new Persona("Isis", 79, a, true, true);
            personas.Add(p.Name, p);

            #endregion

            p = new Persona("", 0, a);
            personas.Add(p.Name, p);

            p = new Persona("", 0, a);
            personas.Add(p.Name, p);

            #region Arcanum.Emperor
            a = Arcanum.Emperor;

            #endregion

        }
    }

    enum Arcanum
    {
        World = -1,
        Fool = 0,
        Magician = 1,
        Priestess = 2,
        Empress = 3,
        Emperor = 4,
        Hierophant = 5,
        Lovers = 6,
        Chariot = 7,
        Justice = 8,
        Hermit = 9,
        Fortune = 10,
        Strength = 11,
        Hanged = 12,
        Death = 13,
        Temperance = 14,
        Devil = 15,
        Tower = 16,
        Star = 17,
        Moon = 18,
        Sun = 19,
        Judgement = 20,
        Jester = 21,
        Aeon = 22,
    }
}
