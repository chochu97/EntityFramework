using BusinessZone;
using EntityZone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadClase11
{
    public partial class Form1 : Form
    {
        private TareaBusiness tareaBusiness = new TareaBusiness();

        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tareaBusiness.GetTareas();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TareaEntity entity = new TareaEntity();

            entity.Descripcion = txtDescripcion.Text;
            entity.FechaLimite = Convert.ToDateTime(dateTimePckFecha.Value);
            entity.FechaRegistro = DateTime.Now;

            tareaBusiness.CrearTareita(entity);
            LlenarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TareaEntity ent = new TareaEntity();

            ent.Id = Convert.ToInt32(txtIDModif.Text);
            ent.Descripcion = txtNewDescripcion.Text;
            ent.FechaLimite = Convert.ToDateTime(dateTimePckModif.Value);

            tareaBusiness.EditarTareita(ent);
            LlenarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TareaEntity tareaEntity = new TareaEntity();

            tareaEntity.Id = Convert.ToInt32(txtIDEliminar.Text);

            tareaBusiness.EliminarTareita(tareaEntity);
            LlenarGrid();
        }
    }
}
