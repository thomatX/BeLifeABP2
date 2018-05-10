using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BelifeLibrary
{
    /// <summary>
    /// Crea una nueva instancia de la clase 'Cliente'
    /// Valida sus parametros a través de la clase de negocio
    /// <seealso cref="Negocio.Configuracion"/>
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Cliente.Rut; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.Rut = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica el largo máximo para el rut del cliente (Valor máximo aceptado en el modelo de datos)
        /// </summary>
        public string Rut {
            get { return Rut; }
            set
            {
                /*Si el valor no excede el máximo de caracteres permitidos, y no contiene un string vacío, inserta el nuevo valor a la propiedad*/
                if (Negocio.Configuracion.ValidarRut(value))
                    Rut = value;
                else
                    /*Si el valor insertado es mayor que el máximo de caracteres permitidos, envía una excepción*/
                    throw new Exception("Error! El Rut del cliente no puede exceder los " + Negocio.Configuracion.MAXRUT + " caracteres");
            }

        }

        /// <summary>
        /// Cliente.Nombres; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.Nombres = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica el largo máximo para el Nombre del cliente (Valor máximo aceptado en el modelo de datos)
        /// </summary>
        public string Nombres
        {
            get { return Nombres; }
            set
            {
                /*Si el valor no excede el máximo de caracteres permitidos, y no contiene un string vacío, inserta el nuevo valor a la propiedad*/
                if (Negocio.Configuracion.ValidarNombre(value))
                    Nombres = value;
                else
                    /*Si el valor insertado es mayor que el máximo de caracteres permitidos, envía una excepción*/
                    throw new Exception("Error! El Nombre del cliente no puede exceder los " + Negocio.Configuracion.MAXNOMBRE + " caracteres");
            }

        }

        /// <summary>
        /// Cliente.Apellidos; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.Apellidos = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica el largo máximo para el Apellido del cliente (Valor máximo aceptado en el modelo de datos)
        /// </summary>
        public string Apellidos
        {
            get { return Apellidos; }
            set
            {
                /*Si el valor no excede el máximo de caracteres permitidos, y no contiene un string vacío, inserta el nuevo valor a la propiedad*/
                if (Negocio.Configuracion.ValidarApellido(value))
                    Apellidos = value;
                else
                    /*Si el valor insertado es mayor que el máximo de caracteres permitidos, envía una excepción*/
                    throw new Exception("Error! El Apellido del cliente no puede exceder los " + Negocio.Configuracion.MAXNOMBRE + " caracteres");
            }

        }

        /// <summary>
        /// Cliente.FechaNacimiento; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.FechaNacimiento = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica si el cliente cumple la edad requerida (Valor minimo aceptado en el modelo de datos)
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return FechaNacimiento; }
            set
            {
                /*Si el valor ingresado corresponde a una edad mayor a 18, inserta la nueva fecha de nacimiento*/
                if (Negocio.Configuracion.ValidarFechaNacimiento(value))
                    FechaNacimiento = value;
                else
                    /*Si el valor ingresado corresponde a una edad menor que 18, envía una excepción*/
                    throw new Exception("Error! El cliente no puede tener menos de "+Negocio.Configuracion.MINEDAD+" años.");
            }

        }



    }
}
