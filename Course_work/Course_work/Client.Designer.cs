namespace Course_work
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportomplexBDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportomplexBDDataSet1 = new Course_work.SportomplexBDDataSet();
            this.GetBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.sportomplexBDDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.clientTableAdapter1 = new Course_work.SportomplexBDDataSetTableAdapters.ClientTableAdapter();
            this.sportomplexBDDataSet2 = new Course_work.SportomplexBDDataSet();
            this.sportomplexBDDataSet3 = new Course_work.SportomplexBDDataSet();
            this.buttonSortAndFiltration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.GroupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM Client";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-02112EF\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=SportomplexBD";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Client] ([Name], [Surname], [Patronymic], [Sex], [Mobile_phone]) VAL" +
    "UES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.WChar, 0, "Name"),
            new System.Data.OleDb.OleDbParameter("Surname", System.Data.OleDb.OleDbType.WChar, 0, "Surname"),
            new System.Data.OleDb.OleDbParameter("Patronymic", System.Data.OleDb.OleDbType.WChar, 0, "Patronymic"),
            new System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.WChar, 0, "Sex"),
            new System.Data.OleDb.OleDbParameter("Mobile_phone", System.Data.OleDb.OleDbType.WChar, 0, "Mobile_phone")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.WChar, 0, "Name"),
            new System.Data.OleDb.OleDbParameter("Surname", System.Data.OleDb.OleDbType.WChar, 0, "Surname"),
            new System.Data.OleDb.OleDbParameter("Patronymic", System.Data.OleDb.OleDbType.WChar, 0, "Patronymic"),
            new System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.WChar, 0, "Sex"),
            new System.Data.OleDb.OleDbParameter("Mobile_phone", System.Data.OleDb.OleDbType.WChar, 0, "Mobile_phone"),
            new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Surname", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Surname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Patronymic", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Patronymic", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mobile_phone", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mobile_phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM [Client] WHERE (([Name] = ?) AND ([Surname] = ?) AND ([Patronymic] = " +
    "?) AND ([Sex] = ?) AND ([Mobile_phone] = ?) AND ([ClientID] = ?))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Surname", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Surname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Patronymic", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Patronymic", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mobile_phone", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mobile_phone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Client", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Name", "Name"),
                        new System.Data.Common.DataColumnMapping("Surname", "Surname"),
                        new System.Data.Common.DataColumnMapping("Patronymic", "Patronymic"),
                        new System.Data.Common.DataColumnMapping("Sex", "Sex"),
                        new System.Data.Common.DataColumnMapping("Mobile_phone", "Mobile_phone"),
                        new System.Data.Common.DataColumnMapping("ClientID", "ClientID")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.mobilephoneDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Client";
            this.dataGridView1.DataSource = this.sportomplexBDDataSet1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // mobilephoneDataGridViewTextBoxColumn
            // 
            this.mobilephoneDataGridViewTextBoxColumn.DataPropertyName = "Mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.HeaderText = "Mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.Name = "mobilephoneDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sportomplexBDDataSet1BindingSource
            // 
            this.sportomplexBDDataSet1BindingSource.DataSource = this.sportomplexBDDataSet1;
            this.sportomplexBDDataSet1BindingSource.Position = 0;
            // 
            // sportomplexBDDataSet1
            // 
            this.sportomplexBDDataSet1.DataSetName = "SportomplexBDDataSet";
            this.sportomplexBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetBtn
            // 
            this.GetBtn.Location = new System.Drawing.Point(12, 4);
            this.GetBtn.Name = "GetBtn";
            this.GetBtn.Size = new System.Drawing.Size(108, 60);
            this.GetBtn.TabIndex = 1;
            this.GetBtn.Text = "Натисніть, щоб зчитати данні";
            this.GetBtn.UseVisualStyleBackColor = true;
            this.GetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(12, 68);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(108, 60);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Натисніть, щоб зберегти зміни";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // sportomplexBDDataSet1BindingSource1
            // 
            this.sportomplexBDDataSet1BindingSource1.DataSource = this.sportomplexBDDataSet1;
            this.sportomplexBDDataSet1BindingSource1.Position = 0;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(197, 45);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(100, 20);
            this.SortTextBox.TabIndex = 3;
            this.SortTextBox.Text = "Surname";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(197, 69);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 4;
            this.FilterTextBox.Text = "Sex = \'чол.\'";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // sportomplexBDDataSet2
            // 
            this.sportomplexBDDataSet2.DataSetName = "SportomplexBDDataSet";
            this.sportomplexBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportomplexBDDataSet3
            // 
            this.sportomplexBDDataSet3.DataSetName = "SportomplexBDDataSet";
            this.sportomplexBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSortAndFiltration
            // 
            this.buttonSortAndFiltration.Location = new System.Drawing.Point(303, 26);
            this.buttonSortAndFiltration.Name = "buttonSortAndFiltration";
            this.buttonSortAndFiltration.Size = new System.Drawing.Size(103, 71);
            this.buttonSortAndFiltration.TabIndex = 7;
            this.buttonSortAndFiltration.Text = "Сортування і фільтрація";
            this.buttonSortAndFiltration.UseVisualStyleBackColor = true;
            this.buttonSortAndFiltration.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сортування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фільтрація";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(554, 38);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(77, 47);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // GroupBtn
            // 
            this.GroupBtn.Location = new System.Drawing.Point(429, 26);
            this.GroupBtn.Name = "GroupBtn";
            this.GroupBtn.Size = new System.Drawing.Size(93, 71);
            this.GroupBtn.TabIndex = 11;
            this.GroupBtn.Text = "Групуючий запит";
            this.GroupBtn.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 286);
            this.Controls.Add(this.GroupBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSortAndFiltration);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.GetBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportomplexBDDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private SportomplexBDDataSet sportomplexBDDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sportomplexBDDataSet1BindingSource;
        private System.Windows.Forms.BindingSource sportomplexBDDataSet1BindingSource1;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private SportomplexBDDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private SportomplexBDDataSet sportomplexBDDataSet2;
        private SportomplexBDDataSet sportomplexBDDataSet3;
        private System.Windows.Forms.Button buttonSortAndFiltration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button GroupBtn;
    }
}