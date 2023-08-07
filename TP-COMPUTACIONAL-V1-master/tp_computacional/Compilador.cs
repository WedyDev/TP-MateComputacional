using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MamiQueTuQuiere.Clases;

namespace MamiQueTuQuiere
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            InitializeComponent();


           

        }
        Class_Matriz_Principal obj_matriz=new Class_Matriz_Principal();

        Class_CicloH obj_cicloh=new Class_CicloH();

       
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            label3.Visible =true;
            lblMinimo.Visible=true;
            decimal aux = NUP_data.Value;

            obj_matriz.Rellenar_Matriz(aux, dataGridView1,label3);

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.AllCells);


            lblHamilton.Text = Convert.ToString(obj_cicloh.Ciclos_Hamiltonianos(Convert.ToInt32(aux)));
            lblHamilton.Visible = true;

        }
    }
}
