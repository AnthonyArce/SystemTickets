using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ticket_s
{
    public partial class frmPrincipal : Form
    {
        int[] asientos = new int[10]; // 0 libre - 1 reservado s/comida - 2 reservado c/comida
        List<Label> labels;
        List<Color> colores = new List<Color> { Color.Green, Color.Blue, Color.Red };
        int asientoConComida = 0;
        int asientosSinComida = 0;
        int asientosDisponibles = 0;



        public frmPrincipal()
        {
            InitializeComponent();
            labels = new List<Label> { lblAsiento1 , lblAsiento2, lblAsiento3 , lblAsiento4, lblAsiento5, lblAsiento6, lblAsiento7, lblAsiento8, lblAsiento9, lblAsiento10 };

            asientosDisponibles = asientos.Length;
            prbCapacidad.Maximum = asientos.Length;

            actualizarCamposLbl(asientosDisponibles, asientoConComida, asientosSinComida);
        }

        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarComboText(asientos);
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            if (cboNumAsientos.Text != "Seleccione un asiento")
            {
                int asientoSeleccionado = int.Parse(cboNumAsientos.Text);
                bool conComida = chkConComida.Checked;

                if (conComida)
                {
                    asientos[asientoSeleccionado - 1] = 2;
                    asientoConComida++;
                }
                else
                {
                    asientos[asientoSeleccionado - 1] = 1;
                    asientosSinComida++;
                }

                asientosDisponibles--;
                prbCapacidad.Value++;

                if(asientosDisponibles == 0)
                    btnVender.Enabled = false;

                cargarComboText(asientos);
                actualizarCamposLbl(asientosDisponibles, asientoConComida, asientosSinComida);
            }
            else
            {
                MessageBox.Show("Seleccione un asiento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < asientos.Length; i++) 
            {
                labels[i].BackColor = colores[asientos[i]];
            }
        }



        //Metodos Privados

        private void cargarComboText(int[] asientos) 
        {
            cboNumAsientos.Items.Clear();
            chkConComida.Checked = false;
            cboNumAsientos.Text = "Seleccione un asiento";

            for (int i = 0; i < asientos.Length; i++)
            {
                if (asientos[i] == 0)
                    cboNumAsientos.Items.Add((i + 1).ToString());
            }
        }

        private void actualizarCamposLbl(int asientosDisponibles, int asientosConComida, int asientosSinComida) 
        {
            if(asientosDisponibles == asientos.Length) 
            {
                lblCantAsientoDisp.Text = asientosDisponibles.ToString();
                lblCantAsientoOcup.Text = "0";
                lblCantComida.Text = "0";
                lblTotalRecauSinComida.Text = "0";
                lblTotalRecauConComida.Text = "0";
            }
            else 
            {
                lblCantAsientoDisp.Text = asientosDisponibles.ToString();
                lblCantAsientoOcup.Text = (asientosConComida + asientosSinComida).ToString();
                lblCantComida.Text = asientosConComida.ToString();
                lblTotalRecauSinComida.Text = (asientosSinComida * 25500).ToString();
                lblTotalRecauConComida.Text = (asientosConComida * (25550 + 15000)).ToString();
            }
        }
    }
}
