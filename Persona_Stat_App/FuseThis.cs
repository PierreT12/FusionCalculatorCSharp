using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona_Stat_App
{
    public partial class FuseThis : Form
    {
        Persona resultPersona;
        Dictionary<string, List<string>> valuePairstemp
            = new Dictionary<string, List<string>>();

        Dictionary<Persona, List<Persona>> fusionPairs
            = new Dictionary<Persona, List<Persona>>();

        

        public FuseThis()
        {
            
        }

        public FuseThis(Persona resultPersona)
        {
            this.resultPersona = resultPersona;
            InitializeComponent();
            TableView.View = View.Details;

            SetUpTableView();
        }

        private void FuseThis_Load(object sender, EventArgs e)
        {
            Arcana.Text = resultPersona.baseArcana;
            NameDisplay.Text = resultPersona.baseName;
            Level.Text = resultPersona.baseLevel.ToString();
            ForRealFusion forRealFusion = new ForRealFusion(resultPersona);


            if (!resultPersona.fuseable)
            {
                MessageBox.Show("This Persona is not fuseable!\n" +
                           "Please try a different persona! uwu", "Error", MessageBoxButtons.OK);

                this.Close();
            }
            else
            {
                //The final output will return a list of personas that make the fusion
                //possible which is ValuePair temp for right now uwu
               fusionPairs = forRealFusion.Fusions();
                AddtoView(fusionPairs);
            }




        }

       
        private void AddtoView(Dictionary<Persona, List<Persona>> fusionPairs)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            for (int i = 0; i < fusionPairs.Count; i++)
            {
                for(int j = 0; j < fusionPairs.ElementAt(i).Value.Count; j++)
                {
                    //First Persona 

                    lvi = new ListViewItem();
                    lvi.Text = fusionPairs.ElementAt(i).Key.baseArcana;
                    

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fusionPairs.ElementAt(i).Key.baseName;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fusionPairs.ElementAt(i).Key.baseLevel.ToString();
                    lvi.SubItems.Add(lvsi);

                    //Second Persona

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fusionPairs.ElementAt(i).Value.ElementAt(j).baseArcana;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fusionPairs.ElementAt(i).Value.ElementAt(j).baseName;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fusionPairs.ElementAt(i).Value.ElementAt(j).baseLevel.ToString();
                    lvi.SubItems.Add(lvsi);




                    TableView.Items.Add(lvi);

                    //Auto Adjust the Column width based on the data
                    for(int k = 0; k < TableView.Columns.Count; k++)
                    {
                        if(k == 2 || k == 5)
                        {
                            TableView.Columns[k].Width = -2;
                        }
                        else
                        {
                            TableView.Columns[k].Width = -1;
                        }
                        
                    }
                    

                }
            }

            
        }


        private void SetUpTableView()
        {
            //First Persona
            TableView.Columns.Add("Arcana", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Persona", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Level", -2, HorizontalAlignment.Center);


            //Second Persona
            TableView.Columns.Add("Arcana", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Persona", -2, HorizontalAlignment.Center);
            TableView.Columns.Add("Level", -2, HorizontalAlignment.Center);

        }



        
        

    }

}
