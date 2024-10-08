﻿using System;
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
        #region Declaración de variables globales

        int[] _asientos = new int[10]; // 0 libre - 1 reservado s/comida - 2 reservado c/comida
        List<Label> _labels;
        List<Color> _colores = new List<Color> { Color.Green, Color.Blue, Color.Red };
        enum Estado { sinComida = 1, conComida = 2 };
        int _asientoConComida = 0;
        int _asientosSinComida = 0;
        int _asientosDisponibles = 0;

        #endregion



        public frmPrincipal()
        {
            InitializeComponent();

            _asientosDisponibles = _asientos.Length;
            prbCapacidad.Maximum = _asientos.Length;

            actualizarResumen(_asientosDisponibles, _asientoConComida, _asientosSinComida);
        }

        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarComboText(_asientos);
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            if (cboNumAsientos.Text != "Seleccione un asiento")
            {
                int estadoSeleccionado = 0;
                int asientoSeleccionado = int.Parse(cboNumAsientos.Text);
                bool conComida = chkConComida.Checked;

            

                if (conComida)
                {
                    _asientos[asientoSeleccionado - 1] = (int)Estado.conComida;
                    _asientoConComida++;
                    estadoSeleccionado = (int)Estado.conComida;
                }
                else
                {
                    _asientos[asientoSeleccionado - 1] = (int)Estado.sinComida;
                    _asientosSinComida++;
                    estadoSeleccionado = (int)Estado.sinComida;
                }

                _asientosDisponibles--;
                prbCapacidad.Value++;


                if(_asientosDisponibles == 0)
                    btnVender.Enabled = false;

                ActualizarCampoVentas();
                actualizarResumen(_asientosDisponibles, _asientoConComida, _asientosSinComida);
                cambiarColorAsiento(asientoSeleccionado, estadoSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un asiento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Metodos Privados

        private void cargarComboText(int[] _asientos) 
        {
            cboNumAsientos.Items.Clear();
            chkConComida.Checked = false;
            cboNumAsientos.Text = "Seleccione un asiento";

            for (int i = 0; i < _asientos.Length; i++)
            {
                if (_asientos[i] == 0)
                {
                    cboNumAsientos.Items.Add((i + 1).ToString());
                    cambiarColorAsiento(i, 0);
                }
                    
            }
        }

        private void ActualizarCampoVentas()
        {
            
            chkConComida.Checked = false;
            cboNumAsientos.Items.RemoveAt(cboNumAsientos.SelectedIndex);
            cboNumAsientos.Text = "Seleccione un asiento";
            
        }

        private void actualizarResumen(int _asientosDisponibles, int asientosConComida, int _asientosSinComida) 
        {
            if(_asientosDisponibles == _asientos.Length) 
            {
                lblCantAsientoDisp.Text = _asientosDisponibles.ToString();
                lblCantAsientoOcup.Text = "0";
                lblCantComida.Text = "0";
                lblTotalRecauSinComida.Text = "0";
                lblTotalRecauConComida.Text = "0"; 
                lblPorcentajepgb.Text = "0%";
            }
            else 
            {
                lblCantAsientoDisp.Text = _asientosDisponibles.ToString();
                lblCantAsientoOcup.Text = (asientosConComida + _asientosSinComida).ToString();
                lblCantComida.Text = asientosConComida.ToString();
                lblTotalRecauSinComida.Text = (_asientosSinComida * 25500).ToString();
                lblTotalRecauConComida.Text = (asientosConComida * (25550 + 15000)).ToString();
                lblPorcentajepgb.Text = $"{((asientosConComida + _asientosSinComida) * 100)/ _asientos.Length }%";
            }
        }

        private void cambiarColorAsiento(int indiceAsiento,int estado) 
        {
            foreach(Control c in grpAsientos.Controls)
            {
                    if (c is Label)
                    {
                        if (c.TabIndex == indiceAsiento)
                        {
                            c.BackColor = _colores[estado];
                        }
                    }
            }
        }
    }
}
