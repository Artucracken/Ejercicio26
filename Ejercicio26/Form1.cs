using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio26
{
    public partial class Form1 : Form
    {

        //
        //  EJERCICIO 26 CREADO EL 13 DE MARZO DE 2022, ENTORNOS DE DESARROLLO
        //
        public Form1()
        {
            InitializeComponent();
           
        }
        List<Empleados> empleados = new List<Empleados>();
        Obrero obrero = new Obrero();
        Cualificados cualificado = new Cualificados();
        Becario becario = new Becario();
        private void btn_crear_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            double sueldo = Convert.ToInt32(txtSueldoBase.Text);
            

            if (radio_becario.Checked ==false && radio_cualificado.Checked == false && radio_obrero.Checked == false )
            {
                MessageBox.Show("selecciona un tipo de empleado primero");
            }
            if(radio_becario.Checked == true)
            {
                Becario becario = new Becario(nombre, apellido, dni, sueldo);
                ListViewItem itemBecario = new ListViewItem(becario.dameNombre());
                listView1.Items.Add(itemBecario);
                string carrera = Microsoft.VisualBasic.Interaction.InputBox("Que carrera esta cursando?", "Carrera", "...");
                string curso = Microsoft.VisualBasic.Interaction.InputBox("En que curso esta?", "Curso", "...");
                string departamento = Microsoft.VisualBasic.Interaction.InputBox("A que departamento pertenece?", "Departamento", "...");
                becario.Departamento = departamento;
                becario.Carrera = carrera;
                becario.Curso = curso;
                empleados.Add(becario);
            }
            
            if(radio_obrero.Checked == true)
            {
               Obrero obrero = new Obrero(nombre, apellido, dni, sueldo);
                ListViewItem itemObrero = new ListViewItem(obrero.dameNombre());
                string destino = Microsoft.VisualBasic.Interaction.InputBox("Cual es su destino?", "Destino", "...");
                itemObrero.SubItems.Add(obrero.dameDni());
                listView1.Items.Add(itemObrero);
                double hExtra = Convert.ToDouble( Microsoft.VisualBasic.Interaction.InputBox("A cuanto cobra la hora extra?", "Horas extra", "..."));
                obrero.PrecioHE = hExtra;
                obrero.DestinoTrabajo = destino;
                empleados.Add(obrero);
            }
            if (radio_cualificado.Checked == true)
            {
                Cualificados cualificado = new Cualificados(nombre, apellido, dni, sueldo);
                ListViewItem itemCualificado = new ListViewItem(cualificado.dameNombre());
                listView1.Items.Add(itemCualificado);
                string titulacion = Microsoft.VisualBasic.Interaction.InputBox("Cual es su titulación?", "Titulación", "...");
                int plus = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Cuanto es su plus?", "Plus", "..."));
                string departamento = Microsoft.VisualBasic.Interaction.InputBox("A que departamento pertenece?", "Departamento", "...");
                cualificado.Titulacion = titulacion;
                cualificado.Plus = plus;
                cualificado.Departamento = departamento;
                empleados.Add(cualificado);
            }


        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            lboxMuestra.Items.Clear();
            lboxMuestra.Items.Add(listView1.SelectedItems[0].SubItems[0].Text);
  
            foreach( Empleados empleado in empleados){
                
                if (empleado is Obrero)
                {               
                    obrero = (Obrero)empleado;
                    if ( listView1.SelectedItems[0].Text == obrero.dameNombre())
                    {
                        
                        lboxMuestra.Items.Add(obrero.dameDni());
                        lboxMuestra.Items.Add(obrero.dameSueldo());
                        lboxMuestra.Items.Add(obrero.informacion());
                    }
                }
                else if(empleado is Cualificados)
                {
                    cualificado = (Cualificados)empleado;
                    if (listView1.SelectedItems[0].Text == cualificado.dameNombre())
                    {
                        
                        lboxMuestra.Items.Add(cualificado.dameDni());
                        lboxMuestra.Items.Add(cualificado.dameSueldo());
                        lboxMuestra.Items.Add(cualificado.informacion());
                    }
                }
                else if (empleado is Becario)
                {
                    becario = (Becario)empleado;
                    if (listView1.SelectedItems[0].Text == becario.dameNombre())
                    {
                       
                        lboxMuestra.Items.Add(becario.dameDni());
                        lboxMuestra.Items.Add(becario.dameSueldo());
                        lboxMuestra.Items.Add(becario.informacion());
                        lboxMuestra.Items.Add(becario.notaMedia());
                    }
                }

            }
   
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            /* for(int i=0;i<empleados.Count; i++)
             {
                 if (empleados[i] is Obrero)
                 {
                     if (listView1.SelectedItems[0].SubItems[0].Text == obrero.dameDni())
                     {
                         Obrero obreroVacio = new Obrero();
                         empleados[i] = obreroVacio;
                         listView1.SelectedItems[0].Remove();
                     }
                 }
             }*/
            listView1.SelectedItems[0].Remove();
        }
    }
}
