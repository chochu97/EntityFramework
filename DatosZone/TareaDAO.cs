using EntityZone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosZone
{
    public class TareaDAO
    {
        public List<TareaEntity> GetAllTareas()
        {
            TareaContext tareaContext = new TareaContext();

            List<Tarea> tareas = tareaContext.Tarea.ToList();

            return tareas.Select(tarea => new TareaEntity
            {
                Descripcion = tarea.descripcion_tarea,
                Id = tarea.id,
                FechaRegistro = tarea.fecha_registro,
                FechaLimite = tarea.fecha_tarea,

            }).ToList();
        }
        public void NuevaTarea(TareaEntity tarea)
        {
            Tarea tarea1 = new Tarea();

            tarea1.id = tarea.Id;
            tarea1.descripcion_tarea = tarea.Descripcion;
            tarea1.fecha_registro = tarea.FechaRegistro;
            tarea1.fecha_tarea = tarea.FechaLimite;

            using (TareaContext tareaContext = new TareaContext())
            {
                tareaContext.Tarea.Add(tarea1);
                tareaContext.SaveChanges();
            }
        }

        public void EditarTarea(TareaEntity tareaNew)
        {
            using (TareaContext context = new TareaContext())
            {
                Tarea tareita = context.Tarea.FirstOrDefault(t => t.id == tareaNew.Id);
                tareita.descripcion_tarea = tareaNew.Descripcion;
                tareita.fecha_tarea = tareaNew.FechaLimite;
                context.SaveChanges();
            }
        }

        public void EliminarTarea(TareaEntity tareaDelete)
        {
            using (TareaContext context = new TareaContext())
            {
                Tarea tareita = context.Tarea.FirstOrDefault(t => t.id == tareaDelete.Id);
                context.Tarea.Remove(tareita);
                context.SaveChanges();
            }
        }
    }

    
}
