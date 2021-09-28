
namespace miniCajrtoAutomatico
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btdepositar = new System.Windows.Forms.Button();
            this.btextraer = new System.Windows.Forms.Button();
            this.lblsaldofinal = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(184, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(411, 42);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "mini cajero automatico";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(65, 169);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(207, 29);
            this.lblcantidad.TabIndex = 1;
            this.lblcantidad.Text = "ingrese cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.Location = new System.Drawing.Point(65, 218);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(77, 29);
            this.lblsaldo.TabIndex = 3;
            this.lblsaldo.Text = "saldo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btdepositar
            // 
            this.btdepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btdepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdepositar.Location = new System.Drawing.Point(596, 177);
            this.btdepositar.Name = "btdepositar";
            this.btdepositar.Size = new System.Drawing.Size(146, 55);
            this.btdepositar.TabIndex = 5;
            this.btdepositar.Text = "depositar";
            this.btdepositar.UseVisualStyleBackColor = false;
            this.btdepositar.Click += new System.EventHandler(this.btdepositar_Click);
            // 
            // btextraer
            // 
            this.btextraer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btextraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btextraer.Location = new System.Drawing.Point(596, 261);
            this.btextraer.Name = "btextraer";
            this.btextraer.Size = new System.Drawing.Size(146, 40);
            this.btextraer.TabIndex = 6;
            this.btextraer.Text = "extraer";
            this.btextraer.UseVisualStyleBackColor = false;
            this.btextraer.Click += new System.EventHandler(this.btextraer_Click);
            // 
            // lblsaldofinal
            // 
            this.lblsaldofinal.AutoSize = true;
            this.lblsaldofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldofinal.Location = new System.Drawing.Point(65, 276);
            this.lblsaldofinal.Name = "lblsaldofinal";
            this.lblsaldofinal.Size = new System.Drawing.Size(121, 25);
            this.lblsaldofinal.TabIndex = 7;
            this.lblsaldofinal.Text = "saldo final";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(319, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblsaldofinal);
            this.Controls.Add(this.btextraer);
            this.Controls.Add(this.btdepositar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "miniCajeroAutomatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btdepositar;
        private System.Windows.Forms.Button btextraer;
        private System.Windows.Forms.Label lblsaldofinal;
        private System.Windows.Forms.TextBox textBox3;
    }
}

