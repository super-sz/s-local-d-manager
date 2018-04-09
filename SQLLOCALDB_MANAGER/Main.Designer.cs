namespace SQLLOCALDB_MANAGER
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderSeperator = new System.Windows.Forms.Panel();
            this.AttachDatabaseLabel = new System.Windows.Forms.Label();
            this.Directory = new System.Windows.Forms.TextBox();
            this.BrowseDirectory = new System.Windows.Forms.Button();
            this.AttachDatabase = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInfos = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox_Read = new System.Windows.Forms.TextBox();
            this.instanceNameTextbox = new System.Windows.Forms.TextBox();
            this.SQLLocalDBInstanceNameLabel = new System.Windows.Forms.Label();
            this.SeparateMiddle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxInstanceNameGestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(129, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "SQL Local DB Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des bases de données et de l\'état de l\'instance pour SQL Local DB\r\n";
            // 
            // HeaderSeperator
            // 
            this.HeaderSeperator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeaderSeperator.Location = new System.Drawing.Point(-5, 52);
            this.HeaderSeperator.Name = "HeaderSeperator";
            this.HeaderSeperator.Size = new System.Drawing.Size(729, 1);
            this.HeaderSeperator.TabIndex = 2;
            // 
            // AttachDatabaseLabel
            // 
            this.AttachDatabaseLabel.AutoSize = true;
            this.AttachDatabaseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachDatabaseLabel.Location = new System.Drawing.Point(10, 66);
            this.AttachDatabaseLabel.Name = "AttachDatabaseLabel";
            this.AttachDatabaseLabel.Size = new System.Drawing.Size(267, 15);
            this.AttachDatabaseLabel.TabIndex = 3;
            this.AttachDatabaseLabel.Text = "Attacher une nouvelle base SQL Local DB (*.mdf)";
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(13, 88);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(608, 23);
            this.Directory.TabIndex = 4;
            // 
            // BrowseDirectory
            // 
            this.BrowseDirectory.Location = new System.Drawing.Point(627, 87);
            this.BrowseDirectory.Name = "BrowseDirectory";
            this.BrowseDirectory.Size = new System.Drawing.Size(75, 25);
            this.BrowseDirectory.TabIndex = 5;
            this.BrowseDirectory.Text = "Parcourir...";
            this.BrowseDirectory.UseVisualStyleBackColor = true;
            this.BrowseDirectory.Click += new System.EventHandler(this.BrowseDirectory_Click);
            // 
            // AttachDatabase
            // 
            this.AttachDatabase.Location = new System.Drawing.Point(456, 138);
            this.AttachDatabase.Name = "AttachDatabase";
            this.AttachDatabase.Size = new System.Drawing.Size(245, 25);
            this.AttachDatabase.TabIndex = 6;
            this.AttachDatabase.Text = "Attacher la base de données au serveur";
            this.AttachDatabase.UseVisualStyleBackColor = true;
            this.AttachDatabase.Click += new System.EventHandler(this.AttachDatabase_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(281, 222);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(361, 222);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Démarrer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInfos
            // 
            this.btnInfos.Location = new System.Drawing.Point(442, 222);
            this.btnInfos.Name = "btnInfos";
            this.btnInfos.Size = new System.Drawing.Size(97, 23);
            this.btnInfos.TabIndex = 12;
            this.btnInfos.Text = "Informations";
            this.btnInfos.UseVisualStyleBackColor = true;
            this.btnInfos.Click += new System.EventHandler(this.btnInfos_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(545, 222);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Arrêter";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(625, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox_Read
            // 
            this.textBox_Read.Location = new System.Drawing.Point(13, 263);
            this.textBox_Read.Multiline = true;
            this.textBox_Read.Name = "textBox_Read";
            this.textBox_Read.ReadOnly = true;
            this.textBox_Read.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Read.Size = new System.Drawing.Size(687, 186);
            this.textBox_Read.TabIndex = 15;
            // 
            // instanceNameTextbox
            // 
            this.instanceNameTextbox.Location = new System.Drawing.Point(14, 139);
            this.instanceNameTextbox.Name = "instanceNameTextbox";
            this.instanceNameTextbox.Size = new System.Drawing.Size(436, 23);
            this.instanceNameTextbox.TabIndex = 16;
            // 
            // SQLLocalDBInstanceNameLabel
            // 
            this.SQLLocalDBInstanceNameLabel.AutoSize = true;
            this.SQLLocalDBInstanceNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLLocalDBInstanceNameLabel.Location = new System.Drawing.Point(10, 119);
            this.SQLLocalDBInstanceNameLabel.Name = "SQLLocalDBInstanceNameLabel";
            this.SQLLocalDBInstanceNameLabel.Size = new System.Drawing.Size(179, 15);
            this.SQLLocalDBInstanceNameLabel.TabIndex = 17;
            this.SQLLocalDBInstanceNameLabel.Text = "Nom de l\'Instance SQL Local DB";
            // 
            // SeparateMiddle
            // 
            this.SeparateMiddle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeparateMiddle.Location = new System.Drawing.Point(-19, 183);
            this.SeparateMiddle.Name = "SeparateMiddle";
            this.SeparateMiddle.Size = new System.Drawing.Size(743, 1);
            this.SeparateMiddle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gestion de l\'Instance SQL Local DB";
            // 
            // TextBoxInstanceNameGestion
            // 
            this.TextBoxInstanceNameGestion.Location = new System.Drawing.Point(13, 222);
            this.TextBoxInstanceNameGestion.Name = "TextBoxInstanceNameGestion";
            this.TextBoxInstanceNameGestion.Size = new System.Drawing.Size(262, 23);
            this.TextBoxInstanceNameGestion.TabIndex = 19;
            this.TextBoxInstanceNameGestion.Text = "MSSQLLocalDB";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxInstanceNameGestion);
            this.Controls.Add(this.SeparateMiddle);
            this.Controls.Add(this.SQLLocalDBInstanceNameLabel);
            this.Controls.Add(this.instanceNameTextbox);
            this.Controls.Add(this.textBox_Read);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnInfos);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.AttachDatabase);
            this.Controls.Add(this.BrowseDirectory);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.AttachDatabaseLabel);
            this.Controls.Add(this.HeaderSeperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(730, 500);
            this.MinimumSize = new System.Drawing.Size(730, 500);
            this.Name = "Main";
            this.Text = "SQL Local DB Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HeaderSeperator;
        private System.Windows.Forms.Label AttachDatabaseLabel;
        private System.Windows.Forms.TextBox Directory;
        private System.Windows.Forms.Button BrowseDirectory;
        private System.Windows.Forms.Button AttachDatabase;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInfos;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox_Read;
        private System.Windows.Forms.TextBox instanceNameTextbox;
        private System.Windows.Forms.Label SQLLocalDBInstanceNameLabel;
        private System.Windows.Forms.Panel SeparateMiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxInstanceNameGestion;
    }
}

