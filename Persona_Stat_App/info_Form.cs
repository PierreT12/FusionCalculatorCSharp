
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;


namespace Persona_Stat_App
{
    public partial class info_Form : DarkForm
    {
        //Get Rid of a majority of global static string and bools ://////


        //Use Data Source instead of DataSource
        //Set new to false to not lose everything
        public static string holyPath = "Data Source= C:\\Users" +
                                        "\\Treffy\\source\\repos" +
                                        "\\Persona_Stat_App\\Persona_Stat_App" +
                                        "\\Resources\\SQL_FILES\\finaL_Database_2.db;New=False;";

        string errorImagepath = "C:\\Users\\STEAM\\Documents\\" +
                    "Pesonal_Project\\Persona_Images\\" +
                    "P5R_Portrait_Morgana_Shocked.png";

        

        string[] statArr = { "Strength", "Magic", "Endureance", "Agiltiy", "Luck" };
        string forReasons;
        ArrayList searchResults = new ArrayList();

        ///Query Info
        //Kept as static because the LiteConnection
        //Never changes
        public static SQLiteConnection uwulite;
        public string startQuery;
        public string addOnQuery;
        public bool dataOpen = false;






        //Data that is goning into other forms//
        //Form 2: Fun Facts
        public static string factarcana;

        //Form 3: Settings

        //Bools for DLC characters and Spoilers
        public static bool showSpoils = false;
        public static bool showIzan = false;
        public static bool sharcanarphM = false;
        public static bool showAriad = false;
        public static bool showAster = false;
        public static bool showThan = false;
        public static bool showKagu = false;
        public static bool showMaIzan = false;
        public static bool showTsuki = false;
        public static bool showMess = false;
        public static bool sharcanarphF = false;
        public static bool showAthe = false;
        public static bool sharcanakami = false;
        public static bool showRaoul = false;


        public static string strIza;
        public static string strOrphM;
        public static string strMess;
        public static string strAthe;
        public static string strOrphF;
        public static string strOkami;
        public static string strKagu;
        public static string strAste;
        public static string strThan;
        public static string strAria;
        public static string strMag;
        public static string strTsuki;
        public static string strRaoul;


        //Form 4 Fusion
        public Persona passOnPersona = new Persona(null, null, 0, false, false, false);



        public info_Form()
        {
            InitializeComponent();

            uwulite = new SQLiteConnection(holyPath);

            newConnection connectionuwu = new newConnection(dataOpen,
               showSpoils, addOnQuery, startQuery, uwulite);



            magic_View.View = View.Details;
            Stats.View = View.Details;

            AddMagic();
            AddStats();



            LetsDoThis(connectionuwu);


            searchBox.PreviewKeyDown += ClickEnter;



        }



        private void LetsDoThis(newConnection connectionuwu)
        {
            connectionuwu.StartConnection();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(connectionuwu.startQuery,
                    connectionuwu.uwulite);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    display_Personas.Items.Add($"{reader.GetString(0)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                display_Box.Image = Image.FromFile(errorImagepath);

            }

        }

        private void AddStats()
        {
            Stats.Columns.Add("Stat", -2, HorizontalAlignment.Left);
            Stats.Columns.Add("Value", -2, HorizontalAlignment.Left);
            string[] statArr = { "Strength", "Magic", "Endureance", "Agiltiy", "Luck" };
            for (int i = 0; i < 5; i++)
            {
                Stats.Items.Add(statArr[i], i);
            }

        }

        private void AddMagic()
        {
            magic_View.SmallImageList = Elemental;

            magic_View.Columns.Add("Magic", -2, HorizontalAlignment.Left);
            magic_View.Columns.Add("Effect", -2, HorizontalAlignment.Left);

            /*  
             magic_View.Items.Add(lvi);*/
            for (int i = 0; i < 10; i++)
            {
                var row = new string[] { " ", "-" };
                var lvi = new ListViewItem(row);
                lvi.ImageIndex = i;
                magic_View.Items.Add(lvi);
            }
        }



        public void display_Personas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string namePer = (string)display_Personas.SelectedItem;
            string str = String.Format("SELECT * FROM Personas_Final " +
                "WHERE Name = '{0}'", namePer);

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(str, uwulite);
                SQLiteDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    forReasons = $"{reader.GetInt32(0).ToString()}";
                    Persona_Name.Text = $"{reader.GetString(2)}";
                    Level.Text = $"{reader.GetInt32(3)}";
                    Arcana.Text = $"{reader.GetString(1)}";
                    LoadImage(cmd, reader);
                    //Fix this uwu
                    label4.Text = LoadWikiLink(cmd, reader);
                    SetStats();
                    SetMagic();


                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

                display_Box.Image = Image.FromFile(errorImagepath);

            }

        }

        private void SetMagic()
        {
            string command = string.Format("SELECT * FROM Str_Wea_Final " +
                "WHERE Str_Wea_ID = '{0}'", forReasons);
            SQLiteCommand cmd = new SQLiteCommand(command, uwulite);
            SQLiteDataReader reader = cmd.ExecuteReader();
            magic_View.Items.Clear();
            var list = new ArrayList();

            //Really sit down and fix this later, optomize it or something
            while (reader.Read())
            {
                list.Add($"{reader.GetString(1)}");
                list.Add($"{reader.GetString(2)}");
                list.Add($"{reader.GetString(3)}");
                list.Add($"{reader.GetString(4)}");
                list.Add($"{reader.GetString(5)}");
                list.Add($"{reader.GetString(6)}");
                list.Add($"{reader.GetString(7)}");
                list.Add($"{reader.GetString(8)}");
                list.Add($"{reader.GetString(9)}");
                list.Add($"{reader.GetString(10)}");
            }
            for (int i = 0; i < list.Count; i++)
            {

                var row = new string[] { " ", (string)list[i] };
                var lvi = new ListViewItem(row);
                lvi.ImageIndex = i;
                magic_View.Items.Add(lvi);

            }

        }

        private void SetStats()
        {
            //Requeryed the list
            string command = string.Format("SELECT * FROM Stats_Final " +
                "WHERE Stat_ID = '{0}'", forReasons);
            SQLiteCommand cmd = new SQLiteCommand(command, uwulite);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Stats.Items.Clear();

            var list = new ArrayList();

            //HotFix clean up later dumb dumb
            while (reader.Read())
            {

                list.Add($"{reader.GetString(1)}");
                list.Add($"{reader.GetString(2)}");
                list.Add($"{reader.GetString(3)}");
                list.Add($"{reader.GetString(4)}");
                list.Add($"{reader.GetString(5)}");

            }
            for (int i = 0; i < list.Count; i++)
            {

                var row = new string[] { statArr[i], list[i].ToString() };
                var lvi = new ListViewItem(row);
                lvi.ImageIndex = i;
                Stats.Items.Add(lvi);

            }

        }

        public string LoadWikiLink(SQLiteCommand cmd, SQLiteDataReader reader)
        {
            string str = (string)reader["Wiki_Link"];

            return str;

        }


        //VS doesnt like certain Image formats, get corrupted during transfer
        private void LoadImage(SQLiteCommand cmd, SQLiteDataReader reader)
        {
            byte[] imagebytes = (byte[])reader["Image"];
            MemoryStream ms = new MemoryStream(imagebytes);

            display_Box.Image = Image.FromStream(ms, true);
        }



        //Do the sort later smh
        private void sortEm(string filters)
        {


        }


        private void wikiLink_Click(object sender, EventArgs e)
        {
            string str = label4.Text;
            System.Diagnostics.Process.Start(str);
        }


        private void search_Click_1(object sender, EventArgs e)
        {
            /*DoTheSearch(connection);*/
        }

        private void funFact_Click(object sender, EventArgs e)
        {
            string namePer = (string)display_Personas.SelectedItem;
            //Checks to make sure you actually select something before loading
            //The new form
            if (String.IsNullOrEmpty(namePer))
            {
                MessageBox.Show("No Persona has been selected. Please Try again!",
                    "Warning", MessageBoxButtons.OK);
            }
            else
            {
                FunFact funFacts = new FunFact();

                string str = String.Format("SELECT FunFact FROM Personas_Final " +
                    "WHERE Name = '{0}'", namePer);
                //Put in a try-catch later arcana maybe
                SQLiteCommand cmd = new SQLiteCommand(str, uwulite);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    factarcana = $"{reader.GetString(0)}";
                }
                funFacts.Show();
            }


        }
       

        //Search got moved to its own method for the enter and button press
        private void DoTheSearch(newConnection connection)
        {
            searchResults.Clear();
            string serPer = searchBox.Text;

            

            //If the search bar is empty just do the OG search
            if (String.IsNullOrEmpty(searchBox.Text))
            {
                display_Personas.Items.Clear();
                connection.StartConnection();


            }
            else
            {

                for (int i = 0; i < display_Personas.Items.Count; i++)
                {
                    string lbString = display_Personas.Items[i].ToString();
                    if (lbString.Contains(serPer))
                        searchResults.Add(lbString);
                }
                display_Personas.Items.Clear();


                for (int i = 0; i < searchResults.Count; i++)
                {
                    display_Personas.Items.Add((string)searchResults[i]);
                }

               

            }
        }

        //Allows the user to hit enter to also do a search instead of a button press
        private void ClickEnter(object sender, PreviewKeyDownEventArgs e)
        {
            /*  if (e.KeyCode == Keys.Enter)
                  DoTheSearch(connectionuwu);*/
        }


        private void FuseButton_Click(object sender, EventArgs e)
        {
            string namePer = (string)display_Personas.SelectedItem;
            string str = String.Format("SELECT * FROM Personas_Final " +
                "WHERE Name = '{0}'", namePer);


            try
            {
                SQLiteCommand cmd = new SQLiteCommand(str, uwulite);
                SQLiteDataReader reader = cmd.ExecuteReader();

          
               

                while (reader.Read())
                {
                    passOnPersona.baseName = $"{reader.GetString(2)}";
                    passOnPersona.baseArcana = $"{reader.GetString(1)}";
                    passOnPersona.baseLevel = int.Parse($"{reader.GetInt32(3)}");
                    passOnPersona.fuseable = Convert.ToBoolean($"{reader.GetString(9)}");
                    passOnPersona.specialFusion = Convert.ToBoolean($"{reader.GetString(11)}");
                    passOnPersona.maxLink = Convert.ToBoolean($"{reader.GetString(12)}");





                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

                display_Box.Image = Image.FromFile(errorImagepath);

            }

            FuseThis fuse = new FuseThis(passOnPersona);
           
            fuse.Show();
        }


        // Fix this heccing mess 
        private void Settings_Click_1(object sender, EventArgs e)
        {
            Settings settingForm = new Settings();
            settingForm.Show();
        }

        
    }
}

