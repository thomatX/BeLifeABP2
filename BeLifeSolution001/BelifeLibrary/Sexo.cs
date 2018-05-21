using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelifeLibrary
{
    /// <summary>
    /// Crea una nueva instancia de Sexo con sus respectivas validaciones almacenadas en la clase de negocio
    /// <seealso cref="Negocio.Configuracion"/>
    /// </summary>
    public class Sexo
    {
        BeLifeDatos.BeLifeEntities bbdd = new BeLifeDatos.BeLifeEntities();
        private int _id;
        private string _descripcion;
        public int Id
        {
            get { return _id; }
            set
            {
                /*Valida que el id esté dentro del rango aceptado por el modelo de datos*/
                if (Negocio.Configuracion.ValidarIdSexo(value))
                    _id = value;
                else
                    throw new Exception("Error! El id del sexo ingresado no es valido.");
            }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                /*Valida que la descripción del sexo tenga los caracteres minimos y máximos aceptados.*/
                if (Negocio.Configuracion.ValidarDescSexo(value))
                    _descripcion = value;
                else
                    throw new Exception("Error! La descripción del sexo no puede superar los " + Negocio.Configuracion.MAXDESCSEXO + " caracteres.");
            }
        }

        public Sexo()
        {
            InitClass();
        }

        private void InitClass()
        {
            _id = 0;
            _descripcion = String.Empty;
        }
    }
}