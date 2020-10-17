using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Stat_App
{
    class Table
    {

        


        public Table() { }




        public Dictionary<string, List<string>> MatchingArcanas(string arcanaFinal)
        {
           

            Dictionary<string, List<string>> keyValuePairs
               = new Dictionary<string, List<string>>();


            switch (arcanaFinal)
            {
                case "Fool":
                    AddtoDicton("Fool", "Fool", keyValuePairs);
                    AddtoDicton("Magician", "Strength", keyValuePairs);
                    AddtoDicton("Empress", "Hierophant", keyValuePairs);
                    AddtoDicton("Empress", "Death", keyValuePairs);
                    AddtoDicton("Hierophant", "Empress", keyValuePairs);
                    AddtoDicton("Chariot", "Hanged", keyValuePairs);
                    AddtoDicton("Justice", "Death", keyValuePairs);
                    AddtoDicton("Justice", "Devil", keyValuePairs);
                    AddtoDicton("Death", "Faith", keyValuePairs);
                    AddtoDicton("Temperance", "Devil", keyValuePairs);
                    AddtoDicton("Temperance", "Councillor", keyValuePairs);
                    AddtoDicton("Moon", "Judgement", keyValuePairs);
                    break;

                case "Magician":
                    //Removed for testing purposes
                    //*AddtoDicton("Fool", "Star", keyValuePairs);*/
                    AddtoDicton("Magician", "Magician", keyValuePairs);
                    AddtoDicton("Priestess", "Hierophant", keyValuePairs);
                    AddtoDicton("Priestess", "Fortune", keyValuePairs);
                    AddtoDicton("Priestess", "Death", keyValuePairs);
                    AddtoDicton("Empress", "Faith", keyValuePairs);
                    AddtoDicton("Lovers", "Moon", keyValuePairs);
                    AddtoDicton("Justice", "Hermit", keyValuePairs);
                    AddtoDicton("Strength", "Moon", keyValuePairs);
                    AddtoDicton("Death", "Councillor", keyValuePairs);
                    AddtoDicton("Temperance", "Sun", keyValuePairs);
                    AddtoDicton("Devil", "Tower", keyValuePairs);
                    break;

                case "Priestess":
                    AddtoDicton("Fool", "Hermit", keyValuePairs);
                    AddtoDicton("Magician", "Chariot", keyValuePairs);
                    AddtoDicton("Priestess", "Priestess", keyValuePairs);
                    AddtoDicton("Empress", "Hanged", keyValuePairs);
                    AddtoDicton("Emperor", "Judgement", keyValuePairs);
                    AddtoDicton("Emperor", "Faith", keyValuePairs);
                    AddtoDicton("Hierophant", "Moon", keyValuePairs);
                    AddtoDicton("Chariot", "Sun", keyValuePairs);
                    AddtoDicton("Hermit", "Devil", keyValuePairs);
                    AddtoDicton("Hermit", "Moon", keyValuePairs);
                    AddtoDicton("Death", "Sun", keyValuePairs);
                    AddtoDicton("Faith", "Councillor", keyValuePairs);
                    break;

                case "Empress":
                    AddtoDicton("Fool", "Tower", keyValuePairs);
                    AddtoDicton("Hanged", "Magician", keyValuePairs);
                    AddtoDicton("Priestess", "Emperor", keyValuePairs);
                    AddtoDicton("Empress", "Empress", keyValuePairs);
                    AddtoDicton("Hierophant", "Faith", keyValuePairs);
                    AddtoDicton("Lovers", "Tower", keyValuePairs);
                    AddtoDicton("Lovers", "Sun", keyValuePairs);
                    AddtoDicton("Justice", "Star", keyValuePairs);
                    AddtoDicton("Fortune", "Temperance", keyValuePairs);
                    AddtoDicton("Strength", "Councillor", keyValuePairs);
                    AddtoDicton("Moon", "Sun", keyValuePairs);
                    break;

                case "Emperor":
                    AddtoDicton("Magician", "Justice", keyValuePairs);
                    AddtoDicton("Priestess", "Empress", keyValuePairs);
                    AddtoDicton("Empress", "Tower", keyValuePairs);
                    AddtoDicton("Empress", "Judgement", keyValuePairs);
                    AddtoDicton("Emperor", "Emperor", keyValuePairs);
                    AddtoDicton("Justice", "Fortune", keyValuePairs);
                    AddtoDicton("Justice", "Temperance", keyValuePairs);
                    AddtoDicton("Justice", "Councillor", keyValuePairs);
                    AddtoDicton("Hermit", "Judgement", keyValuePairs);
                    AddtoDicton("Fortune", "Hanged", keyValuePairs);
                    AddtoDicton("Tower", "Sun", keyValuePairs);
                    AddtoDicton("Sun", "Faith", keyValuePairs);
                    break;

                case "Hierophant":
                    AddtoDicton("Fool", "Temperance", keyValuePairs);
                    AddtoDicton("Fool", "Councillor", keyValuePairs);
                    AddtoDicton("Magician", "Devil", keyValuePairs);
                    AddtoDicton("Magician", "Sun", keyValuePairs);
                    AddtoDicton("Priestess", "Chariot", keyValuePairs);
                    AddtoDicton("Priestess", "Moon", keyValuePairs);
                    AddtoDicton("Emperor", "Hermit", keyValuePairs);
                    AddtoDicton("Hierophant", "Hierophant", keyValuePairs);
                    AddtoDicton("Hermit", "Strength", keyValuePairs);
                    AddtoDicton("Fortune", "Devil", keyValuePairs);
                    AddtoDicton("Strength", "Death", keyValuePairs);
                    AddtoDicton("Hanged", "Sun", keyValuePairs);
                    AddtoDicton("Death", "Moon", keyValuePairs);
                    break;

                case "Lovers":
                    AddtoDicton("Magician", "Hermit", keyValuePairs);
                    AddtoDicton("Magician", "Moon", keyValuePairs);
                    AddtoDicton("Empress", "Justice", keyValuePairs);
                    AddtoDicton("Empress", "Star", keyValuePairs);
                    AddtoDicton("Emperor", "Star", keyValuePairs);
                    AddtoDicton("Emperor", "Councillor", keyValuePairs);
                    AddtoDicton("Hierophant", "Sun", keyValuePairs);
                    AddtoDicton("Lovers", "Lovers", keyValuePairs);
                    AddtoDicton("Chariot", "Moon", keyValuePairs);
                    AddtoDicton("Chariot", "Faith", keyValuePairs);
                    AddtoDicton("Justice", "Hanged", keyValuePairs);
                    AddtoDicton("Devil", "Judgement", keyValuePairs);
                    break;

                case "Chariot":
                    AddtoDicton("Fool", "Lovers", keyValuePairs);
                    AddtoDicton("Magician", "Temperance", keyValuePairs);
                    AddtoDicton("Priestess", "Sun", keyValuePairs);
                    AddtoDicton("Emperor", "Justice", keyValuePairs);
                    AddtoDicton("Hierophant", "Death", keyValuePairs);
                    AddtoDicton("Lovers", "Hermit", keyValuePairs);
                    AddtoDicton("Chariot", "Chariot", keyValuePairs);
                    AddtoDicton("Strength", "Temperance", keyValuePairs);
                    AddtoDicton("Death", "Devil", keyValuePairs);
                    AddtoDicton("Devil", "Moon", keyValuePairs);
                    AddtoDicton("Devil", "Faith", keyValuePairs);
                    AddtoDicton("Devil", "Councillor", keyValuePairs);
                    break;

                case "Justice":
                    AddtoDicton("Fool", "Moon", keyValuePairs);
                    AddtoDicton("Fool", "Sun", keyValuePairs);
                    AddtoDicton("Magician", "Empress", keyValuePairs);
                    AddtoDicton("Magician", "Fortune", keyValuePairs);
                    AddtoDicton("Priestess", "Judgement", keyValuePairs);
                    AddtoDicton("Priestess", "Faith", keyValuePairs);
                    AddtoDicton("Empress", "Emperor", keyValuePairs);
                    AddtoDicton("Emperor", "Devil", keyValuePairs);
                    AddtoDicton("Hierophant", "Fortune", keyValuePairs);
                    AddtoDicton("Hierophant", "Councillor", keyValuePairs);
                    AddtoDicton("Justice", "Justice", keyValuePairs);
                    AddtoDicton("Hanged", "Star", keyValuePairs);
                    break;

                case "Hermit":
                    AddtoDicton("Fool", "Hierophant", keyValuePairs);
                    AddtoDicton("Magician", "Death", keyValuePairs);
                    AddtoDicton("Priestess", "Star", keyValuePairs);
                    AddtoDicton("Empress", "Fortune", keyValuePairs);
                    AddtoDicton("Emperor", "Death", keyValuePairs);
                    AddtoDicton("Chariot", "Strength", keyValuePairs);
                    AddtoDicton("Hermit", "Hermit", keyValuePairs);
                    AddtoDicton("Hanged", "Tower", keyValuePairs);
                    AddtoDicton("Temperance", "Judgement", keyValuePairs);
                    AddtoDicton("Temperance", "Faith", keyValuePairs);
                    AddtoDicton("Devil", "Sun", keyValuePairs);
                    AddtoDicton("Tower", "Moon", keyValuePairs);
                    break;

                case "Fortune":
                    AddtoDicton("Priestess", "Lovers", keyValuePairs);
                    AddtoDicton("Empress", "Moon", keyValuePairs);
                    AddtoDicton("Emperor", "Hierophant", keyValuePairs);
                    AddtoDicton("Chariot", "Tower", keyValuePairs);
                    AddtoDicton("Fortune", "Fortune", keyValuePairs);
                    AddtoDicton("Hanged", "Devil", keyValuePairs);
                    AddtoDicton("Temperance", "Tower", keyValuePairs);
                    AddtoDicton("Star", "Judgement", keyValuePairs);
                    AddtoDicton("Sun", "Councillor", keyValuePairs);
                    AddtoDicton("Judgement", "Faith", keyValuePairs);
                    break;

                case "Strength":
                    AddtoDicton("Fool", "Death", keyValuePairs);
                    AddtoDicton("Magician", "Judgement", keyValuePairs);
                    AddtoDicton("Magician", "Faith", keyValuePairs);
                    AddtoDicton("Empress", "Hermit", keyValuePairs);
                    AddtoDicton("Hierophant", "Lovers", keyValuePairs);
                    AddtoDicton("Lovers", "Fortune", keyValuePairs);
                    AddtoDicton("Lovers", "Temperance", keyValuePairs);
                    AddtoDicton("Chariot", "Temperance", keyValuePairs);
                    AddtoDicton("Hermit", "Death", keyValuePairs);
                    AddtoDicton("Hermit", "Temperance", keyValuePairs);
                    AddtoDicton("Hermit", "Star", keyValuePairs);
                    AddtoDicton("Strength", "Strength", keyValuePairs);
                    AddtoDicton("Devil", "Star", keyValuePairs);
                    break;

                case "Hanged":
                    AddtoDicton("Fool", "Empress", keyValuePairs);
                    AddtoDicton("Priestess", "Tower", keyValuePairs);
                    AddtoDicton("Empress", "Councillor", keyValuePairs);
                    AddtoDicton("Hierophant", "Justice", keyValuePairs);
                    AddtoDicton("Hierophant", "Devil", keyValuePairs);
                    AddtoDicton("Lovers", "Judgement", keyValuePairs);
                    AddtoDicton("Justice", "Sun", keyValuePairs);
                    AddtoDicton("Justice", "Faith", keyValuePairs);
                    AddtoDicton("Fortune", "Tower", keyValuePairs);
                    AddtoDicton("Hanged", "Hanged", keyValuePairs);
                    AddtoDicton("Death", "Temperance", keyValuePairs);
                    break;

                case "Death":
                    AddtoDicton("Fool", "Magician", keyValuePairs);
                    AddtoDicton("Fool", "Strength", keyValuePairs);
                    AddtoDicton("Magician", "Hierophant", keyValuePairs);
                    AddtoDicton("Priestess", "Justice", keyValuePairs);
                    AddtoDicton("Priestess", "Hanged", keyValuePairs);
                    AddtoDicton("Hierophant", "Temperance", keyValuePairs);
                    AddtoDicton("Lovers", "Strength", keyValuePairs);
                    AddtoDicton("Strength", "Devil", keyValuePairs);
                    AddtoDicton("Hanged", "Temperance", keyValuePairs);
                    AddtoDicton("Death", "Death", keyValuePairs);
                    AddtoDicton("Tower", "Faith", keyValuePairs);
                    AddtoDicton("Tower", "Councillor", keyValuePairs);
                    AddtoDicton("Sun", "Judgement", keyValuePairs);
                    break;

                case "Temperance":
                    AddtoDicton("Fool", "Emperor", keyValuePairs);
                    AddtoDicton("Fool", "Devil", keyValuePairs);
                    AddtoDicton("Magician", "Priestess", keyValuePairs);
                    AddtoDicton("Magician", "Tower", keyValuePairs);
                    AddtoDicton("Priestess", "Hermit", keyValuePairs);
                    AddtoDicton("Lovers", "Chariot", keyValuePairs);
                    AddtoDicton("Lovers", "Death", keyValuePairs);
                    AddtoDicton("Chariot", "Devil", keyValuePairs);
                    AddtoDicton("Strength", "Hanged", keyValuePairs);
                    AddtoDicton("Temperance", "Temperance", keyValuePairs);
                    AddtoDicton("Star", "Moon", keyValuePairs);
                    AddtoDicton("Star", "Faith", keyValuePairs);
                    AddtoDicton("Moon", "Councillor", keyValuePairs);
                    break;

                case "Devil":
                    AddtoDicton("Magician", "Lovers", keyValuePairs);
                    AddtoDicton("Priestess", "Strength", keyValuePairs);
                    AddtoDicton("Priestess", "Temperance", keyValuePairs);
                    AddtoDicton("Emperor", "Hanged", keyValuePairs);
                    AddtoDicton("Emperor", "Temperance", keyValuePairs);
                    AddtoDicton("Chariot", "Hermit", keyValuePairs);
                    AddtoDicton("Chariot", "Death", keyValuePairs);
                    AddtoDicton("Justice", "Moon", keyValuePairs);
                    AddtoDicton("Hermit", "Sun", keyValuePairs);
                    AddtoDicton("Fortune", "Star", keyValuePairs);
                    AddtoDicton("Hanged", "Faith", keyValuePairs);
                    AddtoDicton("Devil", "Devil", keyValuePairs);
                    AddtoDicton("Judgement", "Councillor", keyValuePairs);
                    break;

                case "Tower":
                    AddtoDicton("Fool", "Hanged", keyValuePairs);
                    AddtoDicton("Empress", "Sun", keyValuePairs);
                    AddtoDicton("Emperor", "Strength", keyValuePairs);
                    AddtoDicton("Emperor", "Moon", keyValuePairs);
                    AddtoDicton("Hierophant", "Star", keyValuePairs);
                    AddtoDicton("Lovers", "Faith", keyValuePairs);
                    AddtoDicton("Lovers", "Councillor", keyValuePairs);
                    AddtoDicton("Fortune", "Judgement", keyValuePairs);
                    AddtoDicton("Tower", "Tower", keyValuePairs);
                    break;

                case "Star":
                    AddtoDicton("Fool", "Justice", keyValuePairs);
                    AddtoDicton("Empress", "Chariot", keyValuePairs);
                    AddtoDicton("Emperor", "Tower", keyValuePairs);
                    AddtoDicton("Hierophant", "Chariot", keyValuePairs);
                    AddtoDicton("Hermit", "Fortune", keyValuePairs);
                    AddtoDicton("Hermit", "Hanged", keyValuePairs);
                    AddtoDicton("Fortune", "Death", keyValuePairs);
                    AddtoDicton("Fortune", "Sun", keyValuePairs);
                    AddtoDicton("Strength", "Faith", keyValuePairs);
                    AddtoDicton("Hanged", "Judgement", keyValuePairs);
                    AddtoDicton("Hanged", "Councillor", keyValuePairs);
                    AddtoDicton("Star", "Star", keyValuePairs);
                    break;

                case "Moon":
                    AddtoDicton("Fool", "Priestess", keyValuePairs);
                    AddtoDicton("Fool", "Chariot", keyValuePairs);
                    AddtoDicton("Magician", "Councillor", keyValuePairs);
                    AddtoDicton("Priestess", "Devil", keyValuePairs);
                    AddtoDicton("Lovers", "Devil", keyValuePairs);
                    AddtoDicton("Chariot", "Justice", keyValuePairs);
                    AddtoDicton("Chariot", "Star", keyValuePairs);
                    AddtoDicton("Strength", "Star", keyValuePairs);
                    AddtoDicton("Strength", "Sun", keyValuePairs);
                    AddtoDicton("Hanged", "Death", keyValuePairs);
                    AddtoDicton("Tower", "Judgement", keyValuePairs);
                    AddtoDicton("Moon", "Moon", keyValuePairs);
                    break;

                case "Sun":
                    AddtoDicton("Fool", "Judgement", keyValuePairs);
                    AddtoDicton("Empress", "Devil", keyValuePairs);
                    AddtoDicton("Emperor", "Fortune", keyValuePairs);
                    AddtoDicton("Hierophant", "Hanged", keyValuePairs);
                    AddtoDicton("Chariot", "Councillor", keyValuePairs);
                    AddtoDicton("Justice", "Tower", keyValuePairs);
                    AddtoDicton("Fortune", "Moon", keyValuePairs);
                    AddtoDicton("Death", "Tower", keyValuePairs);
                    AddtoDicton("Temperance", "Star", keyValuePairs);
                    AddtoDicton("Star", "Councillor", keyValuePairs);
                    AddtoDicton("Moon", "Faith", keyValuePairs);
                    AddtoDicton("Sun", "Sun", keyValuePairs);
                    break;

                case "Judgement":
                    AddtoDicton("Empress", "Lovers", keyValuePairs);
                    AddtoDicton("Emperor", "Sun", keyValuePairs);
                    AddtoDicton("Hierophant", "Tower", keyValuePairs);
                    AddtoDicton("Lovers", "Justice", keyValuePairs);
                    AddtoDicton("Hermit", "Tower", keyValuePairs);
                    AddtoDicton("Hermit", "Faith", keyValuePairs);
                    AddtoDicton("Councillor", "Fortune", keyValuePairs);
                    AddtoDicton("Star", "Sun", keyValuePairs);
                    AddtoDicton("Judgement", "Judgement", keyValuePairs);
                    break;

                case "Faith":
                    AddtoDicton("Fool", "Fortune", keyValuePairs);
                    AddtoDicton("Magician", "Emperor", keyValuePairs);
                    AddtoDicton("Priestess", "Councillor", keyValuePairs);
                    AddtoDicton("Empress", "Strength", keyValuePairs);
                    AddtoDicton("Empress", "Temperance", keyValuePairs);
                    AddtoDicton("Emperor", "Chariot", keyValuePairs);
                    AddtoDicton("Hierophant", "Judgement", keyValuePairs);
                    AddtoDicton("Lovers", "Star", keyValuePairs);
                    AddtoDicton("Hermit", "Councillor", keyValuePairs);
                    AddtoDicton("Fortune", "Strength", keyValuePairs);
                    AddtoDicton("Strength", "Tower", keyValuePairs);
                    AddtoDicton("Faith", "Faith", keyValuePairs);
                    break;

                case "Councillor":
                    AddtoDicton("Fool", "Faith", keyValuePairs);
                    AddtoDicton("Hierophant", "Hermit", keyValuePairs);
                    AddtoDicton("Lovers", "Hanged", keyValuePairs);
                    AddtoDicton("Chariot", "Fortune", keyValuePairs);
                    AddtoDicton("Justice", "Strength", keyValuePairs);
                    AddtoDicton("Fortune", "Faith", keyValuePairs);
                    AddtoDicton("Hanged", "Moon", keyValuePairs);
                    AddtoDicton("Death", "Star", keyValuePairs);
                    AddtoDicton("Temperance", "Moon", keyValuePairs);
                    AddtoDicton("Tower", "Star", keyValuePairs);
                    AddtoDicton("Councillor", "Councillor", keyValuePairs);
                    break;




            }


            return keyValuePairs;


        }

        public LinkedList<int> GetArcanaLevels(Persona resultPersona)
        {
            LinkedList<int> storedLevels
                = new LinkedList<int>();

            switch(resultPersona.baseArcana)
            {
                case ("Fool"):
                    storedLevels.AddLast(1);
                    storedLevels.AddLast(8);
                    storedLevels.AddLast(16);
                    storedLevels.AddLast(20);
                    storedLevels.AddLast(23);
                    storedLevels.AddLast(26);
                    storedLevels.AddLast(29);
                    storedLevels.AddLast(38);
                    storedLevels.AddLast(42);
                    storedLevels.AddLast(49);
                    storedLevels.AddLast(50);
                    storedLevels.AddLast(67);
                    storedLevels.AddLast(83);
                    storedLevels.AddLast(95);
                    break;
                case ("Magician"):
                    storedLevels.AddLast(2);
                    storedLevels.AddLast(5);
                    storedLevels.AddLast(11);
                    storedLevels.AddLast(17);
                    storedLevels.AddLast(23);
                    storedLevels.AddLast(28);
                    storedLevels.AddLast(43);
                    storedLevels.AddLast(48);
                    storedLevels.AddLast(63);
                    storedLevels.AddLast(83);
                    storedLevels.AddLast(86);
                    break;

                case ("Priestess"):
                    storedLevels.AddLast(6);
                    storedLevels.AddLast(11);
                    storedLevels.AddLast(26);
                    storedLevels.AddLast(40);
                    storedLevels.AddLast(50);
                    storedLevels.AddLast(53);
                    storedLevels.AddLast(77);
                    storedLevels.AddLast(83);
                    break;
                case ("Empress"):
                    storedLevels.AddLast(15);
                    storedLevels.AddLast(20);
                    storedLevels.AddLast(26);
                    storedLevels.AddLast(40);
                    storedLevels.AddLast(50);
                    storedLevels.AddLast(56);
                    storedLevels.AddLast(63);
                    storedLevels.AddLast(81);
                    storedLevels.AddLast(85);
                    break;
                case ("Emperor"):
                    storedLevels.AddLast(10);
                    storedLevels.AddLast(16);
                    storedLevels.AddLast(25);
                    storedLevels.AddLast(36);
                    storedLevels.AddLast(52);
                    storedLevels.AddLast(61);
                    storedLevels.AddLast(66);
                    storedLevels.AddLast(82);
                    storedLevels.AddLast(84);
                    break;
                case ("Hierophant"):
                    storedLevels.AddLast(9);
                    storedLevels.AddLast(17);
                    storedLevels.AddLast(25);
                    storedLevels.AddLast(40);
                    storedLevels.AddLast(52);
                    storedLevels.AddLast(67);
                    storedLevels.AddLast(76);
                    break;
                case ("Lovers"):
                    storedLevels.AddLast(2);
                    storedLevels.AddLast(6);
                    storedLevels.AddLast(13);
                    storedLevels.AddLast(19);
                    storedLevels.AddLast(42);
                    storedLevels.AddLast(48);
                    storedLevels.AddLast(58);
                    storedLevels.AddLast(78);
                    storedLevels.AddLast(85);
                    break;
                case ("Chariot"):
                    storedLevels.AddLast(3);
                    storedLevels.AddLast(10);
                    storedLevels.AddLast(18);
                    storedLevels.AddLast(25);
                    storedLevels.AddLast(30);
                    storedLevels.AddLast(38);
                    storedLevels.AddLast(46);
                    storedLevels.AddLast(50);
                    storedLevels.AddLast(55);
                    storedLevels.AddLast(64);
                    storedLevels.AddLast(88);
                    break;
                case ("Justice"):
                    storedLevels.AddLast(9);
                    storedLevels.AddLast(14);
                    storedLevels.AddLast(29);
                    storedLevels.AddLast(41);
                    storedLevels.AddLast(58);
                    storedLevels.AddLast(68);
                    storedLevels.AddLast(72);
                    storedLevels.AddLast(81);
                    storedLevels.AddLast(89);
                    break;
                case ("Hermit"):
                    storedLevels.AddLast(4);
                    storedLevels.AddLast(9);
                    storedLevels.AddLast(13);
                    storedLevels.AddLast(17);
                    storedLevels.AddLast(24);
                    storedLevels.AddLast(31);
                    storedLevels.AddLast(35);
                    storedLevels.AddLast(42);
                    storedLevels.AddLast(49);
                    storedLevels.AddLast(70);
                    storedLevels.AddLast(86);
                    storedLevels.AddLast(89);
                    break;
                case ("Fortune"):
                    storedLevels.AddLast(20);
                    storedLevels.AddLast(27);
                    storedLevels.AddLast(30);
                    storedLevels.AddLast(35);
                    storedLevels.AddLast(39);
                    storedLevels.AddLast(42);
                    storedLevels.AddLast(46);
                    storedLevels.AddLast(52);
                    storedLevels.AddLast(56);
                    storedLevels.AddLast(62);
                    storedLevels.AddLast(69);
                    break;
                case ("Strength"):
                    storedLevels.AddLast(6);
                    storedLevels.AddLast(15);
                    storedLevels.AddLast(20);
                    storedLevels.AddLast(24);
                    storedLevels.AddLast(30);
                    storedLevels.AddLast(31);
                    storedLevels.AddLast(44);
                    storedLevels.AddLast(64);
                    storedLevels.AddLast(74);
                    storedLevels.AddLast(80);
                    break;
                case ("Hanged"):
                    storedLevels.AddLast(9);
                    storedLevels.AddLast(14);
                    storedLevels.AddLast(21);
                    storedLevels.AddLast(26);
                    storedLevels.AddLast(35);
                    storedLevels.AddLast(42);
                    storedLevels.AddLast(51);
                    storedLevels.AddLast(60);
                    storedLevels.AddLast(73);
                    storedLevels.AddLast(82);
                    break;
                case ("Death"):
                    storedLevels.AddLast(3);
                    storedLevels.AddLast(9);
                    storedLevels.AddLast(17);
                    storedLevels.AddLast(20);
                    storedLevels.AddLast(28);
                    storedLevels.AddLast(37);
                    storedLevels.AddLast(40);
                    storedLevels.AddLast(54);
                    storedLevels.AddLast(62);
                    storedLevels.AddLast(65);
                    storedLevels.AddLast(69);
                    storedLevels.AddLast(72);
                    storedLevels.AddLast(83);
                    break;
                case ("Temperance"):
                    storedLevels.AddLast(7);
                    storedLevels.AddLast(11);
                    storedLevels.AddLast(15);
                    storedLevels.AddLast(22);
                    storedLevels.AddLast(33);
                    storedLevels.AddLast(45);
                    storedLevels.AddLast(55);
                    storedLevels.AddLast(77);
                    storedLevels.AddLast(84);
                    break;
                case ("Devil"):
                    storedLevels.AddLast(5);
                    storedLevels.AddLast(19);
                    storedLevels.AddLast(27);
                    storedLevels.AddLast(32);
                    storedLevels.AddLast(45);
                    storedLevels.AddLast(58);
                    storedLevels.AddLast(74);
                    storedLevels.AddLast(82);
                    storedLevels.AddLast(87);
                    break;
                case ("Tower"):
                    storedLevels.AddLast(37);
                    storedLevels.AddLast(41);
                    storedLevels.AddLast(44);
                    storedLevels.AddLast(48);
                    storedLevels.AddLast(51);
                    storedLevels.AddLast(59);
                    storedLevels.AddLast(73);
                    storedLevels.AddLast(87);
                    storedLevels.AddLast(90);
                    break;
                case ("Star"):
                    storedLevels.AddLast(11);
                    storedLevels.AddLast(23);
                    storedLevels.AddLast(30);
                    storedLevels.AddLast(36);
                    storedLevels.AddLast(52);
                    storedLevels.AddLast(68);
                    storedLevels.AddLast(80);
                    storedLevels.AddLast(84);
                    storedLevels.AddLast(93);
                    break;
                case ("Moon"):
                    storedLevels.AddLast(7);
                    storedLevels.AddLast(12);
                    storedLevels.AddLast(16);
                    storedLevels.AddLast(18);
                    storedLevels.AddLast(24);
                    storedLevels.AddLast(25);
                    storedLevels.AddLast(33);
                    storedLevels.AddLast(43);
                    storedLevels.AddLast(50);
                    storedLevels.AddLast(55);
                    storedLevels.AddLast(60);
                    storedLevels.AddLast(70);
                    storedLevels.AddLast(75);
                    break;
                case ("Sun"):
                    storedLevels.AddLast(16);
                    storedLevels.AddLast(34);
                    storedLevels.AddLast(39);
                    storedLevels.AddLast(43);
                    storedLevels.AddLast(47);
                    storedLevels.AddLast(53);
                    storedLevels.AddLast(66);
                    storedLevels.AddLast(76);
                    break;
                case ("Judgement"):
                    storedLevels.AddLast(34);
                    storedLevels.AddLast(59);
                    storedLevels.AddLast(64);
                    storedLevels.AddLast(75);
                    storedLevels.AddLast(81);
                    storedLevels.AddLast(82);
                    storedLevels.AddLast(87);
                    storedLevels.AddLast(90);
                    storedLevels.AddLast(92);
                    break;
                case ("Faith"):
                    storedLevels.AddLast(21);
                    storedLevels.AddLast(27);
                    storedLevels.AddLast(39);
                    storedLevels.AddLast(54);
                    storedLevels.AddLast(60);
                    storedLevels.AddLast(65);
                    storedLevels.AddLast(76);
                    storedLevels.AddLast(84);
                    storedLevels.AddLast(93);
                    break;
                case ("Councillor"):
                    storedLevels.AddLast(12);
                    storedLevels.AddLast(22);
                    storedLevels.AddLast(32);
                    storedLevels.AddLast(44);
                    storedLevels.AddLast(57);
                    storedLevels.AddLast(62);
                    storedLevels.AddLast(71);
                    storedLevels.AddLast(80);
                    break;
            }
            return storedLevels;
        }

        public void AddtoDicton(string v1, string v2, Dictionary<string, List<string>> keyValuePairs)
        {
            List<string> tempAdd;
            
            //Checks to see if there is a list for that key yet
            if (!keyValuePairs.TryGetValue(v1, out tempAdd))
            {
                tempAdd = new List<string>();
                keyValuePairs.Add(v1, tempAdd);
            }
            //temp add is null 
            tempAdd.Add(v2);
        }

        public Dictionary<Persona, List<Persona>> ConverttoPersona(Dictionary<Persona, List<Persona>> KeyValuePair)
        {
            Dictionary<Persona, List<Persona>> keyvalue 
                = new Dictionary<Persona, List<Persona>>();




            return KeyValuePair;
        }
    }

}

