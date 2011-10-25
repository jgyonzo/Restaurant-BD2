namespace Restaurant
{
    partial class Yonzo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonzo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TabResumen = new System.Windows.Forms.TabPage();
            this.groupResumen = new System.Windows.Forms.GroupBox();
            this.groupAcciones = new System.Windows.Forms.GroupBox();
            this.butCerrarMesaRapida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butAbrirMesaRapida = new System.Windows.Forms.Button();
            this.butCargarPedidoRapido = new System.Windows.Forms.Button();
            this.groupMesas = new System.Windows.Forms.GroupBox();
            this.groupPromociones = new System.Windows.Forms.GroupBox();
            this.TabMozos = new System.Windows.Forms.TabPage();
            this.TabVentas_Pedidos = new System.Windows.Forms.TabPage();
            this.TabConsultas = new System.Windows.Forms.TabPage();
            this.TabPlatos_Promos = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AcercaDeLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tabs.SuspendLayout();
            this.TabResumen.SuspendLayout();
            this.groupAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant.Properties.Resources.icono21;
            this.pictureBox1.Location = new System.Drawing.Point(12, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TabResumen);
            this.Tabs.Controls.Add(this.TabMozos);
            this.Tabs.Controls.Add(this.TabVentas_Pedidos);
            this.Tabs.Controls.Add(this.TabConsultas);
            this.Tabs.Controls.Add(this.TabPlatos_Promos);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(591, 328);
            this.Tabs.TabIndex = 1;
            // 
            // TabResumen
            // 
            this.TabResumen.Controls.Add(this.groupResumen);
            this.TabResumen.Controls.Add(this.groupAcciones);
            this.TabResumen.Controls.Add(this.groupMesas);
            this.TabResumen.Controls.Add(this.groupPromociones);
            this.TabResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabResumen.Location = new System.Drawing.Point(4, 22);
            this.TabResumen.Name = "TabResumen";
            this.TabResumen.Padding = new System.Windows.Forms.Padding(3);
            this.TabResumen.Size = new System.Drawing.Size(583, 302);
            this.TabResumen.TabIndex = 1;
            this.TabResumen.Text = "Resumen";
            this.TabResumen.UseVisualStyleBackColor = true;
            // 
            // groupResumen
            // 
            this.groupResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResumen.Location = new System.Drawing.Point(290, 3);
            this.groupResumen.Name = "groupResumen";
            this.groupResumen.Size = new System.Drawing.Size(291, 133);
            this.groupResumen.TabIndex = 3;
            this.groupResumen.TabStop = false;
            this.groupResumen.Text = "Resumen de ventas";
            // 
            // groupAcciones
            // 
            this.groupAcciones.Controls.Add(this.butCerrarMesaRapida);
            this.groupAcciones.Controls.Add(this.button1);
            this.groupAcciones.Controls.Add(this.butAbrirMesaRapida);
            this.groupAcciones.Controls.Add(this.butCargarPedidoRapido);
            this.groupAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAcciones.Location = new System.Drawing.Point(2, 3);
            this.groupAcciones.Name = "groupAcciones";
            this.groupAcciones.Size = new System.Drawing.Size(282, 134);
            this.groupAcciones.TabIndex = 2;
            this.groupAcciones.TabStop = false;
            this.groupAcciones.Text = "Acciones rapidas";
            // 
            // butCerrarMesaRapida
            // 
            this.butCerrarMesaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCerrarMesaRapida.Location = new System.Drawing.Point(11, 91);
            this.butCerrarMesaRapida.Name = "butCerrarMesaRapida";
            this.butCerrarMesaRapida.Size = new System.Drawing.Size(247, 27);
            this.butCerrarMesaRapida.TabIndex = 3;
            this.butCerrarMesaRapida.Text = "Cerrar Mesa";
            this.butCerrarMesaRapida.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "...disponible...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butAbrirMesaRapida
            // 
            this.butAbrirMesaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAbrirMesaRapida.Location = new System.Drawing.Point(10, 28);
            this.butAbrirMesaRapida.Name = "butAbrirMesaRapida";
            this.butAbrirMesaRapida.Size = new System.Drawing.Size(249, 27);
            this.butAbrirMesaRapida.TabIndex = 1;
            this.butAbrirMesaRapida.Text = "Abrir Mesa";
            this.butAbrirMesaRapida.UseVisualStyleBackColor = true;
            // 
            // butCargarPedidoRapido
            // 
            this.butCargarPedidoRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargarPedidoRapido.Location = new System.Drawing.Point(11, 61);
            this.butCargarPedidoRapido.Name = "butCargarPedidoRapido";
            this.butCargarPedidoRapido.Size = new System.Drawing.Size(123, 24);
            this.butCargarPedidoRapido.TabIndex = 0;
            this.butCargarPedidoRapido.Text = "Cargar Pedido";
            this.butCargarPedidoRapido.UseVisualStyleBackColor = true;
            // 
            // groupMesas
            // 
            this.groupMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMesas.Location = new System.Drawing.Point(291, 137);
            this.groupMesas.Name = "groupMesas";
            this.groupMesas.Size = new System.Drawing.Size(291, 164);
            this.groupMesas.TabIndex = 1;
            this.groupMesas.TabStop = false;
            this.groupMesas.Text = "Mesas libres";
            // 
            // groupPromociones
            // 
            this.groupPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPromociones.Location = new System.Drawing.Point(0, 137);
            this.groupPromociones.Name = "groupPromociones";
            this.groupPromociones.Size = new System.Drawing.Size(285, 169);
            this.groupPromociones.TabIndex = 0;
            this.groupPromociones.TabStop = false;
            this.groupPromociones.Text = "Promociones del dia";
            // 
            // TabMozos
            // 
            this.TabMozos.Location = new System.Drawing.Point(4, 22);
            this.TabMozos.Name = "TabMozos";
            this.TabMozos.Padding = new System.Windows.Forms.Padding(3);
            this.TabMozos.Size = new System.Drawing.Size(583, 302);
            this.TabMozos.TabIndex = 2;
            this.TabMozos.Text = "Mozos";
            this.TabMozos.UseVisualStyleBackColor = true;
            // 
            // TabVentas_Pedidos
            // 
            this.TabVentas_Pedidos.Location = new System.Drawing.Point(4, 22);
            this.TabVentas_Pedidos.Name = "TabVentas_Pedidos";
            this.TabVentas_Pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.TabVentas_Pedidos.Size = new System.Drawing.Size(583, 302);
            this.TabVentas_Pedidos.TabIndex = 3;
            this.TabVentas_Pedidos.Text = "Ventas y Pedidos";
            this.TabVentas_Pedidos.UseVisualStyleBackColor = true;
            // 
            // TabConsultas
            // 
            this.TabConsultas.Location = new System.Drawing.Point(4, 22);
            this.TabConsultas.Name = "TabConsultas";
            this.TabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsultas.Size = new System.Drawing.Size(583, 302);
            this.TabConsultas.TabIndex = 5;
            this.TabConsultas.Text = "Consultas";
            this.TabConsultas.UseVisualStyleBackColor = true;
            // 
            // TabPlatos_Promos
            // 
            this.TabPlatos_Promos.Location = new System.Drawing.Point(4, 22);
            this.TabPlatos_Promos.Name = "TabPlatos_Promos";
            this.TabPlatos_Promos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlatos_Promos.Size = new System.Drawing.Size(583, 302);
            this.TabPlatos_Promos.TabIndex = 6;
            this.TabPlatos_Promos.Text = "Platos y Promociones";
            this.TabPlatos_Promos.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(494, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // butRefresh
            // 
            this.butRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.Location = new System.Drawing.Point(251, 342);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(108, 34);
            this.butRefresh.TabIndex = 3;
            this.butRefresh.Text = "Recargar info";
            this.butRefresh.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurant.Properties.Resources.Refresh;
            this.pictureBox2.Location = new System.Drawing.Point(204, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // AcercaDeLink
            // 
            this.AcercaDeLink.AutoSize = true;
            this.AcercaDeLink.Location = new System.Drawing.Point(25, 408);
            this.AcercaDeLink.Name = "AcercaDeLink";
            this.AcercaDeLink.Size = new System.Drawing.Size(65, 13);
            this.AcercaDeLink.TabIndex = 5;
            this.AcercaDeLink.TabStop = true;
            this.AcercaDeLink.Text = "Acerca de...";
            // 
            // Yonzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.AcercaDeLink);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yonzo";
            this.Text = "Restaurant.NET";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.TabResumen.ResumeLayout(false);
            this.groupAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TabResumen;
        private System.Windows.Forms.TabPage TabMozos;
        private System.Windows.Forms.TabPage TabVentas_Pedidos;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupResumen;
        private System.Windows.Forms.GroupBox groupAcciones;
        private System.Windows.Forms.GroupBox groupMesas;
        private System.Windows.Forms.GroupBox groupPromociones;
        private System.Windows.Forms.Button butAbrirMesaRapida;
        private System.Windows.Forms.Button butCargarPedidoRapido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butCerrarMesaRapida;
        private System.Windows.Forms.TabPage TabConsultas;
        private System.Windows.Forms.TabPage TabPlatos_Promos;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel AcercaDeLink;
    }
}