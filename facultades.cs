using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_2
{
    class facultades : alumnos
    {
        private string facultad;

        public string Facultad { get => facultad; set => facultad = value; } 

        private int semestre; 

        public int Semestre { get => semestre; set => semestre = value; }


        
    }
}
