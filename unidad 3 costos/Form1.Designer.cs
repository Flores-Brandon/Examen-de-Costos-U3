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
            tabPage5 = new TabPage();
            btnImprimir = new Button();
            lblCostoProduccionUnitario = new Label();
            lblCargosIndireUnitario = new Label();
            lblCostoPrimoUnitarioUnitario = new Label();
            lblManoObraDirecUnitario = new Label();
            lblMatPriDirecUnitario = new Label();
            lblCostoProduccionTotal = new Label();
            lblCargosIndireTotal = new Label();
            lblMatPriDirecTotal = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
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
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOperaciones = new Button();
            lblManoObrTotal = new Label();
            lblCostoPrimo = new Label();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1515, 707);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ButtonFace;
            tabPage1.ForeColor = Color.White;
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
            // tabPage5
            // 
            tabPage5.Controls.Add(lblCostoPrimo);
            tabPage5.Controls.Add(lblManoObrTotal);
            tabPage5.Controls.Add(btnImprimir);
            tabPage5.Controls.Add(lblCostoProduccionUnitario);
            tabPage5.Controls.Add(lblCargosIndireUnitario);
            tabPage5.Controls.Add(lblCostoPrimoUnitarioUnitario);
            tabPage5.Controls.Add(lblManoObraDirecUnitario);
            tabPage5.Controls.Add(lblMatPriDirecUnitario);
            tabPage5.Controls.Add(lblCostoProduccionTotal);
            tabPage5.Controls.Add(lblCargosIndireTotal);
            tabPage5.Controls.Add(lblMatPriDirecTotal);
            tabPage5.Controls.Add(label22);
            tabPage5.Controls.Add(label21);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(dtpFechaTerminacion);
            tabPage5.Controls.Add(dtpFechaIniciacion);
            tabPage5.Controls.Add(dtpFechaExpedicion);
            tabPage5.Controls.Add(dtpFechaDescarga);
            tabPage5.Controls.Add(dtpFechaPedido);
            tabPage5.Controls.Add(txtUnidad);
            tabPage5.Controls.Add(txtCantidad);
            tabPage5.Controls.Add(txtEspesificaciones);
            tabPage5.Controls.Add(txtProducto);
            tabPage5.Controls.Add(txtCliente);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(label6);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(label4);
            tabPage5.Controls.Add(label3);
            tabPage5.Controls.Add(label2);
            tabPage5.Controls.Add(label1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(1507, 679);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Recibo";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
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
            // lblCostoPrimoUnitarioUnitario
            // 
            lblCostoPrimoUnitarioUnitario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoPrimoUnitarioUnitario.Location = new Point(1145, 419);
            lblCostoPrimoUnitarioUnitario.Name = "lblCostoPrimoUnitarioUnitario";
            lblCostoPrimoUnitarioUnitario.Size = new Size(106, 32);
            lblCostoPrimoUnitarioUnitario.TabIndex = 38;
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
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(1145, 323);
            label22.Name = "label22";
            label22.Size = new Size(106, 32);
            label22.TabIndex = 30;
            label22.Text = "Unitario";
            // 
            // label21
            // 
            label21.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(700, 323);
            label21.Name = "label21";
            label21.Size = new Size(106, 32);
            label21.TabIndex = 29;
            label21.Text = "Total";
            // 
            // label20
            // 
            label20.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(901, 283);
            label20.Name = "label20";
            label20.Size = new Size(106, 32);
            label20.TabIndex = 28;
            label20.Text = "Costo";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(67, 494);
            label19.Name = "label19";
            label19.Size = new Size(197, 32);
            label19.TabIndex = 27;
            label19.Text = "Costo de Producción";
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(67, 462);
            label17.Name = "label17";
            label17.Size = new Size(197, 32);
            label17.TabIndex = 25;
            label17.Text = "Cargos Indirectos";
            // 
            // label16
            // 
            label16.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(67, 430);
            label16.Name = "label16";
            label16.Size = new Size(197, 32);
            label16.TabIndex = 24;
            label16.Text = "Costo Primo";
            // 
            // label15
            // 
            label15.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(67, 398);
            label15.Name = "label15";
            label15.Size = new Size(197, 32);
            label15.TabIndex = 23;
            label15.Text = "Mano de Obra Directa";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(67, 366);
            label14.Name = "label14";
            label14.Size = new Size(197, 32);
            label14.TabIndex = 22;
            label14.Text = "Materia Prima Directa";
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(114, 334);
            label13.Name = "label13";
            label13.Size = new Size(106, 32);
            label13.TabIndex = 21;
            label13.Text = "Concepto";
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(546, 46);
            label12.Name = "label12";
            label12.Size = new Size(269, 31);
            label12.TabIndex = 20;
            label12.Text = "Orden de Produccion\r\n";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(560, 12);
            label11.Name = "label11";
            label11.Size = new Size(275, 31);
            label11.TabIndex = 19;
            label11.Text = "ALESCA, S.A";
            // 
            // dtpFechaTerminacion
            // 
            dtpFechaTerminacion.Location = new Point(1032, 253);
            dtpFechaTerminacion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaTerminacion.Name = "dtpFechaTerminacion";
            dtpFechaTerminacion.Size = new Size(219, 23);
            dtpFechaTerminacion.TabIndex = 18;
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
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(696, 244);
            label10.Name = "label10";
            label10.Size = new Size(285, 39);
            label10.TabIndex = 9;
            label10.Text = "Fecha de Terminacion ";
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(696, 204);
            label9.Name = "label9";
            label9.Size = new Size(332, 28);
            label9.TabIndex = 8;
            label9.Text = "Fecha descargada de entrega";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(696, 161);
            label8.Name = "label8";
            label8.Size = new Size(201, 25);
            label8.TabIndex = 7;
            label8.Text = "Fecha de Iniciacion";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(696, 121);
            label7.Name = "label7";
            label7.Size = new Size(221, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Expedicion\r\n";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(696, 80);
            label6.Name = "label6";
            label6.Size = new Size(190, 22);
            label6.TabIndex = 5;
            label6.Text = "Fecha de pedido";
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
            // lblManoObrTotal
            // 
            lblManoObrTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblManoObrTotal.Location = new Point(696, 387);
            lblManoObrTotal.Name = "lblManoObrTotal";
            lblManoObrTotal.Size = new Size(106, 32);
            lblManoObrTotal.TabIndex = 41;
            // 
            // lblCostoPrimo
            // 
            lblCostoPrimo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoPrimo.Location = new Point(696, 419);
            lblCostoPrimo.Name = "lblCostoPrimo";
            lblCostoPrimo.Size = new Size(106, 32);
            lblCostoPrimo.TabIndex = 42;
            lblCostoPrimo.Click += label23_Click;
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
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnOperaciones;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
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
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label19;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label28;
        private Label lblCostoProduccionTotal;
        private Label lblCargosIndireTotal;
        private Label lblMatPriDirecTotal;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label lblCostoProduccionUnitario;
        private Label lblCargosIndireUnitario;
        private Label lblCostoPrimoUnitarioUnitario;
        private Label lblManoObraDirecUnitario;
        private Label lblMatPriDirecUnitario;
        private Button btnImprimir;
        private Label lblCostoPrimo;
        private Label lblManoObrTotal;
    }
}