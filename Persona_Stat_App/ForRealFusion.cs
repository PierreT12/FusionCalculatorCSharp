using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona_Stat_App
{
    class ForRealFusion
    {
        Persona resultPersona;
        

        public ForRealFusion() { }

        public ForRealFusion(Persona resultPersona)
        {
            this.resultPersona = resultPersona;
            
        }


        public Dictionary<Persona, List<Persona>> Fusions()
        {
            //The Dictonary that holds the final fusion pairs 
            //That are correct
            Dictionary<Persona, List<Persona>> finalValuePairs
                = new Dictionary<Persona, List<Persona>>();
           
            int holder = TypeofFusion(resultPersona);

            //Goes to the Main type of Fusion that will take place
            switch(holder)
            {
                //Normal Fusion
                case 2:
                   finalValuePairs = NormalFusion(resultPersona);
                    break;
                //Special Fusion
                case 3:
                    SpecialFusion(resultPersona);
                    break;

            }

           
            return finalValuePairs;
        }

       

        private int TypeofFusion(Persona resultPersona)
        {
            if (resultPersona.specialFusion)
                return 3;

            if (resultPersona.fuseable)
                return 2;

            return 2;
        }


        //Base Fusion Methods

        private Dictionary<Persona,List<Persona>> NormalFusion(Persona resultPersona)
        {
            //Get a list of the Arcanas combo that result in this Persona
            /////////////////////////
            ///Variables
            ////////////////////////
            Table table = new Table();

            Dictionary<string, List<string>> holdingStringMatches;
            
            Dictionary<Persona, List<Persona>> GeneralPersonaDicton
                = new Dictionary<Persona, List<Persona>>();

            Dictionary<Persona, List<Persona>> FinalDiction
                = new Dictionary<Persona, List<Persona>>();

            Dictionary<Persona, List<Persona>> SuperFinalDiction
                = new Dictionary<Persona, List<Persona>>();


            //Gets all matching Arcana Strings
            holdingStringMatches = table.MatchingArcanas(resultPersona.baseArcana);

            //Gets a unfilter list where only the Persona list
            GeneralPersonaDicton = GetAllMatchingPersonas(holdingStringMatches);

          FinalDiction =  LevelCalcandCheck(GeneralPersonaDicton);
           
            return FinalDiction;
        }

       

        private void SpecialFusion(Persona resultPersona)
        {
            //Looks for the name of the special fusion 
            switch (resultPersona.baseName)
            {
                case "Flauros":
                    break;
                case "Neko Shogun":
                    break;
                case "Hell Biker":
                    break;
                case "Bugs":
                    break;
                case "Seth":
                    break;
                case "Trumpeter":
                    break;
                case "Black Frost":
                    break;
                case "Vasuki":
                    break;
                case "Kohryu":
                    break;
                case "Asura":
                    break;
                case "Sraosha":
                    break;
                case "Izanagi-no-Okami":
                    break;
                case "Alice":
                    break;
                case "Yoshitsune":
                    break;
                case "Michael":
                    break;
                case "Chi You":
                    break;
                case "Metatron":
                    break;
                case "Ongyo-ki":
                    break;
                case "Izanagi-no-Okami Picaro":
                    break;
                case "Satan":
                    break;
                case "Lucifer":
                    break;
                case "Satanael":
                    break;



            }
        }


        //Normal Fusion Methods Interworkings

        private Dictionary<Persona, List<Persona>> GetAllMatchingPersonas(Dictionary<string, List<string>> holdingStringMatches)
        {
            Dictionary<Persona, List<Persona>> holdingallPersonaMatches
                = new Dictionary<Persona, List<Persona>>();

            for(int i = 0; i < holdingStringMatches.Count; i++)
            {
                for(int j = 0; j < holdingStringMatches.ElementAt(i).Value.Count; j++)
                {
                    Dictionary<Persona, List<Persona>> holdingSinglePersonaArcanaMatches
                           = new Dictionary<Persona, List<Persona>>();
                    
                    holdingSinglePersonaArcanaMatches
                        = GetSinglePersonaMatch(holdingStringMatches.ElementAt(i).Key,
                                holdingStringMatches.ElementAt(i).Value.ElementAt(j));
                    
                    //Put each single Persona Match in the General Persona Match
                    foreach(var persona in holdingSinglePersonaArcanaMatches)
                    {
                        holdingallPersonaMatches.Add(persona.Key,persona.Value);
                    }

                }
            }

            return holdingallPersonaMatches;
        }

        private Dictionary<Persona, List<Persona>> GetSinglePersonaMatch(string key, string value)
        {
            string query;
            List<Persona> fPersonas;
            List<Persona> sPersonas;
            Dictionary<Persona, List<Persona>> singlePersonaMatch
                = new Dictionary<Persona, List<Persona>>();
            
            //Creates a Query that looks for all Personas with the First Arcana
            //And is actually a Persona that can be fused
            query = String.Format("SELECT Name, Arcana, Level FROM Personas_Final " +
                "WHERE Arcana = '{0}' " +
                "AND Starter = 'FALSE' " +
                "AND SPOILER = 'FALSE' " +
                "AND Name NOT IN ('{1}')" +
                "AND Treasure = 'FALSE'",
                key,
                resultPersona.baseName);
            //Runs the SQL Query and outputs the list of all the personas 
            //In the Arcana in a List
            fPersonas = RunSQL(query);

            //Creates a Query that looks for all Personas with the Second Arcana
            //And is actually a Persona that can be fused
            query = String.Format("SELECT Name, Arcana, Level FROM Personas_Final " +
                "WHERE Arcana = '{0}' " +
                "AND Starter = 'FALSE' " +
                "AND SPOILER = 'FALSE' " +
                "AND Name NOT IN ('{1}')",
                value,
                resultPersona.baseName);

            //Runs the SQL Query and outputs the list of all the personas 
            //In the Arcana in a List
            sPersonas = RunSQL(query);


            singlePersonaMatch = AddtoDictonary(fPersonas, sPersonas);

            return singlePersonaMatch;

        }

        private List<Persona> RunSQL(string query)
        {
            List<Persona> list = new List<Persona>();
            
            try
            {
                
                SQLiteCommand cmd = new SQLiteCommand(query, info_Form.uwulite);
                SQLiteDataReader reader = cmd.ExecuteReader();




                while (reader.Read())
                {
                    Persona temp = new Persona();
                    string t3mp;
                    temp.baseName = $"{reader.GetString(0)}";
                    temp.baseArcana = $"{reader.GetString(1)}";
                    t3mp = $"{reader.GetValue(2)}";
                    temp.baseLevel = int.Parse(t3mp);
                    list.Add(temp);

                }

                return list;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

                return null;

            }
        }

        


        ////////Level Calcuations//////////
        /// Calcuates Levels for each
        /// General Persona Matches
        //////////////////////////////////

        private Dictionary<Persona, List<Persona>> LevelCalcandCheck(Dictionary<Persona, List<Persona>> generalPersonaDicton)
        {
            Dictionary<Persona, List<Persona>> FinalCorrectPersonas
                = new Dictionary<Persona, List<Persona>>();

            for (int i = 0; i < generalPersonaDicton.Count; i++)
            {
                for(int j = 0; j < generalPersonaDicton.ElementAt(i).Value.Count; j++)
                {
                    //This checks to make sure it isnt fusing two of the same personas
                    //together
                    if(generalPersonaDicton.ElementAt(i).Key.baseName ==
                        generalPersonaDicton.ElementAt(i).Value.ElementAt(j).baseName)
                    {
                        continue;
                    }
                    else
                    {
                        int localLevelCalc;
                        int roundedNumber;
                        bool correct = false;
                        //Gets each persona Combination level number
                        localLevelCalc = LevelCalc(generalPersonaDicton.ElementAt(i).Key,
                                   generalPersonaDicton.ElementAt(i).Value.ElementAt(j));

                        //Check them to see what persona they round up or down two
                        roundedNumber = localLevelCheck(localLevelCalc, resultPersona.baseArcana,
                                   generalPersonaDicton.ElementAt(i).Key,
                                   generalPersonaDicton.ElementAt(i).Value.ElementAt(j));

                        //Check that to make sure it matches result
                        if (roundedNumber == resultPersona.baseLevel)
                            correct = true;

                        //If it matches add the combination to a Dictionary called FinalCorrectPersonas
                        if(correct)
                        {
                            Dictionary<Persona, List<Persona>> templist
                                = new Dictionary<Persona, List<Persona>>();

                            bool unique = false;
                            
                            List<Persona> key = new List<Persona>();
                            List<Persona> value = new List<Persona>();



                            key.Add(generalPersonaDicton.ElementAt(i).Key);
                            value.Add(generalPersonaDicton.ElementAt(i).Value.ElementAt(j));

                            unique = ComapreThem(key, value, FinalCorrectPersonas);

                            if(unique)
                            {

                                templist = AddtoDictonary(key, value);


                                //This might overwrite some stuff but idk
                                for (int k = 0; k < templist.Count; k++)
                                {
                                    if (FinalCorrectPersonas.ContainsKey(templist.ElementAt(k).Key) == true)
                                    {
                                        List<Persona> personas
                                            = new List<Persona>();

                                        Persona keys;


                                        //Adds Personas from the Templist to a holding list
                                        for (int q = 0; q < templist.ElementAt(k).Value.Count; q++)
                                        {
                                            personas.Add(templist.ElementAt(k).Value.ElementAt(q));
                                        }

                                        keys = templist.ElementAt(k).Key;
                                        List<Persona> personas2 = FinalCorrectPersonas[keys];

                                        for (int w = 0; w < personas2.Count; w++)
                                        {
                                            personas.Add(personas2.ElementAt(w));
                                        }

                                        FinalCorrectPersonas[keys] = personas;

                                    }
                                    else
                                    {
                                        FinalCorrectPersonas.Add(templist.ElementAt(k).Key, templist.ElementAt(k).Value);
                                    }
                                }

                            }


                        }

                    }
                    

                   
                }
            }

            
            return FinalCorrectPersonas;
        }

        public bool ComapreThem(List<Persona> key, List<Persona> value, Dictionary<Persona, List<Persona>> finalCorrectPersonas)
        {
            bool tempBool = false;
            //if final is empty that the first value entered is unique
            if (finalCorrectPersonas.Count == 0)
            {
                tempBool = true;
            }
            else
            {
                for(int i = 0; i < finalCorrectPersonas.Count; i++)
                {
                    for(int k = 0; k < finalCorrectPersonas.ElementAt(i).Value.Count; k++)
                    {
                        Persona checkKey = finalCorrectPersonas.ElementAt(i).Key;
                        Persona checkValue = finalCorrectPersonas.ElementAt(i).Value.ElementAt(k);
                        
                        for(int l = 0; l < key.Count; l++)
                        {
                            if(key.ElementAt(l).baseName != checkValue.baseName)
                            {
                                for(int j = 0; j < value.Count; j++)
                                {
                                    if (key.ElementAt(l).baseName != checkValue.baseName &&
                                        value.ElementAt(j).baseName != checkKey.baseName)
                                    {
                                        tempBool = true;
                                    }
                                }
                            }
                        }

                    }
                }
            }

            return tempBool;
        }




        //Works perfectly
        private int LevelCalc(Persona personakey, Persona persona)
        {
           double level;

            level = ((personakey.baseLevel + persona.baseLevel) / 2);

            //Checks to make sure level is a whole number
            bool isfull = level % 1 == 0;
            if(isfull)
            {
                level = level + 1;
            }
            else
            {
                level = level + 0.5;
            }
            //Converts level to an Int
           int level2 = Convert.ToInt32(level);

            return level2;
        }
        private int localLevelCheck(int localLevelCalc, string baseArcana, Persona key, Persona value)
        {
            
            int returnvalue;
            
            //Checks to see if the Arcanas are Matching (if so
            //it will round down)
            if(key.baseArcana == value.baseArcana)
            {
               returnvalue = RoundDown(localLevelCalc,
                                       key.baseLevel,
                                       value.baseLevel);
            }
            else
            {
               returnvalue = RoundUp(localLevelCalc);
            }
            return returnvalue;
        }

        private int RoundUp(int localLevelCalc)
        {
            LinkedList<int> list = new LinkedList<int>();
            Table table = new Table();
            list = table.GetArcanaLevels(resultPersona);

            for (int i = 1; i < list.Count; i++)
                if (list.ElementAt(i) > localLevelCalc)
                {
                    localLevelCalc = list.ElementAt(i);
                    break;

                }
            if (localLevelCalc >= list.ElementAt(list.Count - 1))
                localLevelCalc = list.ElementAt(list.Count - 1);

            return localLevelCalc;

        }
        //Check to see if the persona its rounding down to is in the fusion
        private int RoundDown(int localLevelCalc, int fPLvl, int sPLvl)
        {
            LinkedList<int> list = new LinkedList<int>();
            Table table = new Table();
            list = table.GetArcanaLevels(resultPersona);

            for (int i = 1; i < list.Count; i++)
                if (list.ElementAt(i) < localLevelCalc &&
                    list.ElementAt(i + 1) >= localLevelCalc)
                {
                    if (list.ElementAt(i) == fPLvl || list.ElementAt(i) == sPLvl)
                    {
                        localLevelCalc = list.ElementAt(i - 1);
                        break;
                    }
                    else
                    {
                        localLevelCalc = list.ElementAt(i);
                        break;
                    }
                    

                }
            if (localLevelCalc >= list.ElementAt(list.Count - 1))
                localLevelCalc = list.ElementAt(list.Count - 1);

            return localLevelCalc;

        }

        /////////////////////////
        ///Dictionary Additions
        ////////////////////////
        private Dictionary<Persona, List<Persona>> AddtoDictonary(List<Persona> fPersonas, List<Persona> sPersonas)
        {
            Dictionary<Persona, List<Persona>> temp
               = new Dictionary<Persona, List<Persona>>();

            for (int i = 0; i < fPersonas.Count; i++)
            {
                for (int j = 0; j < sPersonas.Count; j++)
                {
                    PropperDictonCheck(fPersonas.ElementAt(i), sPersonas.ElementAt(j), temp);
                }
            }
            return temp;
        }

        private void PropperDictonCheck(Persona persona1, Persona persona2, Dictionary<Persona, List<Persona>> temp)
        {
            List<Persona> tempAddPersona;

            //Checks to see if there is a list for that key yet
            if (!temp.TryGetValue(persona1, out tempAddPersona))
            {
                tempAddPersona = new List<Persona>();
                temp.Add(persona1, tempAddPersona);
            }
            //temp add is null
            tempAddPersona.Add(persona2);
        }


        


    }
}
