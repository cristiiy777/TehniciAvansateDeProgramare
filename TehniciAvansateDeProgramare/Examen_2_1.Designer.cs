namespace TehniciAvansateDeProgramare
{
    partial class Examen_2_1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.eleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAP_examen_2DataSet = new TehniciAvansateDeProgramare.TAP_examen_2DataSet();
            this.noteSiNumeElevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleviTableAdapter = new TehniciAvansateDeProgramare.TAP_examen_2DataSetTableAdapters.EleviTableAdapter();
            this.noteTableAdapter = new TehniciAvansateDeProgramare.TAP_examen_2DataSetTableAdapters.NoteTableAdapter();
            this.noteSiNumeElevTableAdapter = new TehniciAvansateDeProgramare.TAP_examen_2DataSetTableAdapters.NoteSiNumeElevTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMaterieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAP_examen_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteSiNumeElevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(347, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pune Notă";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eleviBindingSource
            // 
            this.eleviBindingSource.DataMember = "Elevi";
            this.eleviBindingSource.DataSource = this.tAP_examen_2DataSet;
            // 
            // tAP_examen_2DataSet
            // 
            this.tAP_examen_2DataSet.DataSetName = "TAP_examen_2DataSet";
            this.tAP_examen_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteSiNumeElevBindingSource
            // 
            this.noteSiNumeElevBindingSource.DataMember = "NoteSiNumeElev";
            this.noteSiNumeElevBindingSource.DataSource = this.tAP_examen_2DataSet;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataMember = "Note";
            this.noteBindingSource.DataSource = this.tAP_examen_2DataSet;
            // 
            // eleviTableAdapter
            // 
            this.eleviTableAdapter.ClearBeforeFill = true;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // noteSiNumeElevTableAdapter
            // 
            this.noteSiNumeElevTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn,
            this.clasaDataGridViewTextBoxColumn1,
            this.dMaterieDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.noteSiNumeElevBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(563, 185);
            this.dataGridView2.TabIndex = 6;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            this.numeDataGridViewTextBoxColumn1.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn1.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            this.numeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasaDataGridViewTextBoxColumn1
            // 
            this.clasaDataGridViewTextBoxColumn1.DataPropertyName = "Clasa";
            this.clasaDataGridViewTextBoxColumn1.HeaderText = "Clasa";
            this.clasaDataGridViewTextBoxColumn1.Name = "clasaDataGridViewTextBoxColumn1";
            this.clasaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dMaterieDataGridViewTextBoxColumn
            // 
            this.dMaterieDataGridViewTextBoxColumn.DataPropertyName = "DMaterie";
            this.dMaterieDataGridViewTextBoxColumn.HeaderText = "DMaterie";
            this.dMaterieDataGridViewTextBoxColumn.Name = "dMaterieDataGridViewTextBoxColumn";
            this.dMaterieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Examen_2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 260);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Name = "Examen_2_1";
            this.Text = "Examen_2";
            this.Activated += new System.EventHandler(this.Examen_2_1_Activated);
            this.Load += new System.EventHandler(this.Examen_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAP_examen_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteSiNumeElevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TAP_examen_2DataSet tAP_examen_2DataSet;
        private System.Windows.Forms.BindingSource eleviBindingSource;
        private TAP_examen_2DataSetTableAdapters.EleviTableAdapter eleviTableAdapter;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private TAP_examen_2DataSetTableAdapters.NoteTableAdapter noteTableAdapter;
        private System.Windows.Forms.BindingSource noteSiNumeElevBindingSource;
        private TAP_examen_2DataSetTableAdapters.NoteSiNumeElevTableAdapter noteSiNumeElevTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMaterieDataGridViewTextBoxColumn;
    }
}