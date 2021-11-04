using DSI.Gestor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSI
{
    public partial class PantallaRegistrarReservaVisita : Form
    {
        GestorDeRegistrarVisita gestor = new GestorDeRegistrarVisita();

        public PantallaRegistrarReservaVisita()
        {
            InitializeComponent();
            habilitarPantalla();
        }

        public void habilitarPantalla()
        {
            List<string> escuelas = gestor.tomarRegReservaVisita();
            foreach (string name in escuelas)
            {
                cmbEscuelas.Items.Add(name);
            }
            cmbEscuelas.SelectedIndex = -1;
        }

        private void bt_Escuela_Click(object sender, EventArgs e)
        {
            gestor.tomarSeleccionEscuela(cmbEscuelas.SelectedItem.ToString());
            solicitarCantidadVisitantes();
        }

        public void solicitarCantidadVisitantes()
        {
            cmbEscuelas.Enabled = false;
            bt_Escuela.Visible = false;
            txt_Cantidad.Visible = true;
            lbl_Cantidad.Visible = true;
            bt_Cantidad.Visible = true;

        }

        private void bt_Cantidad_Click(object sender, EventArgs e)
        {
            List<string> sedes = gestor.tomarCantidadDeVisitantes(int.Parse(txt_Cantidad.Text));
            foreach (string name in sedes)
            {
                cmbSedes.Items.Add(name);
            }
            cmbSedes.SelectedIndex = -1;

            solicitarSeleccionSede();

        }

        public void solicitarSeleccionSede()
        {
            txt_Cantidad.Enabled = false;
            bt_Cantidad.Visible = false;
            cmbSedes.Visible = true;
            lbl_Sede.Visible = true;
            bt_Sedes.Visible = true;

        }

        private void bt_Sedes_Click(object sender, EventArgs e)
        {
            List<string> tipos = gestor.tomarSeleccionSede(cmbSedes.SelectedItem.ToString());
            foreach (string tipo in tipos)
            {
                cmb_Tipos.Items.Add(tipo);
            }
            cmb_Tipos.SelectedIndex = -1;

            solicitarSeleccionTipoVisita();

        }

        public void solicitarSeleccionTipoVisita()
        {
            cmbSedes.Enabled = false;
            bt_Sedes.Visible = false;
            cmb_Tipos.Visible = true;
            lbl_Tipos.Visible = true;
            bt_Tipo.Visible = true;

        }

        private void bt_Tipo_Click(object sender, EventArgs e)
        {
            List<string> expos = gestor.tomarSeleccionTipoVisita(cmb_Tipos.SelectedItem.ToString());
            foreach (string exp in expos)
            {
                cmb_Expos.Items.Add(exp);
            }
            cmb_Expos.SelectedIndex = -1;

            if (cmb_Tipos.SelectedItem.ToString() == "Completa")
            {
                solicitarSeleccionExposicionesCompleta();
            }
            else
            {
                solicitarSeleccionExposiciones();
            }
        }

        public void solicitarSeleccionExposicionesCompleta()
        {
            cmb_Tipos.Enabled = false;
            bt_Tipo.Visible = false;
            txt_Date.Visible = true;
            cmb_Expos.Enabled = false;
            lbl_Expo.Enabled = false;
            bt_Expo.Enabled = false;
            lbl_date.Visible = true;
            bt_Grilla.Visible = true;

        }

        public void solicitarSeleccionExposiciones()
        {
            cmb_Tipos.Enabled = false;
            bt_Tipo.Visible = false;
            cmb_Expos.Visible = true;
            lbl_Expo.Visible = true;
            bt_Expo.Visible = true;
            gdrExpo.Visible = true;
            txt_Date.Visible = true;
            lbl_date.Visible = true;
            bt_Grilla.Visible = true;

        }

        private void bt_Expo_Click(object sender, EventArgs e)
        {
            gdrExpo.Rows.Add(cmb_Expos.SelectedItem.ToString());
        }

        private void bt_Grilla_Click(object sender, EventArgs e)
        {

            List<string> listaExp = new List<string>();
            for (int i = 0; i < gdrExpo.Rows.Count; i++)
            {
                listaExp.Add((gdrExpo.Rows[i].Cells[0].Value.ToString()));
            }
            gestor.tomarExposiciones(listaExp);
            DateTime fechaReserva = DateTime.Parse(txt_Date.Text.Trim());
            List<string> listaGuias = gestor.tomarRegReservaVisita(fechaReserva);
            if (listaGuias.Count == 0)
            {
                MessageBox.Show("No hay guias disponibles para asignar!");
                this.Close();
            }
            foreach (string guia in listaGuias)
            {
                cmb_Guias.Items.Add(guia);
            }
            cmb_Guias.SelectedIndex = -1;

            txt_Guias.Text = gestor.calcularCantidadGuiasNecesarios().ToString();

            solicitarSeleccionGuia();
        }

        public void solicitarSeleccionGuia()
        {
            gdrExpo.Enabled = false;
            txt_Date.Enabled = false;
            bt_Expo.Visible = false;
            bt_Grilla.Visible = false;
            cmb_Guias.Visible = true;
            lbl_CantGuias.Visible = true;
            bt_Guias.Visible = true;
            gdr_Guias.Visible = true;
            txt_Guias.Visible = true;
            bt_NuevaReserva.Visible = true;
            lbl_Guias.Visible = true;

        }

        private void bt_Guias_Click(object sender, EventArgs e)
        {
            gdr_Guias.Rows.Add(cmb_Guias.SelectedItem.ToString());
        }

        private void bt_NuevaReserva_Click(object sender, EventArgs e)
        {
            List<string> listaGuias= new List<string>();
            for (int i = 0; i < gdr_Guias.Rows.Count; i++)
            {
                listaGuias.Add((gdr_Guias.Rows[i].Cells[0].Value.ToString()));
            }
            if (listaGuias.Count == int.Parse(txt_Guias.Text))
            {
                gestor.tomarExposiciones(listaGuias);
                gestor.registrarReserva();
                MessageBox.Show("Reserva añadida con exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad de guias correcta!");
            }
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reserva cancelada!");
            this.Close();
        }
    }
}
