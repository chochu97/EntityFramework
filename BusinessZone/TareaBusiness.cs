using DatosZone;
using EntityZone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessZone
{
    public class TareaBusiness
    {
        private TareaDAO tareaDAO = new TareaDAO();

        public void EditarTareita(TareaEntity tareaEntity)
        {
            tareaDAO.EditarTarea(tareaEntity);
        }

        public void EliminarTareita(TareaEntity tareaEntity)
        {
            tareaDAO.EliminarTarea(tareaEntity);
        }

        public void CrearTareita(TareaEntity tareaEntity)
        {
            tareaDAO.NuevaTarea(tareaEntity);
        }

        public List<TareaEntity> GetTareas()
        {
            return tareaDAO.GetAllTareas();
            
        }
    }
}
