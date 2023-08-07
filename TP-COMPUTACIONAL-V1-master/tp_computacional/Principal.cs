using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MamiQueTuQuiere
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelIniciarSubMenu.Visible = false;

        }

        //NO BORRAR (NO SE ESTA USANDO PERO IGUALMENTE NO BORRAR)
        private void hidePanelGrande()
        {
            if (paneLogoGrande.Visible == true)
                paneLogoGrande.Visible=false;
        }
        private void hideSubMenu()
        {
            if (panelIniciarSubMenu.Visible==true)
                panelIniciarSubMenu.Visible=false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible=true;
            }
            else
            {
                subMenu.Visible=false;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelIniciarSubMenu);
        }

        private void btnPrograma_Click(object sender, EventArgs e){}

        private void btnIntegrante_Click(object sender, EventArgs e)
        {
            AbrirForm<Integrante>();
            //hideSubMenu();
        }

        private void btnTeoria_Click(object sender, EventArgs e)
        {
            AbrirForm<Teoria>();
            //hideSubMenu();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirForm<MiForm>()where MiForm : Form, new()
        {
            Form formulario;
            formulario = paneLogoGrande.Controls.OfType<MiForm>().FirstOrDefault(); //BUSCA EN LA COLECCION EL FORM
            //Si el form/instancia no existe
            if(formulario ==null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                paneLogoGrande.Controls.Add(formulario);
                paneLogoGrande.Tag = formulario;
                formulario.Show();
            }
            //si en caso el formulario existe
            else
            {
                formulario.BringToFront();
            }

        }


        //NO BORRAR (NO HAY NADA PERO IGUALMENTE NO BORRAR)
        private void panelLogo_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //FormCargando formCargando = new FormCargando();
            //formCargando.Show();
            Application.Exit();
            //formCargando.Close();
            this.Close();
        }

        //NO BORRAR (NO HAY NADA PERO IGUALMENTE NO BORRAR)
        private void paneLogoGrande_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
          // AbrirForm<Teoria2>();
        }

        private void btnPrograma_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirForm<Compilador>();
            //hideSubMenu();
        }

        private void btnIntegrante_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnTeoria_MouseClick(object sender, MouseEventArgs e)
        {
            //hideSubMenu();
        }
    }
}
