using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeLifeEntities
{
    public class Mantenedor
    {
        private BeLifeEntities bbdd = new BeLifeEntities();

        /// <summary>
        /// Agrega un cliente nuevo a la base de datos, verificando que no exista uno previamente.
        /// <seealso cref="BuscarCliente(string)"/>
        /// </summary>
        /// <param name="lcl"></param>
        public void AgregarCliente(BelifeLibrary.Cliente lcl) {

            try
            {
                /*Intenta buscar el cliente asociado al rut del cliente que se desea agregar.*/
                BelifeLibrary.Cliente c = BuscarCliente(lcl.Rut);
                if (c != null)
                {
                    /*En caso de que lo encuentre, levanta una excepción*/
                    throw new Exception();
                }
                /*No se encontró el rut del cliente, por lo que el cliente no existe.*/
                else
                {
                    Cliente efcl = new Cliente();
                    efcl.Rut = lcl.Rut;
                    efcl.Nombres = lcl.Nombres;
                    efcl.Apellidos = lcl.Apellidos;
                    efcl.FechaNacimiento = lcl.FechaNacimiento;
                    efcl.IdSexo = lcl.IdSexo;
                    efcl.IdEstadoCivil = lcl.IdEstadoCivil;
                    bbdd.Cliente.Add(efcl);
                    bbdd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                throw ex;
            }


        }

        /// <summary>
        /// Busca un cliente que coincida con el rut entregado como parametro.
        /// En caso de ser encontrado, crea una nueva instancia Cliente de la librería de clases, y la retorna.
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public BelifeLibrary.Cliente BuscarCliente(string rut) {
            BelifeLibrary.Cliente c = new BelifeLibrary.Cliente();
            try
            {
                /*Busca cliente con el rut entregado*/
                var cliente = bbdd.Cliente.Where(x => x.Rut == rut).SingleOrDefault();

                /*Si el cliente es distinto a null, significa que se encontró, por lo que creamos un nuevo cliente de la
                 librería de clases para retornar.*/
                if (cliente != null)
                {
                    c.Rut = cliente.Rut;
                    c.Nombres = cliente.Nombres;
                    c.Apellidos = cliente.Apellidos;
                    c.FechaNacimiento = cliente.FechaNacimiento;
                    c.IdSexo = cliente.IdSexo;
                    c.IdEstadoCivil = cliente.IdEstadoCivil;
                }
                /*En caso de que no lo encuentre, levanta una excepción*/
                else {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                throw ex;
            }
            return c;
        }

        /// <summary>
        /// Eliminarmos el cliente que posea el rut entregado como parametro
        /// Realiza una verificación si es que existe el cliente.
        /// <seealso cref="BuscarCliente(string)"/>
        /// </summary>
        /// <param name="rut"></param>
        public void EliminarCliente(string rut) {
            try
            {
                /*Buscamos un cliente asociado al rut*/
                var cliente = bbdd.Cliente.Where(x => x.Rut == rut).SingleOrDefault();
                /*Si lo encuentra lo elimina*/
                if (cliente != null)
                {
                    bbdd.Cliente.Remove(cliente);
                    bbdd.SaveChanges();
                }
                else
                {
                    /*Si no lo encuentra, levanta una excepción.*/
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                /*En caso de encontrar alguna excepción, la imprime en consola y se la envía al WPF para controlar el mensaje*/
                Console.Write(ex);
                throw ex;
            }

        }

        /// <summary>
        /// Actualiza un cliente con el rut dado
        /// Modifica sus valores con los valores del nuevo cliente (modifica todo menos el rut)
        /// </summary>
        /// <param name="rut"></param>
        /// <param name="c"></param>
        public void ActualizarCliente(string rut, BelifeLibrary.Cliente c) {

            try
            {
                /*Busca cliente con el rut entregado*/
                var cliente = bbdd.Cliente.Where(x => x.Rut == rut).SingleOrDefault();
                if (cliente != null)
                {
                    /*En caso de que el cliente no sea null, es decir, que lo haya encontrado, lo actualizamos y guardamos cambios.*/
                    cliente.Nombres = c.Nombres;
                    cliente.Apellidos = c.Apellidos;
                    cliente.FechaNacimiento = c.FechaNacimiento;
                    cliente.IdSexo = c.IdSexo;
                    cliente.IdEstadoCivil = c.IdEstadoCivil;
                    bbdd.SaveChanges();
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
                throw ex;
            }

        }

        /// <summary>
        /// Devuelve la descripción del sexo, según su ID
        /// Normalmente se ocupa con el parametro IdSexo del cliente
        /// </summary>
        /// <param name="idSexo"></param>
        /// <returns></returns>
        public string BuscarDescripcionSexo(int idSexo) {
            string descripcion = String.Empty;

            try
            {
                /*Buscamos el sexo donde el id sea igual al parametro entregado*/
                var sexo = bbdd.Sexo.Where(x => x.IdSexo == idSexo).SingleOrDefault();
                if (sexo != null)
                {
                    descripcion = sexo.Descripcion;
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

            return descripcion;
        }

        /// <summary>
        /// Devuelve la descripción del estado civil, según su ID
        /// Normalmente se ocupa con el parametro IdEstadoCivil del cliente
        /// </summary>
        /// <param name="idEstadoCivil"></param>
        /// <returns></returns>
        public string BuscarDescripcionEstadoCivil(int idEstadoCivil)
        {
            string descripcion = String.Empty;

            try
            {
                /*Buscamos el estado civil donde el id sea igual al parametro entregado*/
                var estadocivil = bbdd.EstadoCivil.Where(x => x.IdEstadoCivil == idEstadoCivil).SingleOrDefault();
                if (estadocivil != null)
                {
                    descripcion = estadocivil.Descripcion;
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

            return descripcion;
        }


    }
}
