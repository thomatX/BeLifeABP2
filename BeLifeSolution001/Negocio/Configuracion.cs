using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    /// <summary>
    /// Almacena los valores máximos para cada verificación del modelo de entidades.
    /// </summary>
    public class Configuracion
    {
        /* ------------------------------------------------------------------------
         *                                CLIENTES
         *           Toda la configuración y validaciones de la clase Cliente
           ---------------------------------------------------------------------  */
        public static int MAXRUT = 10;
        public static int MAXNOMBRE = 20;
        public static int MAXAPELLIDO = 20;
        public static int MINEDAD = 18;

        // ------------------ Métodos validaciones Cliente ----------------------
        /// <summary>
        /// Metodo para validar nuevo rut del cliente
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo rut cliente.
        /// <returns></returns>
        public static bool ValidarRut(string value) {
            bool validated = false;
            if (value.Length < MAXRUT) {
                validated = true;
            }
            return validated;
        }

        /// <summary>
        /// Metodo para validar nuevo Nombre del cliente
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo Nombre cliente.
        /// <returns></returns>
        public static bool ValidarNombre(string value)
        {
            bool validated = false;
            if (value.Length < MAXNOMBRE)
            {
                validated = true;
            }
            return validated;
        }

        /// <summary>
        /// Metodo para validar nuevo Apellido del cliente
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo Apellido cliente.
        /// <returns></returns>
        public static bool ValidarApellido(string value)
        {
            bool validated = false;
            if (value.Length < MAXAPELLIDO)
            {
                validated = true;
            }
            return validated;
        }

        /// <summary>
        /// Metodo para validar nueva fecha de nacimiento del cliente
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nueva Fecha de nacimiento del cliente.
        /// <returns></returns>
        public static bool ValidarFechaNacimiento(DateTime value) {
            bool validated = false;
            DateTime today = DateTime.Today;
            int age = today.Year - value.Year;
            if (age >= MINEDAD)
            {
                validated = true;
            }
            return validated;
        }


        /* ------------------------------------------------------------------------
         *                                CONTRATOS
         *        Toda la configuración y validaciones de la clase Contratos
           ---------------------------------------------------------------------  */
        public static int MAXNUMCONTRATO = 14;
        public static int MAXCODIGOPLAN = 5;
        public static int MAXIDPLAN = 5;
        public static int MAXPOLIZAACTUAL = 15;

        // -------------------- Métodos validaciones Contrato ------------------------
        /// <summary>
        /// Metodo para validar nuevo Numero de Contrato
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo Numero Contrato.
        /// <returns></returns>
        public static bool ValidarNumContrato(string value)
        {
            bool validated = false;
            if (value.Length < MAXNUMCONTRATO)
            {
                validated = true;
            }
            return validated;
        }

        /// <summary>
        /// Metodo para validar nuevo CodigoPlan
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo Codigo Plan.
        /// <returns></returns>
        public static bool ValidarCodigoPlan(string value)
        {
            bool validated = false;
            if (value.Length < MAXCODIGOPLAN)
            {
                validated = true;
            }
            return validated;
        }

        /// <summary>
        /// Metodo para validar nuevo ID Plan
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo ID Plan.
        /// <returns></returns>
        public static bool ValidarIdPlan(string value)
        {
            bool validated = false;
            if (value.Length < MAXIDPLAN)
            {
                validated = true;
            }
            return validated;
        }

        /// <summary>
        /// Metodo para validar nueva Poliza Actual
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nueva Poliza Actual.
        /// <returns></returns>
        public static bool ValidarPolizaActual(string value)
        {
            bool validated = false;
            if (value.Length < MAXPOLIZAACTUAL)
            {
                validated = true;
            }
            return validated;
        }

        /* ------------------------------------------------------------------------
         *                                SEXO
         *           Toda la configuración y validaciones de la clase Sexo
           ---------------------------------------------------------------------  */
        public static int MAXDESCSEXO = 10;

        // -------------------- Métodos validaciones Sexo ------------------------
        /// <summary>
        /// Metodo para validar nuevo Descripcion del sexo
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo Descripcion Sexo.
        /// <returns></returns>
        public static bool ValidarDescSexo(string value)
        {
            bool validated = false;
            if (value.Length < MAXDESCSEXO)
            {
                validated = true;
            }
            return validated;
        }



        /* ------------------------------------------------------------------------
         *                                ESTADO CIVIL
         *        Toda la configuración y validaciones de la clase Estado Civil
           ---------------------------------------------------------------------  */
        public static int MAXDESCESTCIVIL = 15;

        // -------------------- Métodos validaciones Estado Civil -----------------
        /// <summary>
        /// Metodo para validar nuevo Descripcion del Estado Civil
        /// </summary>
        /// <param name="value"></param>
        /// Value: Nuevo Descripcion Estado Civil.
        /// <returns></returns>
        public static bool ValidarDescEstadoCivil(string value)
        {
            bool validated = false;
            if (value.Length < MAXDESCESTCIVIL)
            {
                validated = true;
            }
            return validated;
        }

    }
}
