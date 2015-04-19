using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defuser
{
    class Fusion
    {
        Dictionary<Arcanum, Arcanum?> rule = new Dictionary<Arcanum, Arcanum?>();

        public Dictionary<Arcanum, Arcanum?> Rule
        {
            get { return rule; }
            set { rule = value; }
        }

        public Arcanum? this[Arcanum key]
        {
            get
            {
                if (rule.ContainsKey(key))
                    return rule[key];
                else
                    return null;
            }
            set
            {
                if (rule.ContainsKey(key))
                    rule[key] = value;
            }
        }
    }

    class Fusions
    {
        Dictionary<Arcanum, Fusion> fusionSet = new Dictionary<Arcanum, Fusion>();

        public Dictionary<Arcanum, Fusion> FusionSet
        {
            get { return fusionSet; }
            set { fusionSet = value; }
        }

        public Fusion this[Arcanum key]
        {
            get
            {
                if (fusionSet.ContainsKey(key))
                    return fusionSet[key];
                else
                    return null;
            }
            set
            {

                if (fusionSet.ContainsKey(key))
                    fusionSet[key] = value;
            }
        }
    }

    class FusionsManager
    {
        Fusions fusions;

        public FusionsManager()
        {
            if (!this.Init()) throw new Exception("Initialization of FusionsManager");
        }

        bool Init()
        {
            fusions = new Fusions();

            var enumerated = Enum.GetValues(typeof(Arcanum));

            foreach (Arcanum arcana in enumerated)
            {
                if (arcana == Arcanum.World) continue;
                fusions.FusionSet.Add(arcana, new Fusion());
                foreach (Arcanum arcana2 in enumerated)
                {
                    if (arcana2 == Arcanum.World) continue;
                    fusions[arcana].Rule.Add(arcana2, null);
                }
            }

            #region Example
            //fusions[Arcanum.Fool].Create(
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,
            //    Arcanum.,);
            #endregion

            #region Arcanum.Fool
            fusions[Arcanum.Fool][Arcanum.Fool] = Arcanum.Fool;
            fusions[Arcanum.Fool][Arcanum.Magician] = Arcanum.Temperance;
            fusions[Arcanum.Fool][Arcanum.Priestess] = Arcanum.Death;
            fusions[Arcanum.Fool][Arcanum.Empress] = Arcanum.Moon;
            fusions[Arcanum.Fool][Arcanum.Emperor] = Arcanum.Death;
            fusions[Arcanum.Fool][Arcanum.Hierophant] = Arcanum.Chariot;
            fusions[Arcanum.Fool][Arcanum.Lovers] = Arcanum.Empress;
            fusions[Arcanum.Fool][Arcanum.Chariot] = Arcanum.Sun;
            fusions[Arcanum.Fool][Arcanum.Justice] = Arcanum.Magician;
            fusions[Arcanum.Fool][Arcanum.Hermit] = Arcanum.Strength;
            fusions[Arcanum.Fool][Arcanum.Fortune] = Arcanum.Magician;
            fusions[Arcanum.Fool][Arcanum.Strength] = Arcanum.Magician;
            fusions[Arcanum.Fool][Arcanum.Hanged] = Arcanum.Strength;
            fusions[Arcanum.Fool][Arcanum.Death] = Arcanum.Hermit;
            fusions[Arcanum.Fool][Arcanum.Temperance] = Arcanum.Hierophant;
            fusions[Arcanum.Fool][Arcanum.Devil] = Arcanum.Temperance;
            fusions[Arcanum.Fool][Arcanum.Tower] = Arcanum.Star;
            fusions[Arcanum.Fool][Arcanum.Star] = Arcanum.Empress;
            fusions[Arcanum.Fool][Arcanum.Moon] = Arcanum.Emperor;
            fusions[Arcanum.Fool][Arcanum.Sun] = Arcanum.Devil;
            fusions[Arcanum.Fool][Arcanum.Judgement] = Arcanum.Hanged;
            fusions[Arcanum.Fool][Arcanum.Jester] = Arcanum.Priestess;
            fusions[Arcanum.Fool][Arcanum.Aeon] = Arcanum.Death;
            #endregion

            #region Arcanum.Magician
            fusions[Arcanum.Magician][Arcanum.Fool] = Arcanum.Fortune;
            fusions[Arcanum.Magician][Arcanum.Magician] = Arcanum.Magician;
            fusions[Arcanum.Magician][Arcanum.Priestess] = Arcanum.Moon;
            fusions[Arcanum.Magician][Arcanum.Empress] = Arcanum.Justice;
            fusions[Arcanum.Magician][Arcanum.Emperor] = Arcanum.Strength;
            fusions[Arcanum.Magician][Arcanum.Hierophant] = Arcanum.Devil;
            fusions[Arcanum.Magician][Arcanum.Lovers] = Arcanum.Death;
            fusions[Arcanum.Magician][Arcanum.Chariot] = Arcanum.Temperance;
            fusions[Arcanum.Magician][Arcanum.Justice] = Arcanum.Strength;
            fusions[Arcanum.Magician][Arcanum.Hermit] = Arcanum.Empress;
            fusions[Arcanum.Magician][Arcanum.Fortune] = Arcanum.Lovers;
            fusions[Arcanum.Magician][Arcanum.Strength] = Arcanum.Justice;
            fusions[Arcanum.Magician][Arcanum.Hanged] = Arcanum.Sun;
            fusions[Arcanum.Magician][Arcanum.Death] = Arcanum.Emperor;
            fusions[Arcanum.Magician][Arcanum.Temperance] = Arcanum.Strength;
            fusions[Arcanum.Magician][Arcanum.Devil] = Arcanum.Sun;
            fusions[Arcanum.Magician][Arcanum.Tower] = Arcanum.Hanged;
            fusions[Arcanum.Magician][Arcanum.Star] = null;
            fusions[Arcanum.Magician][Arcanum.Moon] = Arcanum.Star;
            fusions[Arcanum.Magician][Arcanum.Sun] = Arcanum.Chariot;
            fusions[Arcanum.Magician][Arcanum.Judgement] = Arcanum.Lovers;
            fusions[Arcanum.Magician][Arcanum.Jester] = Arcanum.Hierophant;
            fusions[Arcanum.Magician][Arcanum.Aeon] = Arcanum.Emperor;
            #endregion

            #region Arcanum.Priestess
            Fill(Arcanum.Priestess,
                Arcanum.Lovers,
                Arcanum.Fortune,
                Arcanum.Priestess,
                Arcanum.Hermit,
                Arcanum.Empress,
                Arcanum.Sun,
                Arcanum.Emperor,
                Arcanum.Hierophant,
                Arcanum.Hermit,
                Arcanum.Death,
                Arcanum.Hanged,
                Arcanum.Justice,
                Arcanum.Moon,
                Arcanum.Magician,
                Arcanum.Hierophant,
                Arcanum.Justice,
                Arcanum.Magician,
                Arcanum.Emperor,
                Arcanum.Star,
                Arcanum.Devil,
                Arcanum.Sun,
                Arcanum.Devil,
                Arcanum.Sun
                );
            #endregion

            #region Arcanum.Empress
            Fill(Arcanum.Empress,
                Arcanum.Judgement,
                Arcanum.Sun,
                Arcanum.Temperance,
                Arcanum.Empress,
                Arcanum.Moon,
                Arcanum.Death,
                Arcanum.Justice,
                Arcanum.Justice,
                Arcanum.Magician,
                Arcanum.Magician,
                Arcanum.Star,
                Arcanum.Hierophant,
                Arcanum.Temperance,
                Arcanum.Chariot,
                Arcanum.Devil,
                Arcanum.Priestess,
                Arcanum.Hermit,
                Arcanum.Chariot,
                Arcanum.Temperance,
                Arcanum.Priestess,
                Arcanum.Priestess,
                Arcanum.Strength,
                Arcanum.Temperance
                );
            #endregion

            #region Arcanum.Emperor
            Fill(Arcanum.Emperor,
                Arcanum.Hermit,
                Arcanum.Death,
                Arcanum.Justice,
                Arcanum.Fool,
                Arcanum.Emperor,
                Arcanum.Empress,
                Arcanum.Justice,
                Arcanum.Temperance,
                Arcanum.Devil,
                Arcanum.Priestess,
                Arcanum.Lovers,
                Arcanum.Hermit,
                Arcanum.Empress,
                Arcanum.Moon,
                Arcanum.Sun,
                Arcanum.Moon,
                Arcanum.Star,
                Arcanum.Death,
                Arcanum.Magician,
                Arcanum.Chariot,
                Arcanum.Lovers,
                Arcanum.Justice,
                Arcanum.Chariot
                );
            #endregion

            #region Arcanum.Hierophant
            Fill(Arcanum.Hierophant,
                Arcanum.Tower,
                Arcanum.Justice,
                Arcanum.Empress,
                Arcanum.Priestess,
                Arcanum.Chariot,
                Arcanum.Hierophant,
                Arcanum.Death,
                Arcanum.Sun,
                Arcanum.Temperance,
                Arcanum.Justice,
                Arcanum.Priestess,
                Arcanum.Sun,
                Arcanum.Death,
                Arcanum.Devil,
                Arcanum.Magician,
                Arcanum.Emperor,
                Arcanum.Hanged,
                Arcanum.Moon,
                Arcanum.Empress,
                Arcanum.Strength,
                Arcanum.Chariot,
                Arcanum.Magician,
                Arcanum.Moon
                );
            #endregion

            #region Arcanum.Lovers
            Fill(Arcanum.Lovers,
                Arcanum.Devil,
                Arcanum.Temperance,
                Arcanum.Hanged,
                Arcanum.Fool,
                Arcanum.Devil,
                Arcanum.Hanged,
                Arcanum.Lovers,
                Arcanum.Hierophant,
                Arcanum.Priestess,
                Arcanum.Magician,
                Arcanum.Star,
                Arcanum.Emperor,
                Arcanum.Moon,
                Arcanum.Star,
                Arcanum.Hierophant,
                Arcanum.Hierophant,
                Arcanum.Star,
                Arcanum.Hermit,
                Arcanum.Hanged,
                Arcanum.Devil,
                Arcanum.Strength,
                Arcanum.Sun,
                Arcanum.Justice
                );
            #endregion

            #region Arcanum.Chariot
            Fill(Arcanum.Chariot,
                Arcanum.Lovers,
                Arcanum.Emperor,
                Arcanum.Magician,
                Arcanum.Emperor,
                Arcanum.Tower,
                Arcanum.Judgement,
                Arcanum.Hierophant,
                Arcanum.Chariot,
                Arcanum.Temperance,
                Arcanum.Justice,
                Arcanum.Devil,
                Arcanum.Magician,
                Arcanum.Death,
                Arcanum.Hermit,
                Arcanum.Magician,
                Arcanum.Moon,
                Arcanum.Hanged,
                Arcanum.Hierophant,
                Arcanum.Sun,
                Arcanum.Strength,
                Arcanum.Temperance,
                Arcanum.Chariot,
                Arcanum.Strength
                );
            #endregion

            #region Arcanum.Justice
            Fill(Arcanum.Justice,
                Arcanum.Chariot,
                Arcanum.Chariot,
                Arcanum.Hermit,
                Arcanum.Death,
                Arcanum.Jester,
                Arcanum.Magician,
                Arcanum.Aeon,
                Arcanum.Temperance,
                Arcanum.Justice,
                Arcanum.Strength,
                Arcanum.Lovers,
                Arcanum.Temperance,
                Arcanum.Priestess,
                Arcanum.Strength,
                Arcanum.Hermit,
                Arcanum.Magician,
                Arcanum.Lovers,
                Arcanum.Moon,
                Arcanum.Strength,
                Arcanum.Temperance,
                Arcanum.Lovers,
                Arcanum.Emperor,
                Arcanum.Lovers
                );
            #endregion

            #region Arcanum.Hermit
            Fill(Arcanum.Hermit,
                Arcanum.Strength,
                Arcanum.Emperor,
                Arcanum.Magician,
                Arcanum.Fool,
                Arcanum.Moon,
                Arcanum.Lovers,
                Arcanum.Hierophant,
                Arcanum.Priestess,
                Arcanum.Emperor,
                Arcanum.Hermit,
                Arcanum.Empress,
                Arcanum.Hierophant,
                Arcanum.Moon,
                Arcanum.Sun,
                Arcanum.Magician,
                Arcanum.Justice,
                Arcanum.Death,
                Arcanum.Justice,
                Arcanum.Empress,
                Arcanum.Temperance,
                Arcanum.Star,
                Arcanum.Moon,
                Arcanum.Magician);
            #endregion

            #region Arcanum.Fortune
            Fill(Arcanum.Fortune,
                Arcanum.Judgement,
                Arcanum.Strength,
                Arcanum.Aeon,
                Arcanum.Strength,
                Arcanum.Priestess,
                Arcanum.Hanged,
                Arcanum.Hanged,
                Arcanum.Temperance,
                Arcanum.Priestess,
                Arcanum.Judgement,
                Arcanum.Fortune,
                Arcanum.Star,
                Arcanum.Death,
                Arcanum.Hermit,
                Arcanum.Devil,
                Arcanum.Emperor,
                Arcanum.Chariot,
                Arcanum.Star,
                Arcanum.Lovers,
                Arcanum.Priestess,
                Arcanum.Hanged,
                Arcanum.Devil,
                Arcanum.Priestess
                );
            #endregion

            #region Arcanum.Strength
            Fill(Arcanum.Strength,
                Arcanum.Empress,
                Arcanum.Tower,
                Arcanum.Empress,
                Arcanum.Jester,
                Arcanum.Hermit,
                Arcanum.Moon,
                Arcanum.Fool,
                Arcanum.Aeon,
                Arcanum.Priestess,
                Arcanum.Justice,
                Arcanum.Priestess,
                Arcanum.Strength,
                Arcanum.Hierophant,
                Arcanum.Hanged,
                Arcanum.Sun,
                Arcanum.Hermit,
                Arcanum.Hanged,
                Arcanum.Emperor,
                Arcanum.Justice,
                Arcanum.Temperance,
                null,
                Arcanum.Empress,
                Arcanum.Chariot
                );
            #endregion

            #region Arcanum.Hanged
            Fill(Arcanum.Hanged,
                Arcanum.Star,
                Arcanum.Fortune,
                Arcanum.Chariot,
                Arcanum.Sun,
                Arcanum.Hierophant,
                Arcanum.Star,
                Arcanum.Justice,
                Arcanum.Devil,
                Arcanum.Star,
                Arcanum.Strength,
                Arcanum.Fool,
                Arcanum.Star,
                Arcanum.Hanged,
                Arcanum.Priestess,
                Arcanum.Death,
                Arcanum.Justice,
                Arcanum.Hermit,
                Arcanum.Empress,
                Arcanum.Priestess,
                Arcanum.Devil,
                Arcanum.Empress,
                Arcanum.Priestess,
                Arcanum.Death
                );
            #endregion

            #region Arcanum.Death
            Fill(Arcanum.Death,
                Arcanum.Star,
                Arcanum.Fool,
                Arcanum.Chariot,
                Arcanum.Hierophant,
                Arcanum.Strength,
                Arcanum.Magician,
                Arcanum.Hanged,
                Arcanum.Devil,
                Arcanum.Devil,
                Arcanum.Magician,
                Arcanum.Moon,
                Arcanum.Empress,
                Arcanum.Devil,
                Arcanum.Death,
                Arcanum.Chariot,
                Arcanum.Star,
                Arcanum.Lovers,
                Arcanum.Lovers,
                Arcanum.Priestess,
                Arcanum.Empress,
                null,
                Arcanum.Temperance,
                Arcanum.Hanged
                );
            #endregion

            #region Arcanum.Temperance
            Fill(Arcanum.Temperance,
                Arcanum.Justice,
                Arcanum.Sun,
                Arcanum.Lovers,
                Arcanum.Aeon,
                Arcanum.Devil,
                Arcanum.Emperor,
                Arcanum.Fortune,
                Arcanum.Moon,
                Arcanum.Magician,
                Arcanum.Devil,
                Arcanum.Tower,
                Arcanum.Emperor,
                Arcanum.Justice,
                Arcanum.Jester,
                Arcanum.Temperance,
                Arcanum.Hermit,
                Arcanum.Star,
                Arcanum.Hierophant,
                Arcanum.Hanged,
                Arcanum.Hermit,
                null,
                Arcanum.Death,
                Arcanum.Empress
                );
            #endregion

            #region Arcanum.Devil
            Fill(Arcanum.Devil,
                Arcanum.Lovers,
                Arcanum.Chariot,
                Arcanum.Hermit,
                Arcanum.Fool,
                Arcanum.Death,
                Arcanum.Moon,
                Arcanum.Tower,
                Arcanum.Emperor,
                Arcanum.Priestess,
                Arcanum.Death,
                Arcanum.Tower,
                Arcanum.Lovers,
                Arcanum.Justice,
                Arcanum.Lovers,
                Arcanum.Justice,
                Arcanum.Devil,
                Arcanum.Emperor,
                Arcanum.Emperor,
                Arcanum.Empress,
                Arcanum.Hierophant,
                null,
                Arcanum.Chariot,
                Arcanum.Magician
                );
            #endregion

            #region Arcanum.Tower
            Fill(Arcanum.Tower,
                Arcanum.Fortune,
                Arcanum.Emperor,
                Arcanum.Moon,
                Arcanum.Judgement,
                Arcanum.Priestess,
                Arcanum.Emperor,
                Arcanum.Judgement,
                Arcanum.Hierophant,
                Arcanum.Chariot,
                Arcanum.Jester,
                Arcanum.Magician,
                Arcanum.Devil,
                Arcanum.Fortune,
                Arcanum.Justice,
                Arcanum.Judgement,
                Arcanum.Star,
                Arcanum.Tower,
                Arcanum.Hanged,
                Arcanum.Priestess,
                Arcanum.Chariot,
                null,
                Arcanum.Hermit,
                Arcanum.Emperor
                );
            #endregion

            #region Arcanum.Star
            Fill(Arcanum.Star,
                Arcanum.Hermit,
                Arcanum.Hierophant,
                Arcanum.Empress,
                Arcanum.Jester,
                Arcanum.Sun,
                Arcanum.Lovers,
                Arcanum.Hierophant,
                Arcanum.Aeon,
                Arcanum.Sun,
                Arcanum.Death,
                Arcanum.Magician,
                Arcanum.Devil,
                Arcanum.Sun,
                Arcanum.Fortune,
                Arcanum.Hierophant,
                Arcanum.Fortune,
                Arcanum.Hermit,
                Arcanum.Star,
                Arcanum.Emperor,
                Arcanum.Moon,
                null,
                Arcanum.Empress,
                Arcanum.Chariot
                );
            #endregion

            #region Arcanum.Moon
            Fill(Arcanum.Moon,
                Arcanum.Empress,
                Arcanum.Sun,
                Arcanum.Empress,
                Arcanum.Moon,
                Arcanum.Strength,
                Arcanum.Aeon,
                Arcanum.Hanged,
                Arcanum.Fool,
                Arcanum.Star,
                Arcanum.Jester,
                Arcanum.Strength,
                Arcanum.Hierophant,
                Arcanum.Magician,
                Arcanum.Hanged,
                Arcanum.Hanged,
                Arcanum.Death,
                Arcanum.Hanged,
                Arcanum.Death,
                Arcanum.Moon,
                Arcanum.Strength,
                null,
                Arcanum.Hermit,
                Arcanum.Hierophant
                );
            #endregion

            #region Arcanum.Sun
            Fill(Arcanum.Sun,
                Arcanum.Empress,
                Arcanum.Fortune,
                Arcanum.Aeon,
                Arcanum.Lovers,
                Arcanum.Devil,
                Arcanum.Magician,
                Arcanum.Jester,
                Arcanum.Priestess,
                Arcanum.Judgement,
                Arcanum.Tower,
                Arcanum.Chariot,
                Arcanum.Tower,
                Arcanum.Empress,
                Arcanum.Empress,
                Arcanum.Fortune,
                Arcanum.Lovers,
                Arcanum.Death,
                Arcanum.Chariot,
                Arcanum.Death,
                Arcanum.Sun,
                null,
                Arcanum.Lovers,
                Arcanum.Priestess
                );
            #endregion

            #region Arcanum.Judgement
            Fill(Arcanum.Judgement,
                Arcanum.Temperance,
                Arcanum.Sun,
                Arcanum.Temperance,
                Arcanum.Star,
                Arcanum.Hanged,
                Arcanum.Fool,
                Arcanum.Emperor,
                Arcanum.Tower,
                Arcanum.Sun,
                Arcanum.Temperance,
                Arcanum.Fool,
                Arcanum.Temperance,
                Arcanum.Fool,
                Arcanum.Strength,
                Arcanum.Chariot,
                Arcanum.Death,
                Arcanum.Aeon,
                Arcanum.Lovers,
                Arcanum.Hermit,
                Arcanum.Chariot,
                Arcanum.Judgement,
                Arcanum.Chariot,
                Arcanum.Hanged
                );
            #endregion

            #region Arcanum.Jester
            Fill(Arcanum.Jester,
                Arcanum.Priestess,
                Arcanum.Star,
                Arcanum.Moon,
                Arcanum.Devil,
                Arcanum.Chariot,
                Arcanum.Fortune,
                Arcanum.Tower,
                Arcanum.Strength,
                Arcanum.Hermit,
                Arcanum.Aeon,
                Arcanum.Emperor,
                Arcanum.Magician,
                Arcanum.Moon,
                Arcanum.Fortune,
                Arcanum.Priestess,
                Arcanum.Aeon,
                Arcanum.Judgement,
                Arcanum.Death,
                Arcanum.Hanged,
                Arcanum.Lovers,
                Arcanum.Death,
                Arcanum.Jester,
                Arcanum.Devil
                );
            #endregion

            #region Arcanum.Aeon
            Fill(Arcanum.Aeon,
                Arcanum.Jester,
                Arcanum.Empress,
                Arcanum.Fool,
                Arcanum.Star,
                Arcanum.Sun,
                Arcanum.Sun,
                Arcanum.Judgement,
                Arcanum.Justice,
                Arcanum.Temperance,
                Arcanum.Moon,
                Arcanum.Fool,
                Arcanum.Hermit,
                Arcanum.Jester,
                Arcanum.Strength,
                Arcanum.Judgement,
                Arcanum.Lovers,
                Arcanum.Fortune,
                Arcanum.Tower,
                Arcanum.Tower,
                Arcanum.Hierophant,
                Arcanum.Sun,
                Arcanum.Judgement,
                Arcanum.Aeon
                );
            #endregion

            try
            {
                string s = Newtonsoft.Json.JsonConvert.SerializeObject(fusions, Newtonsoft.Json.Formatting.Indented);
                //fusions = fusions ?? Newtonsoft.Json.JsonConvert.DeserializeObject<Fusions>(System.IO.File.ReadAllText(@"f:\tmp\fusions.json"));
            }
            catch (Exception)
            {
                return false;
            }
            return (fusions != null);
        }

        private void Fill(Arcanum first, params int?[] result)
        {
            if (result.Length != 23) throw new ArgumentException("Length different than expected 23", "result");
            fusions[first][Arcanum.Fool] = (Arcanum?)result[0];
            fusions[first][Arcanum.Magician] = (Arcanum?)result[1];
            fusions[first][Arcanum.Priestess] = (Arcanum?)result[2];
            fusions[first][Arcanum.Empress] = (Arcanum?)result[3];
            fusions[first][Arcanum.Emperor] = (Arcanum?)result[4];
            fusions[first][Arcanum.Hierophant] = (Arcanum?)result[5];
            fusions[first][Arcanum.Lovers] = (Arcanum?)result[6];
            fusions[first][Arcanum.Chariot] = (Arcanum?)result[7];
            fusions[first][Arcanum.Justice] = (Arcanum?)result[8];
            fusions[first][Arcanum.Hermit] = (Arcanum?)result[9];
            fusions[first][Arcanum.Fortune] = (Arcanum?)result[10];
            fusions[first][Arcanum.Strength] = (Arcanum?)result[11];
            fusions[first][Arcanum.Hanged] = (Arcanum?)result[12];
            fusions[first][Arcanum.Death] = (Arcanum?)result[13];
            fusions[first][Arcanum.Temperance] = (Arcanum?)result[14];
            fusions[first][Arcanum.Devil] = (Arcanum?)result[15];
            fusions[first][Arcanum.Tower] = (Arcanum?)result[16];
            fusions[first][Arcanum.Star] = (Arcanum?)result[17];
            fusions[first][Arcanum.Moon] = (Arcanum?)result[18];
            fusions[first][Arcanum.Sun] = (Arcanum?)result[19];
            fusions[first][Arcanum.Judgement] = (Arcanum?)result[20];
            fusions[first][Arcanum.Jester] = (Arcanum?)result[21];
            fusions[first][Arcanum.Aeon] = (Arcanum?)result[22];
        }

        private void Fill(Arcanum first, params Arcanum?[] result)
        {
            if (result.Length != 23) throw new ArgumentException("Length different than expected 23", "result");
            fusions[first][Arcanum.Fool] = result[0];
            fusions[first][Arcanum.Magician] = result[1];
            fusions[first][Arcanum.Priestess] = result[2];
            fusions[first][Arcanum.Empress] = result[3];
            fusions[first][Arcanum.Emperor] = result[4];
            fusions[first][Arcanum.Hierophant] = result[5];
            fusions[first][Arcanum.Lovers] = result[6];
            fusions[first][Arcanum.Chariot] = result[7];
            fusions[first][Arcanum.Justice] = result[8];
            fusions[first][Arcanum.Hermit] = result[9];
            fusions[first][Arcanum.Fortune] = result[10];
            fusions[first][Arcanum.Strength] = result[11];
            fusions[first][Arcanum.Hanged] = result[12];
            fusions[first][Arcanum.Death] = result[13];
            fusions[first][Arcanum.Temperance] = result[14];
            fusions[first][Arcanum.Devil] = result[15];
            fusions[first][Arcanum.Tower] = result[16];
            fusions[first][Arcanum.Star] = result[17];
            fusions[first][Arcanum.Moon] = result[18];
            fusions[first][Arcanum.Sun] = result[19];
            fusions[first][Arcanum.Judgement] = result[20];
            fusions[first][Arcanum.Jester] = result[21];
            fusions[first][Arcanum.Aeon] = result[22];
        }

        public Arcanum? Fusion(Arcanum a1, Arcanum a2)
        {
            Arcanum first = ((int)a1 < (int)a2) ? a1 : a2;
            Arcanum second = ((int)a1 < (int)a2) ? a2 : a1;
            return fusions[first][second];
        }

        public Arcanum? Fusion(Arcanum a1, Arcanum a2, Arcanum a3)
        {
            Arcanum? first = Fusion(a1, a2);
            if (!first.HasValue) return null;
            return Fusion(first.Value, a3);
        }

    }
}