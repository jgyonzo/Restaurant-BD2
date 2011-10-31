namespace Restaurant
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TabResumen = new System.Windows.Forms.TabPage();
            this.groupResumen = new System.Windows.Forms.GroupBox();
            this.groupAcciones = new System.Windows.Forms.GroupBox();
            this.ButCerrarMesaRapida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButAbrirMesaRapida = new System.Windows.Forms.Button();
            this.ButCargarPedidoRapido = new System.Windows.Forms.Button();
            this.groupMesas = new System.Windows.Forms.GroupBox();
            this.groupPromociones = new System.Windows.Forms.GroupBox();
            this.TabMozos = new System.Windows.Forms.TabPage();
            this.GroupDatosMozos = new System.Windows.Forms.GroupBox();
            this.LinkClearMozos = new System.Windows.Forms.LinkLabel();
            this.ButtonDeleteMozo = new System.Windows.Forms.Button();
            this.ButtonNewMozo = new System.Windows.Forms.Button();
            this.TextDniMozo = new System.Windows.Forms.TextBox();
            this.TextDirMozo = new System.Windows.Forms.TextBox();
            this.TextNombreMozo = new System.Windows.Forms.TextBox();
            this.ButtonSaveMozos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboMozoSector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelListadoMozos = new System.Windows.Forms.Label();
            this.DataGridMozos = new System.Windows.Forms.DataGridView();
            this.TabVentas_Pedidos = new System.Windows.Forms.TabPage();
            this.TabConsultas = new System.Windows.Forms.TabPage();
            this.TabPlatos = new System.Windows.Forms.TabPage();
            this.GroupDatosPlatos = new System.Windows.Forms.GroupBox();
            this.LinkClearPlatos = new System.Windows.Forms.LinkLabel();
            this.ButtonDeletePlato = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonNewPlato = new System.Windows.Forms.Button();
            this.TextPricePlatoV = new System.Windows.Forms.TextBox();
            this.TextPricePlatoC = new System.Windows.Forms.TextBox();
            this.TextDescPlatos = new System.Windows.Forms.TextBox();
            this.ButtonSavePlato = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxPlatos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DataGridPlatos = new System.Windows.Forms.DataGridView();
            this.TabPromos = new System.Windows.Forms.TabPage();
            this.GroupDataPromo = new System.Windows.Forms.GroupBox();
            this.CheckListPromos = new System.Windows.Forms.CheckedListBox();
            this.LinkClearPromo = new System.Windows.Forms.LinkLabel();
            this.ButtonDeletePromo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ButtonNewPromo = new System.Windows.Forms.Button();
            this.TextPricePromo = new System.Windows.Forms.TextBox();
            this.TextDescPromo = new System.Windows.Forms.TextBox();
            this.ButtonSavePromo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.LabelPrecioPromo = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DataGridPromos = new System.Windows.Forms.DataGridView();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.AcercaDeLink = new System.Windows.Forms.LinkLabel();
            this.TextIdMozo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tabs.SuspendLayout();
            this.TabResumen.SuspendLayout();
            this.groupAcciones.SuspendLayout();
            this.TabMozos.SuspendLayout();
            this.GroupDatosMozos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMozos)).BeginInit();
            this.TabPlatos.SuspendLayout();
            this.GroupDatosPlatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlatos)).BeginInit();
            this.TabPromos.SuspendLayout();
            this.GroupDataPromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPromos)).BeginInit();
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
            this.Tabs.Controls.Add(this.TabPlatos);
            this.Tabs.Controls.Add(this.TabPromos);
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
            this.groupAcciones.Controls.Add(this.ButCerrarMesaRapida);
            this.groupAcciones.Controls.Add(this.button1);
            this.groupAcciones.Controls.Add(this.ButAbrirMesaRapida);
            this.groupAcciones.Controls.Add(this.ButCargarPedidoRapido);
            this.groupAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAcciones.Location = new System.Drawing.Point(2, 3);
            this.groupAcciones.Name = "groupAcciones";
            this.groupAcciones.Size = new System.Drawing.Size(282, 134);
            this.groupAcciones.TabIndex = 2;
            this.groupAcciones.TabStop = false;
            this.groupAcciones.Text = "Acciones rapidas";
            // 
            // ButCerrarMesaRapida
            // 
            this.ButCerrarMesaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCerrarMesaRapida.Location = new System.Drawing.Point(11, 91);
            this.ButCerrarMesaRapida.Name = "ButCerrarMesaRapida";
            this.ButCerrarMesaRapida.Size = new System.Drawing.Size(247, 27);
            this.ButCerrarMesaRapida.TabIndex = 3;
            this.ButCerrarMesaRapida.Text = "Cerrar Mesa";
            this.ButCerrarMesaRapida.UseVisualStyleBackColor = true;
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
            // ButAbrirMesaRapida
            // 
            this.ButAbrirMesaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAbrirMesaRapida.Location = new System.Drawing.Point(10, 28);
            this.ButAbrirMesaRapida.Name = "ButAbrirMesaRapida";
            this.ButAbrirMesaRapida.Size = new System.Drawing.Size(249, 27);
            this.ButAbrirMesaRapida.TabIndex = 1;
            this.ButAbrirMesaRapida.Text = "Abrir Mesa";
            this.ButAbrirMesaRapida.UseVisualStyleBackColor = true;
            // 
            // ButCargarPedidoRapido
            // 
            this.ButCargarPedidoRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCargarPedidoRapido.Location = new System.Drawing.Point(11, 61);
            this.ButCargarPedidoRapido.Name = "ButCargarPedidoRapido";
            this.ButCargarPedidoRapido.Size = new System.Drawing.Size(123, 24);
            this.ButCargarPedidoRapido.TabIndex = 0;
            this.ButCargarPedidoRapido.Text = "Cargar Pedido";
            this.ButCargarPedidoRapido.UseVisualStyleBackColor = true;
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
            this.groupPromociones.Size = new System.Drawing.Size(285, 164);
            this.groupPromociones.TabIndex = 0;
            this.groupPromociones.TabStop = false;
            this.groupPromociones.Text = "Promociones del dia";
            // 
            // TabMozos
            // 
            this.TabMozos.Controls.Add(this.GroupDatosMozos);
            this.TabMozos.Controls.Add(this.LabelListadoMozos);
            this.TabMozos.Controls.Add(this.DataGridMozos);
            this.TabMozos.Location = new System.Drawing.Point(4, 22);
            this.TabMozos.Name = "TabMozos";
            this.TabMozos.Padding = new System.Windows.Forms.Padding(3);
            this.TabMozos.Size = new System.Drawing.Size(583, 302);
            this.TabMozos.TabIndex = 2;
            this.TabMozos.Text = "Mozos";
            this.TabMozos.UseVisualStyleBackColor = true;
            this.TabMozos.Enter += new System.EventHandler(this.TabMozos_Enter);
            // 
            // GroupDatosMozos
            // 
            this.GroupDatosMozos.Controls.Add(this.TextIdMozo);
            this.GroupDatosMozos.Controls.Add(this.LinkClearMozos);
            this.GroupDatosMozos.Controls.Add(this.ButtonDeleteMozo);
            this.GroupDatosMozos.Controls.Add(this.ButtonNewMozo);
            this.GroupDatosMozos.Controls.Add(this.TextDniMozo);
            this.GroupDatosMozos.Controls.Add(this.TextDirMozo);
            this.GroupDatosMozos.Controls.Add(this.TextNombreMozo);
            this.GroupDatosMozos.Controls.Add(this.ButtonSaveMozos);
            this.GroupDatosMozos.Controls.Add(this.label4);
            this.GroupDatosMozos.Controls.Add(this.ComboMozoSector);
            this.GroupDatosMozos.Controls.Add(this.label3);
            this.GroupDatosMozos.Controls.Add(this.label2);
            this.GroupDatosMozos.Controls.Add(this.label1);
            this.GroupDatosMozos.Location = new System.Drawing.Point(6, 155);
            this.GroupDatosMozos.Name = "GroupDatosMozos";
            this.GroupDatosMozos.Size = new System.Drawing.Size(567, 141);
            this.GroupDatosMozos.TabIndex = 4;
            this.GroupDatosMozos.TabStop = false;
            this.GroupDatosMozos.Text = "Datos del empleado";
            // 
            // LinkClearMozos
            // 
            this.LinkClearMozos.AutoSize = true;
            this.LinkClearMozos.Location = new System.Drawing.Point(249, 111);
            this.LinkClearMozos.Name = "LinkClearMozos";
            this.LinkClearMozos.Size = new System.Drawing.Size(104, 13);
            this.LinkClearMozos.TabIndex = 13;
            this.LinkClearMozos.TabStop = true;
            this.LinkClearMozos.Text = "Restablecer campos";
            this.LinkClearMozos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClearMozos_LinkClicked);
            // 
            // ButtonDeleteMozo
            // 
            this.ButtonDeleteMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteMozo.Location = new System.Drawing.Point(444, 102);
            this.ButtonDeleteMozo.Name = "ButtonDeleteMozo";
            this.ButtonDeleteMozo.Size = new System.Drawing.Size(83, 31);
            this.ButtonDeleteMozo.TabIndex = 12;
            this.ButtonDeleteMozo.Text = "Eliminar";
            this.ButtonDeleteMozo.UseVisualStyleBackColor = true;
            // 
            // ButtonNewMozo
            // 
            this.ButtonNewMozo.Location = new System.Drawing.Point(444, 25);
            this.ButtonNewMozo.Name = "ButtonNewMozo";
            this.ButtonNewMozo.Size = new System.Drawing.Size(83, 31);
            this.ButtonNewMozo.TabIndex = 8;
            this.ButtonNewMozo.Text = "Alta";
            this.ButtonNewMozo.UseVisualStyleBackColor = true;
            // 
            // TextDniMozo
            // 
            this.TextDniMozo.Location = new System.Drawing.Point(141, 76);
            this.TextDniMozo.Name = "TextDniMozo";
            this.TextDniMozo.Size = new System.Drawing.Size(212, 20);
            this.TextDniMozo.TabIndex = 7;
            // 
            // TextDirMozo
            // 
            this.TextDirMozo.Location = new System.Drawing.Point(141, 50);
            this.TextDirMozo.Name = "TextDirMozo";
            this.TextDirMozo.Size = new System.Drawing.Size(212, 20);
            this.TextDirMozo.TabIndex = 6;
            // 
            // TextNombreMozo
            // 
            this.TextNombreMozo.Location = new System.Drawing.Point(141, 25);
            this.TextNombreMozo.Name = "TextNombreMozo";
            this.TextNombreMozo.Size = new System.Drawing.Size(212, 20);
            this.TextNombreMozo.TabIndex = 5;
            // 
            // ButtonSaveMozos
            // 
            this.ButtonSaveMozos.Location = new System.Drawing.Point(444, 62);
            this.ButtonSaveMozos.Name = "ButtonSaveMozos";
            this.ButtonSaveMozos.Size = new System.Drawing.Size(83, 31);
            this.ButtonSaveMozos.TabIndex = 1;
            this.ButtonSaveMozos.Text = "Actualizar";
            this.ButtonSaveMozos.UseVisualStyleBackColor = true;
            this.ButtonSaveMozos.Click += new System.EventHandler(this.ButtonSaveMozos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sector";
            // 
            // ComboMozoSector
            // 
            this.ComboMozoSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMozoSector.FormattingEnabled = true;
            this.ComboMozoSector.Location = new System.Drawing.Point(141, 102);
            this.ComboMozoSector.Name = "ComboMozoSector";
            this.ComboMozoSector.Size = new System.Drawing.Size(56, 21);
            this.ComboMozoSector.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // LabelListadoMozos
            // 
            this.LabelListadoMozos.AutoSize = true;
            this.LabelListadoMozos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelListadoMozos.Location = new System.Drawing.Point(9, 6);
            this.LabelListadoMozos.Name = "LabelListadoMozos";
            this.LabelListadoMozos.Size = new System.Drawing.Size(50, 15);
            this.LabelListadoMozos.TabIndex = 3;
            this.LabelListadoMozos.Text = "Listado:";
            // 
            // DataGridMozos
            // 
            this.DataGridMozos.AllowUserToAddRows = false;
            this.DataGridMozos.AllowUserToDeleteRows = false;
            this.DataGridMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMozos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridMozos.Location = new System.Drawing.Point(6, 24);
            this.DataGridMozos.Name = "DataGridMozos";
            this.DataGridMozos.ReadOnly = true;
            this.DataGridMozos.Size = new System.Drawing.Size(567, 125);
            this.DataGridMozos.TabIndex = 0;
            this.DataGridMozos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMozos_CellClick);
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
            // TabPlatos
            // 
            this.TabPlatos.Controls.Add(this.GroupDatosPlatos);
            this.TabPlatos.Controls.Add(this.label9);
            this.TabPlatos.Controls.Add(this.DataGridPlatos);
            this.TabPlatos.Location = new System.Drawing.Point(4, 22);
            this.TabPlatos.Name = "TabPlatos";
            this.TabPlatos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlatos.Size = new System.Drawing.Size(583, 302);
            this.TabPlatos.TabIndex = 6;
            this.TabPlatos.Text = "Platos";
            this.TabPlatos.UseVisualStyleBackColor = true;
            // 
            // GroupDatosPlatos
            // 
            this.GroupDatosPlatos.Controls.Add(this.LinkClearPlatos);
            this.GroupDatosPlatos.Controls.Add(this.ButtonDeletePlato);
            this.GroupDatosPlatos.Controls.Add(this.label11);
            this.GroupDatosPlatos.Controls.Add(this.label10);
            this.GroupDatosPlatos.Controls.Add(this.ButtonNewPlato);
            this.GroupDatosPlatos.Controls.Add(this.TextPricePlatoV);
            this.GroupDatosPlatos.Controls.Add(this.TextPricePlatoC);
            this.GroupDatosPlatos.Controls.Add(this.TextDescPlatos);
            this.GroupDatosPlatos.Controls.Add(this.ButtonSavePlato);
            this.GroupDatosPlatos.Controls.Add(this.label5);
            this.GroupDatosPlatos.Controls.Add(this.ComboBoxPlatos);
            this.GroupDatosPlatos.Controls.Add(this.label6);
            this.GroupDatosPlatos.Controls.Add(this.label7);
            this.GroupDatosPlatos.Controls.Add(this.label8);
            this.GroupDatosPlatos.Location = new System.Drawing.Point(203, 9);
            this.GroupDatosPlatos.Name = "GroupDatosPlatos";
            this.GroupDatosPlatos.Size = new System.Drawing.Size(370, 270);
            this.GroupDatosPlatos.TabIndex = 7;
            this.GroupDatosPlatos.TabStop = false;
            this.GroupDatosPlatos.Text = "Datos del plato";
            // 
            // LinkClearPlatos
            // 
            this.LinkClearPlatos.AutoSize = true;
            this.LinkClearPlatos.Location = new System.Drawing.Point(26, 193);
            this.LinkClearPlatos.Name = "LinkClearPlatos";
            this.LinkClearPlatos.Size = new System.Drawing.Size(104, 13);
            this.LinkClearPlatos.TabIndex = 12;
            this.LinkClearPlatos.TabStop = true;
            this.LinkClearPlatos.Text = "Restablecer campos";
            // 
            // ButtonDeletePlato
            // 
            this.ButtonDeletePlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeletePlato.Location = new System.Drawing.Point(270, 234);
            this.ButtonDeletePlato.Name = "ButtonDeletePlato";
            this.ButtonDeletePlato.Size = new System.Drawing.Size(83, 30);
            this.ButtonDeletePlato.TabIndex = 11;
            this.ButtonDeletePlato.Text = "Eliminar";
            this.ButtonDeletePlato.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "$";
            // 
            // ButtonNewPlato
            // 
            this.ButtonNewPlato.Location = new System.Drawing.Point(28, 232);
            this.ButtonNewPlato.Name = "ButtonNewPlato";
            this.ButtonNewPlato.Size = new System.Drawing.Size(82, 31);
            this.ButtonNewPlato.TabIndex = 8;
            this.ButtonNewPlato.Text = "Alta";
            this.ButtonNewPlato.UseVisualStyleBackColor = true;
            // 
            // TextPricePlatoV
            // 
            this.TextPricePlatoV.Location = new System.Drawing.Point(154, 131);
            this.TextPricePlatoV.Name = "TextPricePlatoV";
            this.TextPricePlatoV.Size = new System.Drawing.Size(52, 20);
            this.TextPricePlatoV.TabIndex = 7;
            // 
            // TextPricePlatoC
            // 
            this.TextPricePlatoC.Location = new System.Drawing.Point(154, 105);
            this.TextPricePlatoC.Name = "TextPricePlatoC";
            this.TextPricePlatoC.Size = new System.Drawing.Size(52, 20);
            this.TextPricePlatoC.TabIndex = 6;
            // 
            // TextDescPlatos
            // 
            this.TextDescPlatos.Location = new System.Drawing.Point(28, 47);
            this.TextDescPlatos.Multiline = true;
            this.TextDescPlatos.Name = "TextDescPlatos";
            this.TextDescPlatos.Size = new System.Drawing.Size(325, 52);
            this.TextDescPlatos.TabIndex = 5;
            // 
            // ButtonSavePlato
            // 
            this.ButtonSavePlato.Location = new System.Drawing.Point(116, 232);
            this.ButtonSavePlato.Name = "ButtonSavePlato";
            this.ButtonSavePlato.Size = new System.Drawing.Size(78, 31);
            this.ButtonSavePlato.TabIndex = 1;
            this.ButtonSavePlato.Text = "Actualizar";
            this.ButtonSavePlato.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rubro";
            // 
            // ComboBoxPlatos
            // 
            this.ComboBoxPlatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPlatos.FormattingEnabled = true;
            this.ComboBoxPlatos.Location = new System.Drawing.Point(141, 157);
            this.ComboBoxPlatos.Name = "ComboBoxPlatos";
            this.ComboBoxPlatos.Size = new System.Drawing.Size(125, 21);
            this.ComboBoxPlatos.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Precio costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Listado:";
            // 
            // DataGridPlatos
            // 
            this.DataGridPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPlatos.Location = new System.Drawing.Point(12, 27);
            this.DataGridPlatos.Name = "DataGridPlatos";
            this.DataGridPlatos.Size = new System.Drawing.Size(174, 252);
            this.DataGridPlatos.TabIndex = 5;
            // 
            // TabPromos
            // 
            this.TabPromos.Controls.Add(this.GroupDataPromo);
            this.TabPromos.Controls.Add(this.label18);
            this.TabPromos.Controls.Add(this.DataGridPromos);
            this.TabPromos.Location = new System.Drawing.Point(4, 22);
            this.TabPromos.Name = "TabPromos";
            this.TabPromos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPromos.Size = new System.Drawing.Size(583, 302);
            this.TabPromos.TabIndex = 7;
            this.TabPromos.Text = "Promociones";
            this.TabPromos.UseVisualStyleBackColor = true;
            // 
            // GroupDataPromo
            // 
            this.GroupDataPromo.Controls.Add(this.CheckListPromos);
            this.GroupDataPromo.Controls.Add(this.LinkClearPromo);
            this.GroupDataPromo.Controls.Add(this.ButtonDeletePromo);
            this.GroupDataPromo.Controls.Add(this.label13);
            this.GroupDataPromo.Controls.Add(this.ButtonNewPromo);
            this.GroupDataPromo.Controls.Add(this.TextPricePromo);
            this.GroupDataPromo.Controls.Add(this.TextDescPromo);
            this.GroupDataPromo.Controls.Add(this.ButtonSavePromo);
            this.GroupDataPromo.Controls.Add(this.label14);
            this.GroupDataPromo.Controls.Add(this.LabelPrecioPromo);
            this.GroupDataPromo.Controls.Add(this.label17);
            this.GroupDataPromo.Location = new System.Drawing.Point(203, 8);
            this.GroupDataPromo.Name = "GroupDataPromo";
            this.GroupDataPromo.Size = new System.Drawing.Size(370, 288);
            this.GroupDataPromo.TabIndex = 10;
            this.GroupDataPromo.TabStop = false;
            this.GroupDataPromo.Text = "Datos de la promo";
            // 
            // CheckListPromos
            // 
            this.CheckListPromos.FormattingEnabled = true;
            this.CheckListPromos.Location = new System.Drawing.Point(83, 121);
            this.CheckListPromos.Name = "CheckListPromos";
            this.CheckListPromos.Size = new System.Drawing.Size(153, 154);
            this.CheckListPromos.TabIndex = 13;
            // 
            // LinkClearPromo
            // 
            this.LinkClearPromo.AutoSize = true;
            this.LinkClearPromo.Location = new System.Drawing.Point(250, 92);
            this.LinkClearPromo.Name = "LinkClearPromo";
            this.LinkClearPromo.Size = new System.Drawing.Size(104, 13);
            this.LinkClearPromo.TabIndex = 12;
            this.LinkClearPromo.TabStop = true;
            this.LinkClearPromo.Text = "Restablecer campos";
            // 
            // ButtonDeletePromo
            // 
            this.ButtonDeletePromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeletePromo.Location = new System.Drawing.Point(286, 245);
            this.ButtonDeletePromo.Name = "ButtonDeletePromo";
            this.ButtonDeletePromo.Size = new System.Drawing.Size(78, 30);
            this.ButtonDeletePromo.TabIndex = 11;
            this.ButtonDeletePromo.Text = "Eliminar";
            this.ButtonDeletePromo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "$";
            // 
            // ButtonNewPromo
            // 
            this.ButtonNewPromo.Location = new System.Drawing.Point(286, 162);
            this.ButtonNewPromo.Name = "ButtonNewPromo";
            this.ButtonNewPromo.Size = new System.Drawing.Size(78, 31);
            this.ButtonNewPromo.TabIndex = 8;
            this.ButtonNewPromo.Text = "Alta";
            this.ButtonNewPromo.UseVisualStyleBackColor = true;
            // 
            // TextPricePromo
            // 
            this.TextPricePromo.Location = new System.Drawing.Point(99, 89);
            this.TextPricePromo.Name = "TextPricePromo";
            this.TextPricePromo.Size = new System.Drawing.Size(52, 20);
            this.TextPricePromo.TabIndex = 6;
            // 
            // TextDescPromo
            // 
            this.TextDescPromo.Location = new System.Drawing.Point(29, 34);
            this.TextDescPromo.Multiline = true;
            this.TextDescPromo.Name = "TextDescPromo";
            this.TextDescPromo.Size = new System.Drawing.Size(325, 49);
            this.TextDescPromo.TabIndex = 5;
            // 
            // ButtonSavePromo
            // 
            this.ButtonSavePromo.Location = new System.Drawing.Point(286, 199);
            this.ButtonSavePromo.Name = "ButtonSavePromo";
            this.ButtonSavePromo.Size = new System.Drawing.Size(78, 31);
            this.ButtonSavePromo.TabIndex = 1;
            this.ButtonSavePromo.Text = "Actualizar";
            this.ButtonSavePromo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Platos";
            // 
            // LabelPrecioPromo
            // 
            this.LabelPrecioPromo.AutoSize = true;
            this.LabelPrecioPromo.Location = new System.Drawing.Point(25, 92);
            this.LabelPrecioPromo.Name = "LabelPrecioPromo";
            this.LabelPrecioPromo.Size = new System.Drawing.Size(37, 13);
            this.LabelPrecioPromo.TabIndex = 1;
            this.LabelPrecioPromo.Text = "Precio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Descripcion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "Listado:";
            // 
            // DataGridPromos
            // 
            this.DataGridPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPromos.Location = new System.Drawing.Point(12, 26);
            this.DataGridPromos.Name = "DataGridPromos";
            this.DataGridPromos.Size = new System.Drawing.Size(174, 270);
            this.DataGridPromos.TabIndex = 8;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonExit.FlatAppearance.BorderSize = 3;
            this.ButtonExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(494, 380);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(109, 38);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Salir";
            this.ButtonExit.UseVisualStyleBackColor = false;
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
            // TextIdMozo
            // 
            this.TextIdMozo.Location = new System.Drawing.Point(378, 26);
            this.TextIdMozo.Name = "TextIdMozo";
            this.TextIdMozo.ReadOnly = true;
            this.TextIdMozo.Size = new System.Drawing.Size(35, 20);
            this.TextIdMozo.TabIndex = 14;
            this.TextIdMozo.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.AcercaDeLink);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Restaurant.NET";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.TabResumen.ResumeLayout(false);
            this.groupAcciones.ResumeLayout(false);
            this.TabMozos.ResumeLayout(false);
            this.TabMozos.PerformLayout();
            this.GroupDatosMozos.ResumeLayout(false);
            this.GroupDatosMozos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMozos)).EndInit();
            this.TabPlatos.ResumeLayout(false);
            this.TabPlatos.PerformLayout();
            this.GroupDatosPlatos.ResumeLayout(false);
            this.GroupDatosPlatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlatos)).EndInit();
            this.TabPromos.ResumeLayout(false);
            this.TabPromos.PerformLayout();
            this.GroupDataPromo.ResumeLayout(false);
            this.GroupDataPromo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPromos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TabResumen;
        private System.Windows.Forms.TabPage TabMozos;
        private System.Windows.Forms.TabPage TabVentas_Pedidos;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.GroupBox groupResumen;
        private System.Windows.Forms.GroupBox groupAcciones;
        private System.Windows.Forms.GroupBox groupMesas;
        private System.Windows.Forms.GroupBox groupPromociones;
        private System.Windows.Forms.Button ButAbrirMesaRapida;
        private System.Windows.Forms.Button ButCargarPedidoRapido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButCerrarMesaRapida;
        private System.Windows.Forms.TabPage TabConsultas;
        private System.Windows.Forms.TabPage TabPlatos;
        private System.Windows.Forms.LinkLabel AcercaDeLink;
        private System.Windows.Forms.DataGridView DataGridMozos;
        private System.Windows.Forms.Button ButtonSaveMozos;
        private System.Windows.Forms.Label LabelListadoMozos;
        private System.Windows.Forms.GroupBox GroupDatosMozos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboMozoSector;
        private System.Windows.Forms.Button ButtonNewMozo;
        private System.Windows.Forms.TextBox TextDniMozo;
        private System.Windows.Forms.TextBox TextDirMozo;
        private System.Windows.Forms.TextBox TextNombreMozo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroupDatosPlatos;
        private System.Windows.Forms.Button ButtonNewPlato;
        private System.Windows.Forms.TextBox TextPricePlatoC;
        private System.Windows.Forms.TextBox TextDescPlatos;
        private System.Windows.Forms.Button ButtonSavePlato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxPlatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DataGridPlatos;
        private System.Windows.Forms.Button ButtonDeleteMozo;
        private System.Windows.Forms.Button ButtonDeletePlato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextPricePlatoV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage TabPromos;
        private System.Windows.Forms.LinkLabel LinkClearPlatos;
        private System.Windows.Forms.LinkLabel LinkClearMozos;
        private System.Windows.Forms.GroupBox GroupDataPromo;
        private System.Windows.Forms.LinkLabel LinkClearPromo;
        private System.Windows.Forms.Button ButtonDeletePromo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ButtonNewPromo;
        private System.Windows.Forms.TextBox TextPricePromo;
        private System.Windows.Forms.TextBox TextDescPromo;
        private System.Windows.Forms.Button ButtonSavePromo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabelPrecioPromo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView DataGridPromos;
        private System.Windows.Forms.CheckedListBox CheckListPromos;
        private System.Windows.Forms.TextBox TextIdMozo;
    }
}