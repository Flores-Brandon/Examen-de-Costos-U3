namespace unidad_3_costos
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tpRecibo = new TabPage();
            txtContabilizada = new TextBox();
            lblContabilizada = new Label();
            txtCalculada = new TextBox();
            lblCalculada = new Label();
            txtExpedida = new TextBox();
            lblExpedida = new Label();
            lblCostoPrimoTotal = new Label();
            lblManoObrTotal = new Label();
            btnImprimir = new Button();
            lblCostoProduccionUnitario = new Label();
            lblCargosIndireUnitario = new Label();
            lblCostoPrimoUnitario = new Label();
            lblManoObraDirecUnitario = new Label();
            lblMatPriDirecUnitario = new Label();
            lblCostoProduccionTotal = new Label();
            lblCargosIndireTotal = new Label();
            lblMatPriDirecTotal = new Label();
            lblUnitario = new Label();
            lblTotal = new Label();
            lblCosto = new Label();
            lblCostodeProduccion = new Label();
            lblCargosIndirectos = new Label();
            lblCostopri = new Label();
            lblManodeObraDirecta = new Label();
            lblMateriaPrimaDirecta = new Label();
            lblConcepto = new Label();
            lblSubTitulo = new Label();
            lblTitulo = new Label();
            dtpFechaTerminacion = new DateTimePicker();
            dtpFechaIniciacion = new DateTimePicker();
            dtpFechaExpedicion = new DateTimePicker();
            dtpFechaDescarga = new DateTimePicker();
            dtpFechaPedido = new DateTimePicker();
            txtUnidad = new TextBox();
            txtCantidad = new TextBox();
            txtEspesificaciones = new TextBox();
            txtProducto = new TextBox();
            txtCliente = new TextBox();
            lblFechaTermincion = new Label();
            lblFechaDescargaEntrega = new Label();
            lblFechaIniciacion = new Label();
            lblFechaExpedicion = new Label();
            lblFechaPedido = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOperaciones = new Button();
            tabControl1.SuspendLayout();
            tpRecibo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tpRecibo);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1515, 707);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1507, 679);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Determinacion de producción Procesaada Unidades";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1507, 679);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Calculo de Costos Unitarios Promedio";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1507, 679);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Valuacion de Inventario Inicial";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1507, 679);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Valuacion de Producción Terminada";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tpRecibo
            // 
            tpRecibo.Controls.Add(txtContabilizada);
            tpRecibo.Controls.Add(lblContabilizada);
            tpRecibo.Controls.Add(txtCalculada);
            tpRecibo.Controls.Add(lblCalculada);
            tpRecibo.Controls.Add(txtExpedida);
            tpRecibo.Controls.Add(lblExpedida);
            tpRecibo.Controls.Add(lblCostoPrimoTotal);
            tpRecibo.Controls.Add(lblManoObrTotal);
            tpRecibo.Controls.Add(btnImprimir);
            tpRecibo.Controls.Add(lblCostoProduccionUnitario);
            tpRecibo.Controls.Add(lblCargosIndireUnitario);
            tpRecibo.Controls.Add(lblCostoPrimoUnitario);
            tpRecibo.Controls.Add(lblManoObraDirecUnitario);
            tpRecibo.Controls.Add(lblMatPriDirecUnitario);
            tpRecibo.Controls.Add(lblCostoProduccionTotal);
            tpRecibo.Controls.Add(lblCargosIndireTotal);
            tpRecibo.Controls.Add(lblMatPriDirecTotal);
            tpRecibo.Controls.Add(lblUnitario);
            tpRecibo.Controls.Add(lblTotal);
            tpRecibo.Controls.Add(lblCosto);
            tpRecibo.Controls.Add(lblCostodeProduccion);
            tpRecibo.Controls.Add(lblCargosIndirectos);
            tpRecibo.Controls.Add(lblCostopri);
            tpRecibo.Controls.Add(lblManodeObraDirecta);
            tpRecibo.Controls.Add(lblMateriaPrimaDirecta);
            tpRecibo.Controls.Add(lblConcepto);
            tpRecibo.Controls.Add(lblSubTitulo);
            tpRecibo.Controls.Add(lblTitulo);
            tpRecibo.Controls.Add(dtpFechaTerminacion);
            tpRecibo.Controls.Add(dtpFechaIniciacion);
            tpRecibo.Controls.Add(dtpFechaExpedicion);
            tpRecibo.Controls.Add(dtpFechaDescarga);
            tpRecibo.Controls.Add(dtpFechaPedido);
            tpRecibo.Controls.Add(txtUnidad);
            tpRecibo.Controls.Add(txtCantidad);
            tpRecibo.Controls.Add(txtEspesificaciones);
            tpRecibo.Controls.Add(txtProducto);
            tpRecibo.Controls.Add(txtCliente);
            tpRecibo.Controls.Add(lblFechaTermincion);
            tpRecibo.Controls.Add(lblFechaDescargaEntrega);
            tpRecibo.Controls.Add(lblFechaIniciacion);
            tpRecibo.Controls.Add(lblFechaExpedicion);
            tpRecibo.Controls.Add(lblFechaPedido);
            tpRecibo.Controls.Add(label5);
            tpRecibo.Controls.Add(label4);
            tpRecibo.Controls.Add(label3);
            tpRecibo.Controls.Add(label2);
            tpRecibo.Controls.Add(label1);
            tpRecibo.Location = new Point(4, 24);
            tpRecibo.Margin = new Padding(3, 2, 3, 2);
            tpRecibo.Name = "tpRecibo";
            tpRecibo.Padding = new Padding(3, 2, 3, 2);
            tpRecibo.Size = new Size(1507, 679);
            tpRecibo.TabIndex = 4;
            tpRecibo.Text = "Recibo";
            tpRecibo.UseVisualStyleBackColor = true;
            tpRecibo.Click += tabPage5_Click;
            // 
            // txtContabilizada
            // 
            txtContabilizada.Location = new Point(1070, 648);
            txtContabilizada.Margin = new Padding(3, 2, 3, 2);
            txtContabilizada.Name = "txtContabilizada";
            txtContabilizada.Size = new Size(252, 23);
            txtContabilizada.TabIndex = 48;
            // 
            // lblContabilizada
            // 
            lblContabilizada.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblContabilizada.Location = new Point(902, 643);
            lblContabilizada.Name = "lblContabilizada";
            lblContabilizada.Size = new Size(162, 32);
            lblContabilizada.TabIndex = 47;
            lblContabilizada.Text = "Contabilizada Por:";
            lblContabilizada.Click += label24_Click;
            // 
            // txtCalculada
            // 
            txtCalculada.Location = new Point(619, 648);
            txtCalculada.Margin = new Padding(3, 2, 3, 2);
            txtCalculada.Name = "txtCalculada";
            txtCalculada.Size = new Size(252, 23);
            txtCalculada.TabIndex = 46;
            // 
            // lblCalculada
            // 
            lblCalculada.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalculada.Location = new Point(473, 645);
            lblCalculada.Name = "lblCalculada";
            lblCalculada.Size = new Size(140, 32);
            lblCalculada.TabIndex = 45;
            lblCalculada.Text = "Calculada Por:";
            // 
            // txtExpedida
            // 
            txtExpedida.Location = new Point(154, 648);
            txtExpedida.Margin = new Padding(3, 2, 3, 2);
            txtExpedida.Name = "txtExpedida";
            txtExpedida.Size = new Size(252, 23);
            txtExpedida.TabIndex = 44;
            // 
            // lblExpedida
            // 
            lblExpedida.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpedida.Location = new Point(8, 645);
            lblExpedida.Name = "lblExpedida";
            lblExpedida.Size = new Size(140, 32);
            lblExpedida.TabIndex = 43;
            lblExpedida.Text = "Expedida Por:";
            // 
            // lblCostoPrimoTotal
            // 
            lblCostoPrimoTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoPrimoTotal.Location = new Point(696, 419);
            lblCostoPrimoTotal.Name = "lblCostoPrimoTotal";
            lblCostoPrimoTotal.Size = new Size(106, 32);
            lblCostoPrimoTotal.TabIndex = 42;
            lblCostoPrimoTotal.Click += label23_Click;
            // 
            // lblManoObrTotal
            // 
            lblManoObrTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblManoObrTotal.Location = new Point(696, 387);
            lblManoObrTotal.Name = "lblManoObrTotal";
            lblManoObrTotal.Size = new Size(106, 32);
            lblManoObrTotal.TabIndex = 41;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(1343, 629);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(158, 46);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblCostoProduccionUnitario
            // 
            lblCostoProduccionUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoProduccionUnitario.Location = new Point(1145, 483);
            lblCostoProduccionUnitario.Name = "lblCostoProduccionUnitario";
            lblCostoProduccionUnitario.Size = new Size(106, 32);
            lblCostoProduccionUnitario.TabIndex = 40;
            // 
            // lblCargosIndireUnitario
            // 
            lblCargosIndireUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargosIndireUnitario.Location = new Point(1145, 451);
            lblCargosIndireUnitario.Name = "lblCargosIndireUnitario";
            lblCargosIndireUnitario.Size = new Size(106, 32);
            lblCargosIndireUnitario.TabIndex = 39;
            // 
            // lblCostoPrimoUnitario
            // 
            lblCostoPrimoUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoPrimoUnitario.Location = new Point(1145, 419);
            lblCostoPrimoUnitario.Name = "lblCostoPrimoUnitario";
            lblCostoPrimoUnitario.Size = new Size(106, 32);
            lblCostoPrimoUnitario.TabIndex = 38;
            // 
            // lblManoObraDirecUnitario
            // 
            lblManoObraDirecUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblManoObraDirecUnitario.Location = new Point(1145, 387);
            lblManoObraDirecUnitario.Name = "lblManoObraDirecUnitario";
            lblManoObraDirecUnitario.Size = new Size(106, 32);
            lblManoObraDirecUnitario.TabIndex = 37;
            // 
            // lblMatPriDirecUnitario
            // 
            lblMatPriDirecUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatPriDirecUnitario.Location = new Point(1145, 355);
            lblMatPriDirecUnitario.Name = "lblMatPriDirecUnitario";
            lblMatPriDirecUnitario.Size = new Size(106, 32);
            lblMatPriDirecUnitario.TabIndex = 36;
            // 
            // lblCostoProduccionTotal
            // 
            lblCostoProduccionTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoProduccionTotal.Location = new Point(696, 483);
            lblCostoProduccionTotal.Name = "lblCostoProduccionTotal";
            lblCostoProduccionTotal.Size = new Size(106, 32);
            lblCostoProduccionTotal.TabIndex = 35;
            // 
            // lblCargosIndireTotal
            // 
            lblCargosIndireTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargosIndireTotal.Location = new Point(696, 451);
            lblCargosIndireTotal.Name = "lblCargosIndireTotal";
            lblCargosIndireTotal.Size = new Size(106, 32);
            lblCargosIndireTotal.TabIndex = 34;
            // 
            // lblMatPriDirecTotal
            // 
            lblMatPriDirecTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatPriDirecTotal.Location = new Point(696, 355);
            lblMatPriDirecTotal.Name = "lblMatPriDirecTotal";
            lblMatPriDirecTotal.Size = new Size(106, 32);
            lblMatPriDirecTotal.TabIndex = 31;
            // 
            // lblUnitario
            // 
            lblUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitario.Location = new Point(1145, 323);
            lblUnitario.Name = "lblUnitario";
            lblUnitario.Size = new Size(106, 32);
            lblUnitario.TabIndex = 30;
            lblUnitario.Text = "Unitario";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(700, 323);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 32);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total";
            // 
            // lblCosto
            // 
            lblCosto.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCosto.Location = new Point(901, 283);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(106, 32);
            lblCosto.TabIndex = 28;
            lblCosto.Text = "Costo";
            // 
            // lblCostodeProduccion
            // 
            lblCostodeProduccion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostodeProduccion.Location = new Point(67, 494);
            lblCostodeProduccion.Name = "lblCostodeProduccion";
            lblCostodeProduccion.Size = new Size(197, 32);
            lblCostodeProduccion.TabIndex = 27;
            lblCostodeProduccion.Text = "Costo de Producción";
            // 
            // lblCargosIndirectos
            // 
            lblCargosIndirectos.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargosIndirectos.Location = new Point(67, 462);
            lblCargosIndirectos.Name = "lblCargosIndirectos";
            lblCargosIndirectos.Size = new Size(197, 32);
            lblCargosIndirectos.TabIndex = 25;
            lblCargosIndirectos.Text = "Cargos Indirectos";
            // 
            // lblCostopri
            // 
            lblCostopri.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostopri.Location = new Point(67, 430);
            lblCostopri.Name = "lblCostopri";
            lblCostopri.Size = new Size(197, 32);
            lblCostopri.TabIndex = 24;
            lblCostopri.Text = "Costo Primo";
            // 
            // lblManodeObraDirecta
            // 
            lblManodeObraDirecta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblManodeObraDirecta.Location = new Point(67, 398);
            lblManodeObraDirecta.Name = "lblManodeObraDirecta";
            lblManodeObraDirecta.Size = new Size(197, 32);
            lblManodeObraDirecta.TabIndex = 23;
            lblManodeObraDirecta.Text = "Mano de Obra Directa";
            // 
            // lblMateriaPrimaDirecta
            // 
            lblMateriaPrimaDirecta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateriaPrimaDirecta.Location = new Point(67, 366);
            lblMateriaPrimaDirecta.Name = "lblMateriaPrimaDirecta";
            lblMateriaPrimaDirecta.Size = new Size(197, 32);
            lblMateriaPrimaDirecta.TabIndex = 22;
            lblMateriaPrimaDirecta.Text = "Materia Prima Directa";
            // 
            // lblConcepto
            // 
            lblConcepto.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblConcepto.Location = new Point(114, 334);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(106, 32);
            lblConcepto.TabIndex = 21;
            lblConcepto.Text = "Concepto";
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTitulo.Location = new Point(546, 46);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(269, 31);
            lblSubTitulo.TabIndex = 20;
            lblSubTitulo.Text = "Orden de Produccion\r\n";
            lblSubTitulo.Click += label12_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(560, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 31);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "ALESCA, S.A";
            // 
            // dtpFechaTerminacion
            // 
            dtpFechaTerminacion.Location = new Point(1032, 241);
            dtpFechaTerminacion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaTerminacion.Name = "dtpFechaTerminacion";
            dtpFechaTerminacion.Size = new Size(219, 23);
            dtpFechaTerminacion.TabIndex = 18;
            dtpFechaTerminacion.ValueChanged += dtpFechaTerminacion_ValueChanged;
            // 
            // dtpFechaIniciacion
            // 
            dtpFechaIniciacion.Location = new Point(1032, 160);
            dtpFechaIniciacion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaIniciacion.Name = "dtpFechaIniciacion";
            dtpFechaIniciacion.Size = new Size(219, 23);
            dtpFechaIniciacion.TabIndex = 17;
            // 
            // dtpFechaExpedicion
            // 
            dtpFechaExpedicion.Location = new Point(1032, 120);
            dtpFechaExpedicion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaExpedicion.Name = "dtpFechaExpedicion";
            dtpFechaExpedicion.Size = new Size(219, 23);
            dtpFechaExpedicion.TabIndex = 16;
            // 
            // dtpFechaDescarga
            // 
            dtpFechaDescarga.Location = new Point(1032, 203);
            dtpFechaDescarga.Margin = new Padding(3, 2, 3, 2);
            dtpFechaDescarga.Name = "dtpFechaDescarga";
            dtpFechaDescarga.Size = new Size(219, 23);
            dtpFechaDescarga.TabIndex = 16;
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.Location = new Point(1032, 80);
            dtpFechaPedido.Margin = new Padding(3, 2, 3, 2);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(219, 23);
            dtpFechaPedido.TabIndex = 15;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(235, 247);
            txtUnidad.Margin = new Padding(3, 2, 3, 2);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(299, 23);
            txtUnidad.TabIndex = 14;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(235, 206);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(299, 23);
            txtCantidad.TabIndex = 13;
            // 
            // txtEspesificaciones
            // 
            txtEspesificaciones.Location = new Point(235, 163);
            txtEspesificaciones.Margin = new Padding(3, 2, 3, 2);
            txtEspesificaciones.Name = "txtEspesificaciones";
            txtEspesificaciones.Size = new Size(299, 23);
            txtEspesificaciones.TabIndex = 12;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(235, 123);
            txtProducto.Margin = new Padding(3, 2, 3, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(299, 23);
            txtProducto.TabIndex = 11;
            txtProducto.TextChanged += textBox2_TextChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(235, 83);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(299, 23);
            txtCliente.TabIndex = 10;
            // 
            // lblFechaTermincion
            // 
            lblFechaTermincion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaTermincion.Location = new Point(696, 244);
            lblFechaTermincion.Name = "lblFechaTermincion";
            lblFechaTermincion.Size = new Size(285, 39);
            lblFechaTermincion.TabIndex = 9;
            lblFechaTermincion.Text = "Fecha de Terminacion ";
            // 
            // lblFechaDescargaEntrega
            // 
            lblFechaDescargaEntrega.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaDescargaEntrega.Location = new Point(696, 204);
            lblFechaDescargaEntrega.Name = "lblFechaDescargaEntrega";
            lblFechaDescargaEntrega.Size = new Size(332, 28);
            lblFechaDescargaEntrega.TabIndex = 8;
            lblFechaDescargaEntrega.Text = "Fecha descargada de entrega";
            // 
            // lblFechaIniciacion
            // 
            lblFechaIniciacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaIniciacion.Location = new Point(696, 161);
            lblFechaIniciacion.Name = "lblFechaIniciacion";
            lblFechaIniciacion.Size = new Size(201, 25);
            lblFechaIniciacion.TabIndex = 7;
            lblFechaIniciacion.Text = "Fecha de Iniciacion";
            // 
            // lblFechaExpedicion
            // 
            lblFechaExpedicion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaExpedicion.Location = new Point(696, 121);
            lblFechaExpedicion.Name = "lblFechaExpedicion";
            lblFechaExpedicion.Size = new Size(221, 21);
            lblFechaExpedicion.TabIndex = 6;
            lblFechaExpedicion.Text = "Fecha de Expedicion\r\n";
            // 
            // lblFechaPedido
            // 
            lblFechaPedido.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPedido.Location = new Point(696, 80);
            lblFechaPedido.Name = "lblFechaPedido";
            lblFechaPedido.Size = new Size(190, 22);
            lblFechaPedido.TabIndex = 5;
            lblFechaPedido.Text = "Fecha de pedido";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 241);
            label5.Name = "label5";
            label5.Size = new Size(153, 50);
            label5.TabIndex = 4;
            label5.Text = "Unidad";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 200);
            label4.Name = "label4";
            label4.Size = new Size(153, 50);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 158);
            label3.Name = "label3";
            label3.Size = new Size(197, 50);
            label3.TabIndex = 2;
            label3.Text = "Espesificaciones";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 117);
            label2.Name = "label2";
            label2.Size = new Size(153, 50);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 76);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // btnOperaciones
            // 
            btnOperaciones.Location = new Point(1371, 727);
            btnOperaciones.Margin = new Padding(3, 2, 3, 2);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(158, 46);
            btnOperaciones.TabIndex = 0;
            btnOperaciones.Text = "Resultado";
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 784);
            Controls.Add(btnOperaciones);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tpRecibo.ResumeLayout(false);
            tpRecibo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnOperaciones;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tpRecibo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblFechaTermincion;
        private Label lblFechaDescargaEntrega;
        private Label lblFechaIniciacion;
        private Label lblFechaExpedicion;
        private Label lblFechaPedido;
        private TextBox txtProducto;
        private TextBox txtCliente;
        private DateTimePicker dtpFechaIniciacion;
        private DateTimePicker dtpFechaExpedicion;
        private DateTimePicker dtpFechaDescarga;
        private DateTimePicker dtpFechaPedido;
        private TextBox txtUnidad;
        private TextBox txtCantidad;
        private TextBox txtEspesificaciones;
        private DateTimePicker dtpFechaTerminacion;
        private Label lblSubTitulo;
        private Label lblTitulo;
        private Label lblMateriaPrimaDirecta;
        private Label lblConcepto;
        private Label lblCostodeProduccion;
        private Label lblCargosIndirectos;
        private Label lblCostopri;
        private Label lblManodeObraDirecta;
        private Label label28;
        private Label lblCostoProduccionTotal;
        private Label lblCargosIndireTotal;
        private Label lblMatPriDirecTotal;
        private Label lblUnitario;
        private Label lblTotal;
        private Label lblCosto;
        private Label lblCostoProduccionUnitario;
        private Label lblCargosIndireUnitario;
        private Label lblCostoPrimoUnitario;
        private Label lblManoObraDirecUnitario;
        private Label lblMatPriDirecUnitario;
        private Button btnImprimir;
        private Label lblCostoPrimoTotal;
        private Label lblManoObrTotal;
        private TextBox txtContabilizada;
        private Label lblContabilizada;
        private TextBox txtCalculada;
        private Label lblCalculada;
        private TextBox txtExpedida;
        private Label lblExpedida;
    }
}