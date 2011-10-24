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
            this.button_mozo_alta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_mozo_alta_nombre = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_mozo_alta_dir = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_mozo_alta_dni = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox_mozo_alta_sector = new System.Windows.Forms.ComboBox();
            this.button_mozo_alta_aceptar = new System.Windows.Forms.Button();
            this.button_mozo_alta_cancelar = new System.Windows.Forms.Button();
            this.textBox_mozo_alta_exito = new System.Windows.Forms.TextBox();
            this.tabInicio.SuspendLayout();
            this.InicioTab.SuspendLayout();
            this.MozosTab.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MozosTab.Controls.Add(this.panel1);
            this.MozosTab.Controls.Add(this.button_mozo_alta);
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
            // button_mozo_alta
            // 
            this.button_mozo_alta.Location = new System.Drawing.Point(34, 58);
            this.button_mozo_alta.Name = "button_mozo_alta";
            this.button_mozo_alta.Size = new System.Drawing.Size(102, 38);
            this.button_mozo_alta.TabIndex = 0;
            this.button_mozo_alta.Text = "Dar de alta un nuevo mozo";
            this.button_mozo_alta.UseVisualStyleBackColor = true;
            this.button_mozo_alta.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_mozo_alta_exito);
            this.panel1.Controls.Add(this.button_mozo_alta_cancelar);
            this.panel1.Controls.Add(this.button_mozo_alta_aceptar);
            this.panel1.Controls.Add(this.comboBox_mozo_alta_sector);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox_mozo_alta_dni);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox_mozo_alta_dir);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox_mozo_alta_nombre);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(193, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 425);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(28, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(157, 13);
            this.textBox3.TabIndex = 0;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Nombre y Apellido";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_mozo_alta_nombre
            // 
            this.textBox_mozo_alta_nombre.Location = new System.Drawing.Point(208, 20);
            this.textBox_mozo_alta_nombre.Name = "textBox_mozo_alta_nombre";
            this.textBox_mozo_alta_nombre.Size = new System.Drawing.Size(253, 20);
            this.textBox_mozo_alta_nombre.TabIndex = 1;
            this.textBox_mozo_alta_nombre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(28, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(157, 13);
            this.textBox5.TabIndex = 3;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Direccion";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox_mozo_alta_dir
            // 
            this.textBox_mozo_alta_dir.Location = new System.Drawing.Point(208, 72);
            this.textBox_mozo_alta_dir.Name = "textBox_mozo_alta_dir";
            this.textBox_mozo_alta_dir.Size = new System.Drawing.Size(253, 20);
            this.textBox_mozo_alta_dir.TabIndex = 4;
            this.textBox_mozo_alta_dir.TextChanged += new System.EventHandler(this.textBox_mozo_alta_dir_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(28, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(157, 13);
            this.textBox4.TabIndex = 5;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "DNI";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textBox_mozo_alta_dni
            // 
            this.textBox_mozo_alta_dni.Location = new System.Drawing.Point(208, 123);
            this.textBox_mozo_alta_dni.Name = "textBox_mozo_alta_dni";
            this.textBox_mozo_alta_dni.Size = new System.Drawing.Size(253, 20);
            this.textBox_mozo_alta_dni.TabIndex = 6;
            this.textBox_mozo_alta_dni.TextChanged += new System.EventHandler(this.textBox_mozo_alta_dni_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(28, 170);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(157, 13);
            this.textBox6.TabIndex = 7;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Sector";
            // 
            // comboBox_mozo_alta_sector
            // 
            this.comboBox_mozo_alta_sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mozo_alta_sector.FormattingEnabled = true;
            this.comboBox_mozo_alta_sector.Location = new System.Drawing.Point(208, 170);
            this.comboBox_mozo_alta_sector.MaxDropDownItems = 10;
            this.comboBox_mozo_alta_sector.Name = "comboBox_mozo_alta_sector";
            this.comboBox_mozo_alta_sector.Size = new System.Drawing.Size(67, 21);
            this.comboBox_mozo_alta_sector.TabIndex = 8;
            this.comboBox_mozo_alta_sector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_mozo_alta_aceptar
            // 
            this.button_mozo_alta_aceptar.Location = new System.Drawing.Point(110, 247);
            this.button_mozo_alta_aceptar.Name = "button_mozo_alta_aceptar";
            this.button_mozo_alta_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_mozo_alta_aceptar.TabIndex = 9;
            this.button_mozo_alta_aceptar.Text = "Aceptar";
            this.button_mozo_alta_aceptar.UseVisualStyleBackColor = true;
            this.button_mozo_alta_aceptar.Click += new System.EventHandler(this.button_mozo_alta_aceptar_Click);
            // 
            // button_mozo_alta_cancelar
            // 
            this.button_mozo_alta_cancelar.Location = new System.Drawing.Point(312, 247);
            this.button_mozo_alta_cancelar.Name = "button_mozo_alta_cancelar";
            this.button_mozo_alta_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_mozo_alta_cancelar.TabIndex = 10;
            this.button_mozo_alta_cancelar.Text = "Cancelar";
            this.button_mozo_alta_cancelar.UseVisualStyleBackColor = true;
            this.button_mozo_alta_cancelar.Click += new System.EventHandler(this.button_mozo_alta_cancelar_Click);
            // 
            // textBox_mozo_alta_exito
            // 
            this.textBox_mozo_alta_exito.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_mozo_alta_exito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mozo_alta_exito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mozo_alta_exito.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBox_mozo_alta_exito.Location = new System.Drawing.Point(44, 319);
            this.textBox_mozo_alta_exito.Multiline = true;
            this.textBox_mozo_alta_exito.Name = "textBox_mozo_alta_exito";
            this.textBox_mozo_alta_exito.ReadOnly = true;
            this.textBox_mozo_alta_exito.Size = new System.Drawing.Size(231, 20);
            this.textBox_mozo_alta_exito.TabIndex = 11;
            this.textBox_mozo_alta_exito.TabStop = false;
            this.textBox_mozo_alta_exito.Text = "Alta del nuevo mozo realizada con éxito";
            this.textBox_mozo_alta_exito.Visible = false;
            this.textBox_mozo_alta_exito.TextChanged += new System.EventHandler(this.textBox_mozo_alta_exito_TextChanged);
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
            this.MozosTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button_mozo_alta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_mozo_alta_nombre;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox_mozo_alta_sector;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_mozo_alta_dni;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_mozo_alta_dir;
        private System.Windows.Forms.Button button_mozo_alta_aceptar;
        private System.Windows.Forms.Button button_mozo_alta_cancelar;
        private System.Windows.Forms.TextBox textBox_mozo_alta_exito;
    }
}

