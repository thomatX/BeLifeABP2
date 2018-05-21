using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeLifeDatos;

namespace BelifeLibrary
{
    class Plan
    {
        private BeLifeDatos.BeLifeEntities bbdd = new BeLifeDatos.BeLifeEntities();
        private string _id { get; set; }
        private string _nombre { get; set; }
        private double _primaBase { get; set; }
        private string _polizaActual { get; set; }

        public string Id
        {
            get { return _id; }
            set
            {
                if (Negocio.Configuracion.ValidarIdPlan(value))
                    _id = value;
                else
                    throw new Exception("Id Plan Invalido.");
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
            }
        }
        public double PrimaBase
        {
            get
            {
                return _primaBase;
            }
            set
            {
                _primaBase = value;
            }
        }
        public string PolizaActual
        {
            get { return _polizaActual; }
            set
            {
                _polizaActual = value;
            }
        }

        public Plan() {
            InitClass();
        }

        private void InitClass()
        {
            _id = String.Empty;
            _nombre = String.Empty;
            _primaBase = 0;
            _polizaActual = String.Empty;
        }

        public Plan Read() {

            var plan = bbdd.Plan.First(x => x.Id == Id);

            if (plan != null)
            {
                CommonBC.Syncronize(plan, this);
                return this;
            }
            else
                throw new Exception("Error! No se ha podido leer el plan correctamente.");

        }

        public List<Plan> ReadAll() {
            /*Creamos una lista de planes del contexto*/
            List<BeLifeDatos.Plan> listaDatos = bbdd.Plan.ToList<BeLifeDatos.Plan>();

            /*Los convertimos a Planes legibles*/
            List<Plan> list = SyncList(listaDatos);

            /*Devolvemos la lista*/
            return list;

        }

        private List<Plan> SyncList(List<BeLifeDatos.Plan> listaDatos)
        {
            /*Creamos una lista de planes*/
            List<Plan> list = new List<Plan>();

            /*Por cada elemento de la lista de planes del contexto realizamos una sincronización y los agregamos a la lista de Planes*/
            foreach (var x in listaDatos)
            {
                Plan Plan = new Plan();
                CommonBC.Syncronize(x, Plan);
                list.Add(Plan);
            }

            return list;
        }
    }
}
