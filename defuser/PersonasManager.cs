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

        public override string ToString()
        {
            return string.Format("{0} : {1:D2}", Name, Level);
        }
    }

    class PersonasManager
    {
        public Dictionary<string, Persona> Personas { get; set; }
        FusionsManager fm;
        Fusions fusions;

        public PersonasManager()
        {
            this.Init();
            fm = new FusionsManager();
            fusions = fm.Fusions;
        }

        void Init()
        {
            Personas = new Dictionary<string, Persona>();
            Arcanum a;
            Persona p;

            #region Arcanum.Fool
            a = Arcanum.Fool;

            p = new Persona("Izanagi", 1, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yomotsu-Shikome", 7, a);
            Personas.Add(p.Name, p);

            p = new Persona("Obariyon", 13, a);
            Personas.Add(p.Name, p);

            p = new Persona("Legion", 21, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ose", 31, a);
            Personas.Add(p.Name, p);

            p = new Persona("Black Frost", 38, a, true, true);
            p.FusionRecipes = new List<List<string>>();
            p.FusionRecipes.Add(new List<string>());
            p.FusionRecipes[0].Add("Jack Frost");
            p.FusionRecipes[0].Add("Pyro Jack");
            p.FusionRecipes[0].Add("King Frost");
            p.FusionRecipes[0].Add("Pixie");
            p.FusionRecipes[0].Add("Ghoul");
            Personas.Add(p.Name, p);

            p = new Persona("Decarabia", 46, a);
            Personas.Add(p.Name, p);

            p = new Persona("Shiki-Ouji", 56, a);
            Personas.Add(p.Name, p);

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
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Magician
            a = Arcanum.Magician;

            p = new Persona("Pixie", 2, a);
            Personas.Add(p.Name, p);

            p = new Persona("Orobas", 8, a);
            Personas.Add(p.Name, p);

            p = new Persona("Jack Frost", 16, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hua Po", 25, a);
            Personas.Add(p.Name, p);

            p = new Persona("Pyro Jack", 32, a);
            Personas.Add(p.Name, p);

            p = new Persona("Dis", 39, a);
            Personas.Add(p.Name, p);

            p = new Persona("Rangda", 47, a);
            Personas.Add(p.Name, p);

            p = new Persona("Jinn", 62, a);
            Personas.Add(p.Name, p);

            p = new Persona("Surt", 69, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mada", 78, a, true, true);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Priestess
            a = Arcanum.Priestess;

            p = new Persona("Saki Mitama", 11, a);
            Personas.Add(p.Name, p);

            p = new Persona("Sarasvati", 17, a);
            Personas.Add(p.Name, p);

            p = new Persona("High Pixie", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ganga", 29, a);
            Personas.Add(p.Name, p);

            p = new Persona("Parvati", 37, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kikuri-Hime", 48, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hariti", 59, a);
            Personas.Add(p.Name, p);

            p = new Persona("Tzitzimitl", 70, a);
            Personas.Add(p.Name, p);

            p = new Persona("Scathach", 79, a, true, true);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Empress
            a = Arcanum.Empress;

            p = new Persona("Senri", 9, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yaksini", 18, a);
            Personas.Add(p.Name, p);

            p = new Persona("Titania", 26, a);
            Personas.Add(p.Name, p);

            p = new Persona("Gorgon", 34, a);
            Personas.Add(p.Name, p);

            p = new Persona("Gabriel", 44, a);
            Personas.Add(p.Name, p);

            p = new Persona("Skadi", 52, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mother Harlot", 60, a);
            Personas.Add(p.Name, p);

            p = new Persona("Alilat", 70, a);
            Personas.Add(p.Name, p);

            p = new Persona("Isis", 79, a, true, true);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Emperor
            a = Arcanum.Emperor;

            p = new Persona("Oberon", 12, a);
            Personas.Add(p.Name, p);

            p = new Persona("King Frost", 22, a);
            Personas.Add(p.Name, p);

            p = new Persona("Setanta", 34, a);
            Personas.Add(p.Name, p);

            p = new Persona("Okuninushi", 41, a);
            Personas.Add(p.Name, p);

            p = new Persona("Thoth", 45, a);
            Personas.Add(p.Name, p);

            p = new Persona("Pabilsag", 51, a);
            Personas.Add(p.Name, p);

            p = new Persona("Barong", 65, a);
            Personas.Add(p.Name, p);

            p = new Persona("Odin", 74, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Hierophant
            a = Arcanum.Hierophant;

            p = new Persona("Omoikane", 7, a);
            Personas.Add(p.Name, p);

            p = new Persona("Anzu", 15, a);
            Personas.Add(p.Name, p);

            p = new Persona("Shiisaa", 21, a);
            Personas.Add(p.Name, p);

            p = new Persona("Unicorn", 29, a);
            Personas.Add(p.Name, p);

            p = new Persona("Flauros", 36, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hokuto Seikun", 45, a);
            Personas.Add(p.Name, p);

            p = new Persona("Cerberus", 52, a);
            Personas.Add(p.Name, p);

            p = new Persona("Daisoujou", 60, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hachiman", 70, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kohryu", 76, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Lovers
            a = Arcanum.Lovers;

            p = new Persona("Queen Mab", 25, a);
            Personas.Add(p.Name, p);

            p = new Persona("Undine", 33, a);
            Personas.Add(p.Name, p);

            p = new Persona("Leanan Sidhe", 42, a);
            Personas.Add(p.Name, p);

            p = new Persona("Raphael", 53, a);
            Personas.Add(p.Name, p);

            p = new Persona("Cybele", 64, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ishtar", 71, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Chariot
            a = Arcanum.Chariot;

            p = new Persona("Slime", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Nata Taishi", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Eligor", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ara Mitama", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ares", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Triglav", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kin-Ki", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Thor", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Atavaka", 0, a);
            Personas.Add(p.Name, p);

            p = new Persona("Futsunushi", 0, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Justice
            a = Arcanum.Justice;

            p = new Persona("Angel", 4, a);
            Personas.Add(p.Name, p);

            p = new Persona("Archangel", 11, a);
            Personas.Add(p.Name, p);

            p = new Persona("Principality", 19, a);
            Personas.Add(p.Name, p);

            p = new Persona("Power", 27, a);
            Personas.Add(p.Name, p);

            p = new Persona("Virtue", 33, a);
            Personas.Add(p.Name, p);

            p = new Persona("Dominion", 38, a);
            Personas.Add(p.Name, p);

            p = new Persona("Throne", 49, a);
            Personas.Add(p.Name, p);

            p = new Persona("Uriel", 58, a);
            Personas.Add(p.Name, p);

            p = new Persona("Melchizedek", 66, a);
            Personas.Add(p.Name, p);

            p = new Persona("Sraosha", 74, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Hermit
            a = Arcanum.Hermit;

            p = new Persona("Forneus", 6, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ippon-Datara", 17, a);
            Personas.Add(p.Name, p);

            p = new Persona("Lamia", 26, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mothman", 33, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hitokotonushi", 41, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kurama Tengu", 48, a);
            Personas.Add(p.Name, p);

            p = new Persona("Nidhoggr", 55, a);
            Personas.Add(p.Name, p);

            p = new Persona("Nebiros", 63, a);
            Personas.Add(p.Name, p);

            p = new Persona("Arahabaki", 73, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ongyo-Ki", 82, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Fortune
            a = Arcanum.Fortune;

            p = new Persona("Fortuna", 35, a);
            Personas.Add(p.Name, p);

            p = new Persona("Clotho", 44, a);
            Personas.Add(p.Name, p);

            p = new Persona("Lachesis", 51, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ananta", 58, a);
            Personas.Add(p.Name, p);

            p = new Persona("Atropos", 65, a);
            Personas.Add(p.Name, p);

            p = new Persona("Norn", 72, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Strength
            a = Arcanum.Strength;

            p = new Persona("Sandman", 5, a);
            Personas.Add(p.Name, p);

            p = new Persona("Valkyrie", 8, a);
            Personas.Add(p.Name, p);

            p = new Persona("Titan", 14, a);
            Personas.Add(p.Name, p);

            p = new Persona("Rakshasa", 23, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kusi Mitama", 28, a);
            Personas.Add(p.Name, p);

            p = new Persona("Oni", 30, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hanuman", 42, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kali", 50, a);
            Personas.Add(p.Name, p);

            p = new Persona("Siegfried", 63, a);
            Personas.Add(p.Name, p);

            p = new Persona("Zaou Gongen", 90, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Hanged
            a = Arcanum.Hanged;

            p = new Persona("Berith", 15, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yomotsu-Ikusa", 22, a);
            Personas.Add(p.Name, p);

            p = new Persona("Makami", 27, a);
            Personas.Add(p.Name, p);

            p = new Persona("Orthrus", 39, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yatsufusa", 49, a);
            Personas.Add(p.Name, p);

            p = new Persona("Taowu", 56, a);
            Personas.Add(p.Name, p);

            p = new Persona("Hell Biker", 66, a);
            Personas.Add(p.Name, p);

            p = new Persona("Vasuki", 71, a);
            Personas.Add(p.Name, p);

            p = new Persona("Attis", 82, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Death
            a = Arcanum.Death;

            p = new Persona("Ghoul", 9, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mokoi", 14, a);
            Personas.Add(p.Name, p);

            p = new Persona("Matador", 24, a);
            Personas.Add(p.Name, p);

            p = new Persona("Samael", 36, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mot", 46, a);
            Personas.Add(p.Name, p);

            p = new Persona("White Rider", 58, a);
            Personas.Add(p.Name, p);

            p = new Persona("Alice", 72, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mahakala", 78, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Temperance
            a = Arcanum.Temperance;

            p = new Persona("Apsaras", 4, a);
            Personas.Add(p.Name, p);

            p = new Persona("Sylph", 11, a);
            Personas.Add(p.Name, p);

            p = new Persona("Xiezhai", 16, a);
            Personas.Add(p.Name, p);

            p = new Persona("Nigi Mitama", 23, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mithra", 31, a);
            Personas.Add(p.Name, p);

            p = new Persona("Genbu", 40, a);
            Personas.Add(p.Name, p);

            p = new Persona("Seiryuu", 47, a);
            Personas.Add(p.Name, p);

            p = new Persona("Suzaku", 54, a);
            Personas.Add(p.Name, p);

            p = new Persona("Byakko", 62, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yurlungur", 69, a);
            Personas.Add(p.Name, p);

            p = new Persona("Vishnu", 73, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Devil
            a = Arcanum.Devil;

            p = new Persona("Ukobach", 3, a);
            Personas.Add(p.Name, p);

            p = new Persona("Lilim", 10, a);
            Personas.Add(p.Name, p);

            p = new Persona("Vetala", 19, a);
            Personas.Add(p.Name, p);

            p = new Persona("Incubus", 28, a);
            Personas.Add(p.Name, p);

            p = new Persona("Pazuzu", 37, a);
            Personas.Add(p.Name, p);

            p = new Persona("Succubus", 44, a);
            Personas.Add(p.Name, p);

            p = new Persona("Lilith", 53, a);
            Personas.Add(p.Name, p);

            p = new Persona("Belphegor", 61, a);
            Personas.Add(p.Name, p);

            p = new Persona("Belial", 68, a);
            Personas.Add(p.Name, p);

            p = new Persona("Beelzebub", 81, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Tower
            a = Arcanum.Tower;

            p = new Persona("Tao Tie", 35, a);
            Personas.Add(p.Name, p);

            p = new Persona("Cu Chulainn", 46, a);
            Personas.Add(p.Name, p);

            p = new Persona("Abaddon", 55, a);
            Personas.Add(p.Name, p);

            p = new Persona("Mara", 62, a);
            Personas.Add(p.Name, p);

            p = new Persona("Masakado", 69, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yoshitsune", 75, a);
            Personas.Add(p.Name, p);

            p = new Persona("Shiva", 80, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Star
            a = Arcanum.Star;

            p = new Persona("Kaiwan", 24, a);
            Personas.Add(p.Name, p);

            p = new Persona("Neko Shogun", 32, a);
            Personas.Add(p.Name, p);

            p = new Persona("Fuu-Ki", 43, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ganesha", 50, a);
            Personas.Add(p.Name, p);

            p = new Persona("Garuda", 57, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kartikeya", 67, a);
            Personas.Add(p.Name, p);

            p = new Persona("Saturnus", 75, a);
            Personas.Add(p.Name, p);

            p = new Persona("Helel", 87, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Moon
            a = Arcanum.Moon;

            p = new Persona("Andra", 20, a);
            Personas.Add(p.Name, p);

            p = new Persona("Nozuchi", 27, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yamata-no-Orochi", 34, a);
            Personas.Add(p.Name, p);

            p = new Persona("Alraune", 41, a);
            Personas.Add(p.Name, p);

            p = new Persona("Girimehkala", 48, a);
            Personas.Add(p.Name, p);

            p = new Persona("Sui-Ki", 57, a);
            Personas.Add(p.Name, p);

            p = new Persona("Seth", 68, a);
            Personas.Add(p.Name, p);

            p = new Persona("Baal Zebul", 77, a);
            Personas.Add(p.Name, p);

            p = new Persona("Sandalphon", 84, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Sun
            a = Arcanum.Sun;

            p = new Persona("Cu Sith", 10, a);
            Personas.Add(p.Name, p);

            p = new Persona("Phoenix", 20, a);
            Personas.Add(p.Name, p);

            p = new Persona("Gdon", 31, a);
            Personas.Add(p.Name, p);

            p = new Persona("Yatagarasu", 40, a);
            Personas.Add(p.Name, p);

            p = new Persona("Narasimha", 47, a);
            Personas.Add(p.Name, p);

            p = new Persona("Tam Lin", 53, a);
            Personas.Add(p.Name, p);

            p = new Persona("Jatayu", 61, a);
            Personas.Add(p.Name, p);

            p = new Persona("Horus", 68, a);
            Personas.Add(p.Name, p);

            p = new Persona("Suparna", 77, a);
            Personas.Add(p.Name, p);

            p = new Persona("Asura", 86, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Judgement
            a = Arcanum.Judgement;

            p = new Persona("Anubis", 59, a);
            Personas.Add(p.Name, p);

            p = new Persona("Trumpeter", 67, a);
            Personas.Add(p.Name, p);

            p = new Persona("Michael", 72, a);
            Personas.Add(p.Name, p);

            p = new Persona("Satan", 76, a);
            Personas.Add(p.Name, p);

            p = new Persona("Metatron", 83, a);
            Personas.Add(p.Name, p);

            p = new Persona("Ardha", 90, a);
            Personas.Add(p.Name, p);

            p = new Persona("Lucifer", 93, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Jester
            a = Arcanum.Jester;

            p = new Persona("Gurr", 20, a);
            Personas.Add(p.Name, p);

            p = new Persona("Take-Minakata", 27, a);
            Personas.Add(p.Name, p);

            p = new Persona("Pale Rider", 34, a);
            Personas.Add(p.Name, p);

            p = new Persona("Loa", 40, a);
            Personas.Add(p.Name, p);

            p = new Persona("Baphomet", 47, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kumbhanda", 55, a);
            Personas.Add(p.Name, p);

            p = new Persona("Chernobog", 62, a);
            Personas.Add(p.Name, p);

            p = new Persona("Seiten Taisei", 68, a);
            Personas.Add(p.Name, p);

            p = new Persona("Magatsu-Izanagi", 77, a);
            Personas.Add(p.Name, p);

            #endregion

            #region Arcanum.Aeon
            a = Arcanum.Aeon;

            p = new Persona("Ame-No-Uzume", 18, a);
            Personas.Add(p.Name, p);

            p = new Persona("Narcissus", 24, a);
            Personas.Add(p.Name, p);

            p = new Persona("Sati", 31, a);
            Personas.Add(p.Name, p);

            p = new Persona("Raja Naga", 37, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kushinada-Hime", 44, a);
            Personas.Add(p.Name, p);

            p = new Persona("Quetzalcoatl", 51, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kingu", 58, a);
            Personas.Add(p.Name, p);

            p = new Persona("Lakshmi", 65, a);
            Personas.Add(p.Name, p);

            p = new Persona("Kaguya", 74, a);
            Personas.Add(p.Name, p);

            #endregion

        }

        public Persona Fusion(Persona p1, Persona p2)
        {
            Arcanum a1 = p1.Arcana;
            int l1 = p1.Level;

            Arcanum a2 = p2.Arcana;
            int l2 = p2.Level;

            int avg = ((l1 + l2) / 2) + 1;

            Arcanum? arcanaresult = fm.Fusion(a1, a2);
            if (!arcanaresult.HasValue) return null;

            var query = from p in Personas
                        where p.Value.Arcana == arcanaresult.Value
                        select p.Value;

            foreach (var item in query)
            {
                if (item.Level >= avg) return item;
            }

            return null;
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
