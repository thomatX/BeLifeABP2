using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelifeLibrary
{
    public class EstadoCivil
    {
        BeLifeDatos.BeLifeEntities bbdd = new BeLifeDatos.BeLifeEntities();
        public int Id { get; set; }
        public string Descripcion {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
    }
}