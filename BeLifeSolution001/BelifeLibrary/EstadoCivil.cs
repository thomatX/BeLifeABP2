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
        private int _id;
        private string _descripcion;
        public int Id {
            get { return _id; }
            set
            {
                if (Negocio.Configuracion.ValidarIdEstadoCivil(value))
                    _id = value;
                else
                    throw new Exception("Error! El id del sexo ingresado no es valido.");
            }
        }
        public string Descripcion {
            get { return _descripcion; }
            set
            {
                if (Negocio.Configuracion.ValidarDescEstadoCivil(value))
                    _descripcion = value;
                else
                    throw new Exception("Error! La descripción del estado civil no puede superar los " + Negocio.Configuracion.MAXDESCESTCIVIL + " caracteres.");
            }
        }

        public EstadoCivil() {
            InitClass();
        }

        private void InitClass()
        {
            _id = 0;
            _descripcion = String.Empty;
        }
    }
}