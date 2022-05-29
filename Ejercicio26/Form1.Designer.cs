
namespace Ejercicio26
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.lboxMuestra = new System.Windows.Forms.ListBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.radio_becario = new System.Windows.Forms.RadioButton();
            this.radio_obrero = new System.Windows.Forms.RadioButton();
            this.radio_cualificado = new System.Windows.Forms.RadioButton();
            this.lbl_crear = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 52);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 257);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(13, 21);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(156, 20);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "Listado de empleados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sueldo base";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(227, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(227, 206);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(125, 27);
            this.txtDni.TabIndex = 8;
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Location = new System.Drawing.Point(227, 282);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(125, 27);
            this.txtSueldoBase.TabIndex = 9;
            // 
            // lboxMuestra
            // 
            this.lboxMuestra.FormattingEnabled = true;
            this.lboxMuestra.ItemHeight = 20;
            this.lboxMuestra.Location = new System.Drawing.Point(391, 63);
            this.lboxMuestra.Name = "lboxMuestra";
            this.lboxMuestra.Size = new System.Drawing.Size(335, 184);
            this.lboxMuestra.TabIndex = 10;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(227, 385);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(113, 53);
            this.btn_crear.TabIndex = 11;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(357, 385);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(106, 53);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar seleccionado";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // radio_becario
            // 
            this.radio_becario.AutoSize = true;
            this.radio_becario.Location = new System.Drawing.Point(204, 344);
            this.radio_becario.Name = "radio_becario";
            this.radio_becario.Size = new System.Drawing.Size(80, 24);
            this.radio_becario.TabIndex = 13;
            this.radio_becario.TabStop = true;
            this.radio_becario.Text = "Becario";
            this.radio_becario.UseVisualStyleBackColor = true;
            // 
            // radio_obrero
            // 
            this.radio_obrero.AutoSize = true;
            this.radio_obrero.Location = new System.Drawing.Point(357, 346);
            this.radio_obrero.Name = "radio_obrero";
            this.radio_obrero.Size = new System.Drawing.Size(77, 24);
            this.radio_obrero.TabIndex = 14;
            this.radio_obrero.TabStop = true;
            this.radio_obrero.Text = "Obrero";
            this.radio_obrero.UseVisualStyleBackColor = true;
            // 
            // radio_cualificado
            // 
            this.radio_cualificado.AutoSize = true;
            this.radio_cualificado.Location = new System.Drawing.Point(520, 346);
            this.radio_cualificado.Name = "radio_cualificado";
            this.radio_cualificado.Size = new System.Drawing.Size(105, 24);
            this.radio_cualificado.TabIndex = 15;
            this.radio_cualificado.TabStop = true;
            this.radio_cualificado.Text = "Cualificado";
            this.radio_cualificado.UseVisualStyleBackColor = true;
            // 
            // lbl_crear
            // 
            this.lbl_crear.AutoSize = true;
            this.lbl_crear.Location = new System.Drawing.Point(13, 346);
            this.lbl_crear.Name = "lbl_crear";
            this.lbl_crear.Size = new System.Drawing.Size(163, 20);
            this.lbl_crear.TabIndex = 16;
            this.lbl_crear.Text = "Tipo empleado a crear:";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(100, 385);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(112, 53);
            this.btn_mostrar.TabIndex = 17;
            this.btn_mostrar.Text = "Mostrar seleccionado";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datos del empleado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.lbl_crear);
            this.Controls.Add(this.radio_cualificado);
            this.Controls.Add(this.radio_obrero);
            this.Controls.Add(this.radio_becario);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lboxMuestra);
            this.Controls.Add(this.txtSueldoBase);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSueldoBase;
        private System.Windows.Forms.ListBox lboxMuestra;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.RadioButton radio_becario;
        private System.Windows.Forms.RadioButton radio_obrero;
        private System.Windows.Forms.RadioButton radio_cualificado;
        private System.Windows.Forms.Label lbl_crear;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label label5;
    }
}

