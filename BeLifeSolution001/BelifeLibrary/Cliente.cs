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
        private BeLifeDatos.BeLifeEntities bbdd = new BeLifeDatos.BeLifeEntities();
        private string _rut;
        private string _nombres;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private int _idSexo;
        private int _idEstadoCivil;

        /// <summary>
        /// Cliente.Rut; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.Rut = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica el largo máximo para el rut del cliente (Valor máximo aceptado en el modelo de datos)
        /// </summary>
        public string Rut {
            get { return _rut; }
            set
            {
                /*Si el valor no excede el máximo de caracteres permitidos, y no contiene un string vacío, inserta el nuevo valor a la propiedad*/
                if (Negocio.Configuracion.ValidarRut(value))
                    _rut = value;
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
            get { return _nombres; }
            set
            {
                /*Si el valor no excede el máximo de caracteres permitidos, y no contiene un string vacío, inserta el nuevo valor a la propiedad*/
                if (Negocio.Configuracion.ValidarNombre(value))
                    _nombres = value;
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
            get { return _apellidos; }
            set
            {
                /*Si el valor no excede el máximo de caracteres permitidos, y no contiene un string vacío, inserta el nuevo valor a la propiedad*/
                if (Negocio.Configuracion.ValidarApellido(value))
                    _apellidos = value;
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
            get { return _fechaNacimiento; }
            set
            {
                /*Si el valor ingresado corresponde a una edad mayor a 18, inserta la nueva fecha de nacimiento*/
                if (Negocio.Configuracion.ValidarFechaNacimiento(value))
                    _fechaNacimiento = value;
                else
                    /*Si el valor ingresado corresponde a una edad menor que 18, envía una excepción*/
                    throw new Exception("Error! El cliente no puede tener menos de "+Negocio.Configuracion.MINEDAD+" años.");
            }

        }

        /// <summary>
        /// Cliente.IdSexo; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.IdSexo = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica que el valor esté dentro del rango de Sexos asignados en la tabla.
        /// </summary>
        public int IdSexo
        {
            get { return _idSexo; }
            set
            {
                /*Verificamos que el valor esté dentro del rango aceptado*/
                if (Negocio.Configuracion.ValidarSexo(value))
                    /*Si es correcto, lo seteamos a la variable*/
                    _idSexo = value;
                else
                    /*Si es incorrecto, levantamos una excepción*/
                    throw new Exception("Error! Id del Sexo invalido. (Min: " + Negocio.Configuracion.MINSEXO + "/Max: " + Negocio.Configuracion.MAXSEXO + ")");
            }
        }

        /// <summary>
        /// Cliente.IdEstadoCivil; [Devuelve el valor del atributo de la instancia Cliente]
        /// Cliente.IdEstadoCivil = value; [Inserta un nuevo valor al atributo de la instancia Cliente]
        /// Verifica que el valor esté dentro del rango de Sexos asignados en la tabla.
        /// </summary>
        public int IdEstadoCivil
        {
            get { return _idEstadoCivil; }
            set
            {
                /*Verificamos que el valor esté dentro del rango aceptado*/
                if (Negocio.Configuracion.ValidarEstadoCivil(value))
                    /*Si es correcto, lo seteamos a la variable*/
                    _idEstadoCivil = value;
                else
                    /*Si es incorrecto, levantamos una excepción*/
                    throw new Exception("Error! Id del Sexo invalido. (Min: " + Negocio.Configuracion.MINESTADOCIVIL + "/Max: " + Negocio.Configuracion.MAXESTADOCIVIL + ")");
            }
        }



        /// <summary>
        /// Inicializamos la nueva instancia
        /// <seealso cref="InitClass"/>
        /// </summary>
        public Cliente() {
            InitClass();
        }

        /// <summary>
        /// Inicializamos la nueva instancia con sus valores por defecto.
        /// </summary>
        private void InitClass()
        {
            _rut = String.Empty;
            _nombres = String.Empty;
            _apellidos = String.Empty;
            _fechaNacimiento = new DateTime();
            _idSexo = 0;
            _idEstadoCivil = 0;

        }




        /// <summary>
        /// Agrega un cliente nuevo a la base de datos, verificando que no exista uno previamente.
        /// <seealso cref="BuscarCliente(string)"/>
        /// </summary>
        /// <param name="lcl"></param>
        public bool Agregar()
        {
            try
            {
                /*Intenta buscar el cliente asociado al rut del cliente que se desea agregar.*/
                var cliente = bbdd.Cliente.First(x => x.Rut == Rut);
                if (cliente != null)
                {
                    /*En caso de que lo encuentre, levanta una excepción*/
                    throw new Exception("Error! Ya existe un cliente con ese rut.");
                }
                /*No se encontró el rut del cliente, por lo que el cliente no existe.*/
                else
                {
                    /*Agregamos el cliente*/
                    BeLifeDatos.Cliente cli = new BeLifeDatos.Cliente();
                    CommonBC.Syncronize(this, cli);
                    bbdd.Cliente.Add(cli);
                    bbdd.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                return false;
                throw ex;
            }


        }

        /// <summary>
        /// Busca un cliente que coincida con el rut entregado como parametro.
        /// En caso de ser encontrado, crea una nueva instancia Cliente de la librería de clases, y la retorna.
        /// </summary>
        /// <returns>this</returns>
        public Cliente Buscar()
        {
            try
            {
                /*Busca cliente con el rut entregado*/
                var cliente = bbdd.Cliente.First(x => x.Rut == Rut);

                /*Si el cliente es distinto a null, significa que se encontró, por lo que creamos un nuevo cliente de la
                 librería de clases para retornar.*/
                if (cliente != null)
                {
                    CommonBC.Syncronize(cliente, this);
                    return this;
                }
                else
                    throw new Exception("Error! No se ha podido encontrar el cliente con el rut asociado.");



            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Eliminarmos el cliente que posea el rut entregado como parametro
        /// Realiza una verificación si es que existe el cliente.
        /// <seealso cref="Buscar()"/>
        /// </summary>
        /// <param name="rut"></param>
        public bool Eliminar()
        {
            try
            {
                /*Buscamos un cliente asociado al rut*/
                var cliente = bbdd.Cliente.First(x => x.Rut == Rut);
                /*Si lo encuentra lo elimina*/
                if (cliente != null)
                {
                    bbdd.Cliente.Remove(cliente);
                    bbdd.SaveChanges();
                    return true;
                }
                else
                {
                    /*Si no lo encuentra, levanta una excepción.*/
                    throw new Exception("Error! No se ha encontrado un rut que coinicida con algún cliente");
                }

            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                return false;
                throw ex;
            }

        }

        /// <summary>
        /// Actualiza un cliente con el rut dado
        /// Modifica sus valores con los valores del nuevo cliente (modifica todo menos el rut)
        /// </summary>
        /// <param name="rut"></param>
        /// <param name="c"></param>
        public bool Actualizar()
        {

            try
            {
                /*Busca cliente con el rut entregado*/
                var cliente = bbdd.Cliente.First(x => x.Rut == Rut);
                if (cliente != null)
                {
                    /*En caso de que el cliente no sea null, es decir, que lo haya encontrado, lo actualizamos y guardamos cambios.*/
                    CommonBC.Syncronize(this, cliente);
                    bbdd.SaveChanges();
                    return true;
                }
                else
                {
                    /*En caso de no encontrar un cliente con el rut asociado, enviamos una excepción*/
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                return false;
                throw ex;
            }

        }

        /// <summary>
        /// Buscamos todos los clientes de la base de datos y los convertimos a entidades
        /// </summary>
        /// <returns></returns>
        public List<Cliente> BuscarTodos()
        {
            /*Creamos una lista de clientes del contexto*/
            List<BeLifeDatos.Cliente> listaDatos = bbdd.Cliente.ToList<BeLifeDatos.Cliente>();

            /*Los convertimos a Clientes legibles*/
            List<Cliente> list = SyncList(listaDatos);

            /*Devolvemos la lista*/
            return list;
        }

        /// <summary>
        /// Metodo para convertir una lista de contexto a lista legible por las librerias.
        /// </summary>
        /// <param name="listaDatos"></param>
        /// <returns></returns>
        private static List<Cliente> SyncList(List<BeLifeDatos.Cliente> listaDatos)
        {
            /*Creamos una lista de clientes*/
            List<Cliente> list = new List<Cliente>();

            /*Por cada elemento de la lista de clientes del contexto realizamos una sincronización y los agregamos a la lista de Clientes*/
            foreach (var x in listaDatos)
            {
                Cliente Cliente = new Cliente();
                CommonBC.Syncronize(x, Cliente);
                list.Add(Cliente);

            }

            return list;
        }

        /// <summary>
        /// Devuelve la descripción del sexo, según su ID
        /// Normalmente se ocupa con el parametro IdSexo del cliente
        /// </summary>
        /// <param name="idSexo"></param>
        /// <returns></returns>
        public Sexo BuscarSexo()
        {
            Sexo sexo = new Sexo();

            try
            {
                /*Buscamos el sexo donde el id sea igual al parametro entregado*/
                var sexocontext = bbdd.Sexo.First(x => x.IdSexo == IdSexo);
                if (sexocontext != null)
                {
                    CommonBC.Syncronize(sexocontext,sexo);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw ex;
            }

            return sexo;
        }

        /// <summary>
        /// Devuelve la descripción del estado civil, según su ID
        /// Normalmente se ocupa con el parametro IdEstadoCivil del cliente
        /// </summary>
        /// <param name="idEstadoCivil"></param>
        /// <returns></returns>
        public EstadoCivil BuscarEstadoCivil()
        {
            EstadoCivil estadocivil = new EstadoCivil();

            try
            {
                /*Buscamos el sexo donde el id sea igual al parametro entregado*/
                var estadocontext = bbdd.Sexo.First(x => x.IdSexo == IdEstadoCivil);
                if (estadocontext != null)
                {
                    CommonBC.Syncronize(estadocontext, estadocivil);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw ex;
            }

            return estadocivil;
        }

    }
}
