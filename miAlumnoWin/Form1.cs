using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace miAlumnoWin
{
    public partial class frmAlumno : Form
    {
        Alumno a;
        //contador
        int contador = 0;

        //acumulador
        double acumulador = 0;
        double promGral = 0;

        public frmAlumno()
        {
            InitializeComponent();
        }

        //creamos el alumno "a" cuando le damos clic al boton registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //quiero validar que el valor que asigna el usuario es número (y no texto)
            if (txtLegajo.Text == "")
                {
                    MessageBox.Show("Por favor el legajo debe ser completado");
                }

            else
                { 
                //nuevo alumno
                    // Alumno a;
                    a = new Alumno();
                    a.pLegajo = Convert.ToInt32(txtLegajo.Text); //convierto de text a int32 el valor de legajo
                    a.pNombre = txtNombre.Text; //aca no hace falta convertir
                    a.pDocumento = Convert.ToInt32(txtDocumentacion.Text);
                    a.pTipoDoc = Convert.ToInt32(cboTipoDoc.SelectedIndex)+1;
                    a.pFechaNac = TimeNacim.Value;
                    a.pNota1 = Convert.ToDouble(txtNota1.Text);
                    a.pNota2 = Convert.ToDouble(txtNota2.Text);

                    txtPromedio.Text = Convert.ToString(a.calcularPromedio());

                    MessageBox.Show(a.toString(), "Información");
                    
                    //contador
                    contador++;
                    lblQAlum.Text = Convert.ToString(contador);
                    
                    //acumulador
                    acumulador = acumulador + a.calcularPromedio();
                    promGral = acumulador / contador;
                    lblPROM.Text = Convert.ToString(promGral);

                }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDocumentacion.Text = "";
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtPromedio.Text = "";
            cboTipoDoc.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
