using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Stat_App
{
    class newConnection
    {

        //fix up this class later
        public bool dataOpen { get; set; }
        public bool showSpoils { get; set; }
        public string addOnQuery { get; set; }
        public string startQuery { get; set; }
        public SQLiteConnection uwulite { get; set; }

        public newConnection(bool dataOpen, bool showSpoils,
            string addOnQuery, string startQuery, SQLiteConnection uwulite)
        {
            this.dataOpen = dataOpen;
            this.showSpoils = showSpoils;
            this.addOnQuery = addOnQuery;
            this.startQuery = startQuery;
            this.uwulite = uwulite;
        }


        public void StartConnection()
        {
            //Fix this erroring out for some reason :/
            if (dataOpen == false)
            {
                uwulite.Open();
                dataOpen = true;
            }

            if (String.IsNullOrEmpty(addOnQuery) && showSpoils == false)
            {
                startQuery = "Select Name FROM Personas_Final " +
               // "WHERE Spoiler = 'FALSE' " +
                "ORDER BY Level ASC";
            }
            if (String.IsNullOrEmpty(addOnQuery) && showSpoils == true)
            {
                startQuery = "Select Name FROM Personas_Final " +
                "ORDER BY Level ASC";
            }
        }
    }
}
