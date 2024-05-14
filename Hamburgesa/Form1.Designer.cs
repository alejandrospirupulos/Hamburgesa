namespace Hamburgesa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstResumen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.optGrande = new System.Windows.Forms.RadioButton();
            this.optMediano = new System.Windows.Forms.RadioButton();
            this.optChico = new System.Windows.Forms.RadioButton();
            this.cmbBurger = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lstResumen
            // 
            this.lstResumen.FormattingEnabled = true;
            this.lstResumen.Location = new System.Drawing.Point(238, 164);
            this.lstResumen.Name = "lstResumen";
            this.lstResumen.Size = new System.Drawing.Size(120, 95);
            this.lstResumen.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(238, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(238, 126);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 18;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Burger";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(75, 217);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "button1";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // optGrande
            // 
            this.optGrande.AutoSize = true;
            this.optGrande.Location = new System.Drawing.Point(75, 184);
            this.optGrande.Name = "optGrande";
            this.optGrande.Size = new System.Drawing.Size(85, 17);
            this.optGrande.TabIndex = 14;
            this.optGrande.TabStop = true;
            this.optGrande.Text = "radioButton3";
            this.optGrande.UseVisualStyleBackColor = true;
            this.optGrande.CheckedChanged += new System.EventHandler(this.optGrande_CheckedChanged);
            // 
            // optMediano
            // 
            this.optMediano.AutoSize = true;
            this.optMediano.Location = new System.Drawing.Point(75, 149);
            this.optMediano.Name = "optMediano";
            this.optMediano.Size = new System.Drawing.Size(85, 17);
            this.optMediano.TabIndex = 13;
            this.optMediano.TabStop = true;
            this.optMediano.Text = "radioButton2";
            this.optMediano.UseVisualStyleBackColor = true;
            this.optMediano.CheckedChanged += new System.EventHandler(this.optMediano_CheckedChanged);
            // 
            // optChico
            // 
            this.optChico.AutoSize = true;
            this.optChico.Location = new System.Drawing.Point(75, 117);
            this.optChico.Name = "optChico";
            this.optChico.Size = new System.Drawing.Size(85, 17);
            this.optChico.TabIndex = 12;
            this.optChico.TabStop = true;
            this.optChico.Text = "radioButton1";
            this.optChico.UseVisualStyleBackColor = true;
            this.optChico.CheckedChanged += new System.EventHandler(this.optChico_CheckedChanged);
            // 
            // cmbBurger
            // 
            this.cmbBurger.FormattingEnabled = true;
            this.cmbBurger.Location = new System.Drawing.Point(75, 68);
            this.cmbBurger.Name = "cmbBurger";
            this.cmbBurger.Size = new System.Drawing.Size(121, 21);
            this.cmbBurger.TabIndex = 11;
            this.cmbBurger.SelectedIndexChanged += new System.EventHandler(this.cmbBurger_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(303, 265);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "TOTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstResumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.optGrande);
            this.Controls.Add(this.optMediano);
            this.Controls.Add(this.optChico);
            this.Controls.Add(this.cmbBurger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResumen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton optGrande;
        private System.Windows.Forms.RadioButton optMediano;
        private System.Windows.Forms.RadioButton optChico;
        private System.Windows.Forms.ComboBox cmbBurger;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
    }
}

