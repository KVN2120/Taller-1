namespace Ejercicio_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre = new System.Windows.Forms.Label();
            this.lblhorast = new System.Windows.Forms.Label();
            this.lblhorasex = new System.Windows.Forms.Label();
            this.txthorast = new System.Windows.Forms.TextBox();
            this.txthorasex = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.lbldes = new System.Windows.Forms.Label();
            this.lblsueldoliq = new System.Windows.Forms.Label();
            this.txtsueldob = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtsueldoliq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(149, 29);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(123, 22);
            this.txtnombre.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblcargo);
            this.groupBox1.Controls.Add(this.lblhorasex);
            this.groupBox1.Controls.Add(this.txthorasex);
            this.groupBox1.Controls.Add(this.txthorast);
            this.groupBox1.Controls.Add(this.lblhorast);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(13, 32);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(121, 16);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre Completo:";
            // 
            // lblhorast
            // 
            this.lblhorast.AutoSize = true;
            this.lblhorast.Location = new System.Drawing.Point(14, 82);
            this.lblhorast.Name = "lblhorast";
            this.lblhorast.Size = new System.Drawing.Size(122, 16);
            this.lblhorast.TabIndex = 2;
            this.lblhorast.Text = "Horas Trabajadas:";
            // 
            // lblhorasex
            // 
            this.lblhorasex.AutoSize = true;
            this.lblhorasex.Location = new System.Drawing.Point(31, 138);
            this.lblhorasex.Name = "lblhorasex";
            this.lblhorasex.Size = new System.Drawing.Size(78, 16);
            this.lblhorasex.TabIndex = 4;
            this.lblhorasex.Text = "Horas Exra:";
            // 
            // txthorast
            // 
            this.txthorast.Location = new System.Drawing.Point(149, 79);
            this.txthorast.Name = "txthorast";
            this.txthorast.Size = new System.Drawing.Size(123, 22);
            this.txthorast.TabIndex = 5;
            // 
            // txthorasex
            // 
            this.txthorasex.Location = new System.Drawing.Point(149, 135);
            this.txthorasex.Name = "txthorasex";
            this.txthorasex.Size = new System.Drawing.Size(123, 22);
            this.txthorasex.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtsueldoliq);
            this.groupBox2.Controls.Add(this.txtdes);
            this.groupBox2.Controls.Add(this.txtsueldob);
            this.groupBox2.Controls.Add(this.lblsueldoliq);
            this.groupBox2.Controls.Add(this.lbldes);
            this.groupBox2.Controls.Add(this.lblsueldo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados:";
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Location = new System.Drawing.Point(24, 57);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(89, 16);
            this.lblsueldo.TabIndex = 3;
            this.lblsueldo.Text = "Sueldo Base:";
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Location = new System.Drawing.Point(33, 98);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(76, 16);
            this.lbldes.TabIndex = 4;
            this.lbldes.Text = "Descuento:";
            // 
            // lblsueldoliq
            // 
            this.lblsueldoliq.AutoSize = true;
            this.lblsueldoliq.Location = new System.Drawing.Point(16, 145);
            this.lblsueldoliq.Name = "lblsueldoliq";
            this.lblsueldoliq.Size = new System.Drawing.Size(97, 16);
            this.lblsueldoliq.TabIndex = 5;
            this.lblsueldoliq.Text = "Sueldo liquido:";
            // 
            // txtsueldob
            // 
            this.txtsueldob.Location = new System.Drawing.Point(149, 51);
            this.txtsueldob.Name = "txtsueldob";
            this.txtsueldob.Size = new System.Drawing.Size(123, 22);
            this.txtsueldob.TabIndex = 7;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(149, 92);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(123, 22);
            this.txtdes.TabIndex = 8;
            // 
            // txtsueldoliq
            // 
            this.txtsueldoliq.Location = new System.Drawing.Point(149, 139);
            this.txtsueldoliq.Name = "txtsueldoliq";
            this.txtsueldoliq.Size = new System.Drawing.Size(123, 22);
            this.txtsueldoliq.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sueldo de un empleado";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(349, 85);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(48, 16);
            this.lblcargo.TabIndex = 7;
            this.lblcargo.Text = "Cargo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Salario de un empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblhorasex;
        private System.Windows.Forms.TextBox txthorasex;
        private System.Windows.Forms.TextBox txthorast;
        private System.Windows.Forms.Label lblhorast;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsueldoliq;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtsueldob;
        private System.Windows.Forms.Label lblsueldoliq;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblcargo;
    }
}

