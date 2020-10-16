using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Stat_App
{
    public class Persona
    {

        public string baseName { get; set; }
        public string baseArcana { get; set; }
        public int baseLevel { get; set; }
        public bool fuseable { get; set; }
        public bool specialFusion { get; set; }
        public bool maxLink { get; set; }






        public Persona() { }

        public Persona(string baseName,
                       string baseArcana,
                       int baseLevel,
                       bool fuseable,
                       bool specialFusion,
                       bool maxLink)
        {
            this.baseName = baseName;
            this.baseArcana = baseArcana;
            this.baseLevel = baseLevel;
            this.fuseable = fuseable;
            this.specialFusion = specialFusion;
            this.maxLink = maxLink;
        }
    }
}
