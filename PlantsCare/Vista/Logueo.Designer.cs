namespace PlantsCare
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.pictureBox3 = new System.Windows.Forms.PictureBox();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// textBox1
        	// 
        	this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBox1.Location = new System.Drawing.Point(163, 120);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(222, 29);
        	this.textBox1.TabIndex = 2;
        	this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        	// 
        	// textBox2
        	// 
        	this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBox2.Location = new System.Drawing.Point(163, 231);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(222, 29);
        	this.textBox2.TabIndex = 3;
        	this.textBox2.UseSystemPasswordChar = true;
        	this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(165, 19);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(101, 39);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Login";
        	this.label1.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// pictureBox3
        	// 
        	this.pictureBox3.Image = global::PlantsCare.Properties.Resources.login2;
        	this.pictureBox3.Location = new System.Drawing.Point(172, 289);
        	this.pictureBox3.Name = "pictureBox3";
        	this.pictureBox3.Size = new System.Drawing.Size(175, 62);
        	this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox3.TabIndex = 6;
        	this.pictureBox3.TabStop = false;
        	this.pictureBox3.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.Image = global::PlantsCare.Properties.Resources.user;
        	this.pictureBox2.Location = new System.Drawing.Point(41, 88);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(86, 85);
        	this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox2.TabIndex = 5;
        	this.pictureBox2.TabStop = false;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = global::PlantsCare.Properties.Resources.password;
        	this.pictureBox1.Location = new System.Drawing.Point(41, 201);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(82, 81);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox1.TabIndex = 1;
        	this.pictureBox1.TabStop = false;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.Control;
        	this.ClientSize = new System.Drawing.Size(435, 391);
        	this.Controls.Add(this.pictureBox3);
        	this.Controls.Add(this.pictureBox2);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.label1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "PlantsCare";
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        
        
    }
}

