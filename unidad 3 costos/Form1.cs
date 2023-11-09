namespace unidad_3_costos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Variable Tabla 1
        //Produccion  Terminada-Final
        private float MatProTer1 = 0;
        private float ManoObr1 = 0;
        private float GFabriacion1 = 0;
        //Poceso-Final
        private float MatProce1 = 0;
        private float ManoObrProce1 = 0;
        private float GFabriacionProce1 = 0;
        //% Avance-Final
        private float MatAvance1 = 0;
        private float ManoObrAvance1 = 0;
        private float GFabriacionAvance1 = 0;
        //Poceso-Inicial
        private float MatProce1_1 = 0;
        private float ManoObrProce1_1 = 0;
        private float GFabriacionProce1_1 = 0;
        //% Avance-Inicial
        private float MatAvance1_1 = 0;
        private float ManoObrAvance1_1 = 0;
        private float GFabriacionAvance1_1 = 0;

        //Variables Iguaales
        private float ProduccionEquiMat4, ProduccionEquiObr5, ProduccionEquiGFab6, ProduccionProMat1, ProduccionProObr2, ProduccionProGFab3, CostoUniMat1, CostoUniObr2, CostoUniGFab3, ProduccionEquiMat1, ProduccionEquiObr2, ProduccionEquiGFab3;

        //Variable Tabla 2
        //Variables Costos Unitarios
        private float MatInvInicial2 = 0;
        private float ManoObrInvInicial2 = 0;
        private float GFabriacionInvInicial2 = 0;
        // Costo Incurrido
        private float MatCostoIncu2 = 0;
        private float ManoObrCostoIncu2 = 0;
        private float GFabriacionCostoIncu2 = 0;

        //Varible multi
        float UnidadEquivalenteMAt;

        private DataGridView dataGridViewProducc = new DataGridView(); // Declaración del DataGridView
        private DataGridView dataGridViewCostoUni = new DataGridView(); // Declaración del DataGridView
        private DataGridView dataGridViewInventarioFinal = new DataGridView();
        private DataGridView dataGridViewProducionTerminada = new DataGridView();

        private Dictionary<string, int> valoresCeldas = new Dictionary<string, int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crear una instancia de DataGridView
            dataGridViewProducc.Dock = DockStyle.Fill; // Para que ocupe todo el espacio disponible
            dataGridViewCostoUni.Dock = DockStyle.Fill; // Para que ocupe todo el espacio disponible
            dataGridViewInventarioFinal.Dock = DockStyle.Fill;
            dataGridViewProducionTerminada.Dock = DockStyle.Fill;

            //Primer TABLA
            // Agregar cada columna por separado
            dataGridViewProducc.Columns.Add("Concepto", "Concepto");
            dataGridViewProducc.Columns.Add("ProduccionTerminada", "Produccion terminada");
            dataGridViewProducc.Columns.Add("Proceso1", "Proceso");
            dataGridViewProducc.Columns.Add("Avance1", "% Avance");
            dataGridViewProducc.Columns.Add("ProduccionEquivalente1", "Produccion Equivalente");
            dataGridViewProducc.Columns.Add("Proceso2", "Proceso");
            dataGridViewProducc.Columns.Add("Avance2", "% Avance");
            dataGridViewProducc.Columns.Add("ProduccionEquivalente2", "Produccion Equivalente");
            dataGridViewProducc.Columns.Add("ProduccionProcesada", "Produccion Procesada");

            dataGridViewProducc.Rows.Add();
            dataGridViewProducc.Rows.Add();
            dataGridViewProducc.Rows.Add();

            // Agregar 4 filas con datos
            dataGridViewProducc.Rows[0].Cells[0].Value = "Materiales";
            dataGridViewProducc.Rows[1].Cells[0].Value = "Mano De Obra";
            dataGridViewProducc.Rows[2].Cells[0].Value = "G. Fabricacion";


            //Segunda TABLA
            dataGridViewCostoUni.Columns.Add("Concepto", "Concepto");
            dataGridViewCostoUni.Columns.Add("Inventario Inicial", "Inventario Inicial");
            dataGridViewCostoUni.Columns.Add("Costo Incurrido", "Costo Incurrido");
            dataGridViewCostoUni.Columns.Add("Total", "Total");
            dataGridViewCostoUni.Columns.Add("Inventario Inicial2", "Inventario Inicial");
            dataGridViewCostoUni.Columns.Add("Proceso2", "Produccion Procesada");
            dataGridViewCostoUni.Columns.Add("Total2", "Total");
            dataGridViewCostoUni.Columns.Add("Costo Unitario Promedio", "Costo Unitario Promedio");

            dataGridViewCostoUni.Rows.Add();
            dataGridViewCostoUni.Rows.Add();
            dataGridViewCostoUni.Rows.Add();
            dataGridViewCostoUni.Rows.Add();

            // Agregar 4 filas con datos
            dataGridViewCostoUni.Rows[0].Cells[0].Value = "Materiales";
            dataGridViewCostoUni.Rows[1].Cells[0].Value = "Mano De Obra";
            dataGridViewCostoUni.Rows[2].Cells[0].Value = "G. Fabricacion";
            dataGridViewCostoUni.Rows[3].Cells[0].Value = "Suma Total";

            //Tercer TABLA
            dataGridViewInventarioFinal.Columns.Add("Concepto", "Concepto");
            dataGridViewInventarioFinal.Columns.Add("Unidades Equivalentes", "Unidades Equivalentes");
            dataGridViewInventarioFinal.Columns.Add("Costo Unitario Promedio", "Costo Unitario Promedio");
            dataGridViewInventarioFinal.Columns.Add("Total1", "Total");

            dataGridViewInventarioFinal.Rows.Add();
            dataGridViewInventarioFinal.Rows.Add();
            dataGridViewInventarioFinal.Rows.Add();
            dataGridViewInventarioFinal.Rows.Add();

            // Agregar 4 filas con datos
            dataGridViewInventarioFinal.Rows[0].Cells[0].Value = "Materiales";
            dataGridViewInventarioFinal.Rows[1].Cells[0].Value = "Mano De Obra";
            dataGridViewInventarioFinal.Rows[2].Cells[0].Value = "G. Fabricacion";
            dataGridViewInventarioFinal.Rows[3].Cells[0].Value = "Suma Total";

            //Cuarta TABLA
            dataGridViewProducionTerminada.Columns.Add("Concepto", "Concepto");
            dataGridViewProducionTerminada.Columns.Add("Unidades Terminadas", "Unidades Terminadas");
            dataGridViewProducionTerminada.Columns.Add("Costo Unitario Promedio", "Costo Unitario Promedio");
            dataGridViewProducionTerminada.Columns.Add("Total1", "Total");

            dataGridViewProducionTerminada.Rows.Add();
            dataGridViewProducionTerminada.Rows.Add();
            dataGridViewProducionTerminada.Rows.Add();
            dataGridViewProducionTerminada.Rows.Add();

            // Agregar 4 filas con datos
            dataGridViewProducionTerminada.Rows[0].Cells[0].Value = "Materiales";
            dataGridViewProducionTerminada.Rows[1].Cells[0].Value = "Mano De Obra";
            dataGridViewProducionTerminada.Rows[2].Cells[0].Value = "G. Fabricacion";
            dataGridViewProducionTerminada.Rows[3].Cells[0].Value = "Suma Total";
            // Declarar un diccionario para almacenar los valores de las celdas


            // Permitir la edición en las celdas deseadas
            // Permitir la edición en la "Columna 1" de las filas deseadas
            dataGridViewProducc.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 1)
                {
                    DataGridViewCell cell = dataGridViewProducc.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatProTer1 = valorEntero;
                                break;
                            case 1:
                                ManoObr1 = valorEntero;
                                break;
                            case 2:
                                GFabriacion1 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
                else if (columna == 2)
                {
                    DataGridViewCell cell = dataGridViewProducc.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatProce1 = valorEntero;
                                break;
                            case 1:
                                ManoObrProce1 = valorEntero;
                                break;
                            case 2:
                                GFabriacionProce1 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
                else if (columna == 3)
                {
                    DataGridViewCell cell = dataGridViewProducc.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatAvance1 = valorEntero;
                                break;
                            case 1:
                                ManoObrAvance1 = valorEntero;
                                break;
                            case 2:
                                GFabriacionAvance1 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }

                else if (columna == 5)
                {
                    DataGridViewCell cell = dataGridViewProducc.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatProce1_1 = valorEntero;
                                break;
                            case 1:
                                ManoObrProce1_1 = valorEntero;
                                break;
                            case 2:
                                GFabriacionProce1_1 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
                else if (columna == 6)
                {
                    DataGridViewCell cell = dataGridViewProducc.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatAvance1_1 = valorEntero;
                                break;
                            case 1:
                                ManoObrAvance1_1 = valorEntero;
                                break;
                            case 2:
                                GFabriacionAvance1_1 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
            };

            dataGridViewCostoUni.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 1)
                {
                    DataGridViewCell cell = dataGridViewCostoUni.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatInvInicial2 = valorEntero;
                                break;
                            case 1:
                                ManoObrInvInicial2 = valorEntero;
                                break;
                            case 2:
                                GFabriacionInvInicial2 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
                else if (columna == 2)
                {
                    DataGridViewCell cell = dataGridViewCostoUni.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float valorEntero))
                    {
                        switch (fila)
                        {
                            case 0:
                                MatCostoIncu2 = valorEntero;
                                break;
                            case 1:
                                ManoObrCostoIncu2 = valorEntero;
                                break;
                            case 2:
                                GFabriacionCostoIncu2 = valorEntero;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }

                }
            };

            this.Controls.Add(dataGridViewProducc);
            this.Controls.Add(dataGridViewCostoUni);

            tabControl1.TabPages[0].Controls.Add(dataGridViewProducc); // Cambia [0] al índice de la pestaña deseada
            tabControl1.TabPages[1].Controls.Add(dataGridViewCostoUni); // Cambia [0] al índice de la pestaña deseada
            tabControl1.TabPages[2].Controls.Add(dataGridViewInventarioFinal);
            tabControl1.TabPages[3].Controls.Add(dataGridViewProducionTerminada);
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            //Tabla 1
            //Poduccion Equivlente-Final de Materiales 
            ProduccionEquiMat1 = MatProce1 * MatAvance1;
            dataGridViewProducc.Rows[0].Cells[4].Value = ProduccionEquiMat1;
            //Poduccion Equivlente-Final de Mano de Obra  
            ProduccionEquiObr2 = ManoObrProce1 * ManoObrAvance1;
            dataGridViewProducc.Rows[1].Cells[4].Value = ProduccionEquiObr2;
            //Poduccion Equivlente-Final de G.Fbrrricacion 
            ProduccionEquiGFab3 = GFabriacionProce1 * GFabriacionAvance1;
            dataGridViewProducc.Rows[2].Cells[4].Value = ProduccionEquiGFab3;

            //Poduccion Equivlente-Inicial de Materiales
            ProduccionEquiMat4 = MatProce1_1 * MatAvance1_1;
            dataGridViewProducc.Rows[0].Cells[7].Value = ProduccionEquiMat4;
            //Poduccion Equivlente-Inicial de Mano de Obra
            ProduccionEquiObr5 = ManoObrProce1_1 * ManoObrAvance1_1;
            dataGridViewProducc.Rows[1].Cells[7].Value = ProduccionEquiObr5;
            //Poduccion Equivlente-Incial de G.Fbrrricacion
            ProduccionEquiGFab6 = GFabriacionProce1_1 * GFabriacionAvance1_1;
            dataGridViewProducc.Rows[2].Cells[7].Value = ProduccionEquiGFab6;

            //Produccion Procesada Materiales
            ProduccionProMat1 = MatProTer1 + ProduccionEquiMat1 - ProduccionEquiMat4;
            dataGridViewProducc.Rows[0].Cells[8].Value = ProduccionProMat1;
            //Produccion Procesada Mano de Obr
            ProduccionProObr2 = ManoObr1 + ProduccionEquiObr2 - ProduccionEquiObr5;
            dataGridViewProducc.Rows[1].Cells[8].Value = ProduccionProObr2;
            //Produccion Procesada G.Fabricacion
            ProduccionProGFab3 = GFabriacion1 + ProduccionEquiGFab3 - ProduccionEquiGFab6;
            dataGridViewProducc.Rows[2].Cells[8].Value = ProduccionProGFab3;

            //Tabla 2
            //Materiales Total Costo
            float Total1 = MatInvInicial2 * MatCostoIncu2;
            dataGridViewCostoUni.Rows[0].Cells[3].Value = Total1;
            //Mano Obraa Total Costo
            float Total2 = ManoObrInvInicial2 * ManoObrCostoIncu2;
            dataGridViewCostoUni.Rows[1].Cells[3].Value = Total2;
            //G.Fabricacion Total Costo
            float Total3 = GFabriacionInvInicial2 * GFabriacionCostoIncu2;
            dataGridViewCostoUni.Rows[2].Cells[3].Value = Total3;
            //Suma total
            float SumaTotal1 = Total1 + Total2 + Total3;
            dataGridViewCostoUni.Rows[3].Cells[3].Value = SumaTotal1;

            //Inventario Inicial Materiales
            dataGridViewCostoUni.Rows[0].Cells[4].Value = ProduccionEquiMat4;
            //Inventario Inicial Mano Obra
            dataGridViewCostoUni.Rows[1].Cells[4].Value = ProduccionEquiObr5;
            //Inventario Inicial G.Fabricacion
            dataGridViewCostoUni.Rows[2].Cells[4].Value = ProduccionEquiGFab6;

            //Produccion Procesada Materiales
            dataGridViewCostoUni.Rows[0].Cells[5].Value = ProduccionProMat1;
            //Produccion Procesada Mano Obra
            dataGridViewCostoUni.Rows[1].Cells[5].Value = ProduccionProObr2;
            //Produccion Procesada G.Fabricacion
            dataGridViewCostoUni.Rows[2].Cells[5].Value = ProduccionProGFab3;

            //Total Unidades Materiales
            float Total4 = ProduccionEquiMat4 + ProduccionProMat1;
            dataGridViewCostoUni.Rows[0].Cells[6].Value = Total4;
            //Total Unidades Mano Obra
            float Total5 = ProduccionEquiObr5 + ProduccionProObr2;
            dataGridViewCostoUni.Rows[1].Cells[6].Value = Total5;
            //Total Unidades G.Fabricacion
            float Total6 = ProduccionEquiGFab6 + ProduccionProGFab3;
            dataGridViewCostoUni.Rows[2].Cells[6].Value = Total6;

            //Costo Unitario Promedio Unidades Materiales
            CostoUniMat1 = Total1 / Total4;
            dataGridViewCostoUni.Rows[0].Cells[7].Value = CostoUniMat1;
            //Costo Unitario Promedio Unidades Mano Obra
            CostoUniObr2 = Total2 / Total5;
            dataGridViewCostoUni.Rows[1].Cells[7].Value = CostoUniObr2;
            //Costo Unitario Promedio Unidades G.Fabricacion
            CostoUniGFab3 = Total3 / Total6;
            dataGridViewCostoUni.Rows[2].Cells[7].Value = CostoUniGFab3;


            // Tabla 3
            //Unidades Equivalentes Materiales
            dataGridViewInventarioFinal.Rows[0].Cells[1].Value = MatProce1 * MatAvance1;
            //Unidades Equivalentes Mano Obra
            dataGridViewInventarioFinal.Rows[1].Cells[1].Value = ManoObrProce1 * ManoObrAvance1;
            //Unidades Equivalentes G.Fabricacion
            dataGridViewInventarioFinal.Rows[2].Cells[1].Value = GFabriacionProce1 * GFabriacionAvance1;

            //Costo Unitario Promedio Materiales
            dataGridViewInventarioFinal.Rows[0].Cells[2].Value = CostoUniMat1;
            //Costo Unitario Promedio Mano Obra
            dataGridViewInventarioFinal.Rows[1].Cells[2].Value = CostoUniObr2;
            //Costo Unitario Promedio G.Fabricacion
            dataGridViewInventarioFinal.Rows[2].Cells[2].Value = CostoUniGFab3;

            //Inventario Final Total Materiales
            float Total7 = ProduccionEquiMat1 * CostoUniMat1;
            dataGridViewInventarioFinal.Rows[0].Cells[3].Value = Total7;
            //Inventario Final Total Materiales
            float Total8 = ProduccionEquiObr2 * CostoUniObr2;
            dataGridViewInventarioFinal.Rows[1].Cells[3].Value = Total8;
            //Inventario Final Total Materiales
            float Total9 = ProduccionEquiGFab3 * CostoUniGFab3;
            dataGridViewInventarioFinal.Rows[2].Cells[3].Value = Total9;
            float SumaTotal2 = Total7 + Total8 + Total9;
            dataGridViewInventarioFinal.Rows[3].Cells[3].Value = SumaTotal2;

            //Tabla 4
            //Unidades Terminadas Materiales
            dataGridViewProducionTerminada.Rows[0].Cells[1].Value = MatProTer1;
            //Unidades Terminadas Mano Obra
            dataGridViewProducionTerminada.Rows[1].Cells[1].Value = ManoObr1;
            //Unidades Terminadas G.Faabricacion
            dataGridViewProducionTerminada.Rows[2].Cells[1].Value = GFabriacion1;

            //Costo Unitario Promedio Materiales
            dataGridViewProducionTerminada.Rows[0].Cells[2].Value = CostoUniMat1;
            //Costo Unitario Promedio Mano Obra
            dataGridViewProducionTerminada.Rows[1].Cells[2].Value = CostoUniObr2;
            //Costo Unitario Promedio G.Fabricaciom
            dataGridViewProducionTerminada.Rows[2].Cells[2].Value = CostoUniGFab3;

            //Produccion Terminada Materiales
            float Total10 = MatProTer1 * CostoUniMat1;
            dataGridViewProducionTerminada.Rows[0].Cells[3].Value = Total10;
            //Produccion Terminada Materiales
            float Total11 = ManoObr1 * CostoUniObr2;
            dataGridViewProducionTerminada.Rows[1].Cells[3].Value = Total11;
            //Produccion Terminada Materiales
            float Total12 = GFabriacion1 * CostoUniGFab3;
            dataGridViewProducionTerminada.Rows[2].Cells[3].Value = Total12;
            float SumaTotal3 = Total10 + Total11 + Total12;
            dataGridViewProducionTerminada.Rows[3].Cells[3].Value = SumaTotal3;

            this.Controls.Add(dataGridViewProducc);
            this.Controls.Add(dataGridViewCostoUni);
            this.Controls.Add(dataGridViewInventarioFinal);
            this.Controls.Add(dataGridViewProducionTerminada);
            tabControl1.TabPages[0].Controls.Add(dataGridViewProducc);
            tabControl1.TabPages[1].Controls.Add(dataGridViewCostoUni);
            tabControl1.TabPages[2].Controls.Add(dataGridViewInventarioFinal);
            tabControl1.TabPages[3].Controls.Add(dataGridViewProducionTerminada);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}