namespace Restaurant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabInicio = new System.Windows.Forms.TabControl();
            this.InicioTab = new System.Windows.Forms.TabPage();
            this.MozosTab = new System.Windows.Forms.TabPage();
            this.MesasTab = new System.Windows.Forms.TabPage();
            this.PlatosTab = new System.Windows.Forms.TabPage();
            this.PromocionesTab = new System.Windows.Forms.TabPage();
            this.VentasTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabInicio.SuspendLayout();
            this.InicioTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.InicioTab);
            this.tabInicio.Controls.Add(this.VentasTab);
            this.tabInicio.Controls.Add(this.MozosTab);
            this.tabInicio.Controls.Add(this.MesasTab);
            this.tabInicio.Controls.Add(this.PlatosTab);
            this.tabInicio.Controls.Add(this.PromocionesTab);
            this.tabInicio.Location = new System.Drawing.Point(0, 0);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.SelectedIndex = 0;
            this.tabInicio.Size = new System.Drawing.Size(728, 512);
            this.tabInicio.TabIndex = 0;
            // 
            // InicioTab
            // 
            this.InicioTab.Controls.Add(this.textBox2);
            this.InicioTab.Controls.Add(this.textBox1);
            this.InicioTab.Location = new System.Drawing.Point(4, 22);
            this.InicioTab.Name = "InicioTab";
            this.InicioTab.Padding = new System.Windows.Forms.Padding(3);
            this.InicioTab.Size = new System.Drawing.Size(720, 486);
            this.InicioTab.TabIndex = 0;
            this.InicioTab.Text = "Inicio";
            this.InicioTab.UseVisualStyleBackColor = true;
            // 
            // MozosTab
            // 
            this.MozosTab.Location = new System.Drawing.Point(4, 22);
            this.MozosTab.Name = "MozosTab";
            this.MozosTab.Padding = new System.Windows.Forms.Padding(3);
            this.MozosTab.Size = new System.Drawing.Size(720, 486);
            this.MozosTab.TabIndex = 1;
            this.MozosTab.Text = "Mozos";
            this.MozosTab.UseVisualStyleBackColor = true;
            // 
            // MesasTab
            // 
            this.MesasTab.Location = new System.Drawing.Point(4, 22);
            this.MesasTab.Name = "MesasTab";
            this.MesasTab.Size = new System.Drawing.Size(720, 486);
            this.MesasTab.TabIndex = 2;
            this.MesasTab.Text = "Mesas";
            this.MesasTab.UseVisualStyleBackColor = true;
            // 
            // PlatosTab
            // 
            this.PlatosTab.Location = new System.Drawing.Point(4, 22);
            this.PlatosTab.Name = "PlatosTab";
            this.PlatosTab.Size = new System.Drawing.Size(720, 486);
            this.PlatosTab.TabIndex = 3;
            this.PlatosTab.Text = "Platos";
            this.PlatosTab.UseVisualStyleBackColor = true;
            // 
            // PromocionesTab
            // 
            this.PromocionesTab.Location = new System.Drawing.Point(4, 22);
            this.PromocionesTab.Name = "PromocionesTab";
            this.PromocionesTab.Size = new System.Drawing.Size(720, 486);
            this.PromocionesTab.TabIndex = 4;
            this.PromocionesTab.Text = "Promociones";
            this.PromocionesTab.UseVisualStyleBackColor = true;
            // 
            // VentasTab
            // 
            this.VentasTab.Location = new System.Drawing.Point(4, 22);
            this.VentasTab.Name = "VentasTab";
            this.VentasTab.Size = new System.Drawing.Size(720, 486);
            this.VentasTab.TabIndex = 5;
            this.VentasTab.Text = "Ventas";
            this.VentasTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(521, 71);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Bienvenidos al Sistema de Administracion de Restaurants";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(123, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(501, 19);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Para comenzar, haga click en la pestaña correspondiente acorde a sus necesidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 512);
            this.Controls.Add(this.tabInicio);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Restaurant v1";
            this.tabInicio.ResumeLayout(false);
            this.InicioTab.ResumeLayout(false);
            this.InicioTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInicio;
        private System.Windows.Forms.TabPage InicioTab;
        private System.Windows.Forms.TabPage VentasTab;
        private System.Windows.Forms.TabPage MozosTab;
        private System.Windows.Forms.TabPage MesasTab;
        private System.Windows.Forms.TabPage PlatosTab;
        private System.Windows.Forms.TabPage PromocionesTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

