namespace TehniciAvansateDeProgramare
{
    partial class Examen_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tAP_examen_1DataSet = new TehniciAvansateDeProgramare.TAP_examen_1DataSet();
            this.lucrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucrariTableAdapter = new TehniciAvansateDeProgramare.TAP_examen_1DataSetTableAdapters.LucrariTableAdapter();
            this.comboLucrare = new System.Windows.Forms.ComboBox();
            this.lucrariConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCantitate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMaterial = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new TehniciAvansateDeProgramare.TAP_examen_1DataSetTableAdapters.MaterialTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumTableAdapter = new TehniciAvansateDeProgramare.TAP_examen_1DataSetTableAdapters.ConsumTableAdapter();
            this.idLucrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tAP_examen_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lucrare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // tAP_examen_1DataSet
            // 
            this.tAP_examen_1DataSet.DataSetName = "TAP_examen_1DataSet";
            this.tAP_examen_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lucrariBindingSource
            // 
            this.lucrariBindingSource.DataMember = "Lucrari";
            this.lucrariBindingSource.DataSource = this.tAP_examen_1DataSet;
            // 
            // lucrariTableAdapter
            // 
            this.lucrariTableAdapter.ClearBeforeFill = true;
            // 
            // comboLucrare
            // 
            this.comboLucrare.DataSource = this.lucrariBindingSource;
            this.comboLucrare.DisplayMember = "DenumireLucrare";
            this.comboLucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLucrare.FormattingEnabled = true;
            this.comboLucrare.Location = new System.Drawing.Point(125, 27);
            this.comboLucrare.Name = "comboLucrare";
            this.comboLucrare.Size = new System.Drawing.Size(200, 26);
            this.comboLucrare.TabIndex = 4;
            this.comboLucrare.ValueMember = "IdLucrare";
            // 
            // lucrariConsumBindingSource
            // 
            this.lucrariConsumBindingSource.DataMember = "LucrariConsum";
            this.lucrariConsumBindingSource.DataSource = this.lucrariBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantitate";
            // 
            // textCantitate
            // 
            this.textCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantitate.Location = new System.Drawing.Point(125, 151);
            this.textCantitate.Name = "textCantitate";
            this.textCantitate.Size = new System.Drawing.Size(200, 24);
            this.textCantitate.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirmare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboMaterial
            // 
            this.comboMaterial.DataSource = this.materialBindingSource;
            this.comboMaterial.DisplayMember = "DMaterial";
            this.comboMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaterial.FormattingEnabled = true;
            this.comboMaterial.Location = new System.Drawing.Point(125, 111);
            this.comboMaterial.Name = "comboMaterial";
            this.comboMaterial.Size = new System.Drawing.Size(200, 26);
            this.comboMaterial.TabIndex = 11;
            this.comboMaterial.ValueMember = "IdMaterial";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.tAP_examen_1DataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLucrareDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn,
            this.idMaterialDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // consumBindingSource
            // 
            this.consumBindingSource.DataMember = "Consum";
            this.consumBindingSource.DataSource = this.tAP_examen_1DataSet;
            // 
            // consumTableAdapter
            // 
            this.consumTableAdapter.ClearBeforeFill = true;
            // 
            // idLucrareDataGridViewTextBoxColumn
            // 
            this.idLucrareDataGridViewTextBoxColumn.DataPropertyName = "IdLucrare";
            this.idLucrareDataGridViewTextBoxColumn.HeaderText = "IdLucrare";
            this.idLucrareDataGridViewTextBoxColumn.Name = "idLucrareDataGridViewTextBoxColumn";
            this.idLucrareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Examen_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCantitate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboLucrare);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Examen_1";
            this.Text = "Examen_1";
            this.Load += new System.EventHandler(this.Examen_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tAP_examen_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private TAP_examen_1DataSet tAP_examen_1DataSet;
        private System.Windows.Forms.BindingSource lucrariBindingSource;
        private TAP_examen_1DataSetTableAdapters.LucrariTableAdapter lucrariTableAdapter;
        private System.Windows.Forms.ComboBox comboLucrare;
        private System.Windows.Forms.BindingSource lucrariConsumBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCantitate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboMaterial;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private TAP_examen_1DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource consumBindingSource;
        private TAP_examen_1DataSetTableAdapters.ConsumTableAdapter consumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLucrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}