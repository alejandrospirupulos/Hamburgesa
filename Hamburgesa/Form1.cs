using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable global
        string burger;
        int precioBurger;
        int cantidad;
        int tamaño;
        string tamañoSeleccionado;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Cambie las propiedades de los componentes checkliste,radiobutton y button 
            cmbBurger.Items.Add("Burger A");
            cmbBurger.Items.Add("Burger B");
            cmbBurger.Items.Add("Burger C");

            optChico.Text = "Chico";
            optMediano.Text = "Mediano";
            optGrande.Text = "Grande";

            btnCargar.Text = "Cargar";
            numCantidad.Maximum = 10;
            numCantidad.Minimum = 1;
            numCantidad.Value = 1;


        }

        private void cmbBurger_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creacion de switch

            burger = cmbBurger.SelectedItem.ToString(); 

         switch(burger) {
                case "Burger A":
                    precioBurger = 5;
                    break;
                case "Burger B":
                    precioBurger = 10;
                    break;
                case "Burger C":
                    precioBurger = 20; 
                    break; 

            }
            calcularTotal();

        }
        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(numCantidad.Value);
        }

        public void calcularTotal ()
        {
            lblTotal.Text = $"${((tamaño + precioBurger) * cantidad).ToString()}";
        }

        public void seleccionarCombo () 
        {
            if (optChico.Checked)
            {
                tamaño = 10;
                tamañoSeleccionado = "Chico";
            }
            else if (optMediano.Checked)
            {
                tamaño = 15;
                tamañoSeleccionado = "Mediano";

            }
            else
            {
                tamaño = 20;
                tamañoSeleccionado = "Grande";
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Creacion de var local y creacion de if 

            string nombre = label2.Text;
            
            int total = (precioBurger + tamaño) * cantidad;

            lstResumen.Items.Add($"EL PEDIDO DE {nombre}");
            lstResumen.Items.Add($"Burger:{burger}");
            lstResumen.Items.Add($"tamaño:{tamañoSeleccionado}");
            lstResumen.Items.Add($"total:{total}");
            lstResumen.Items.Add($"cantidad:${cantidad}");
        }

        private void optChico_CheckedChanged(object sender, EventArgs e)
        {
            seleccionarCombo();
            calcularTotal();
        }

        private void optMediano_CheckedChanged(object sender, EventArgs e)
        {
            seleccionarCombo();
            calcularTotal();
        }

        private void optGrande_CheckedChanged(object sender, EventArgs e)
        {
            seleccionarCombo();
            calcularTotal();
        }
    }
}
