
namespace MietApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.dataGridViewWohnimmobilie = new System.Windows.Forms.DataGridView();
            this.dataGridViewGewerbeimmo = new System.Windows.Forms.DataGridView();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raumanzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreisProQM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWohnimmobilie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGewerbeimmo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(39, 23);
            this.buttonW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(574, 49);
            this.buttonW.TabIndex = 0;
            this.buttonW.Text = "Neue Wohnimmobilie";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(689, 23);
            this.buttonG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(538, 49);
            this.buttonG.TabIndex = 1;
            this.buttonG.Text = "Neue Gewerbeimmobilie";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewWohnimmobilie
            // 
            this.dataGridViewWohnimmobilie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWohnimmobilie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adresse,
            this.Raumanzahl,
            this.PreisProQM});
            this.dataGridViewWohnimmobilie.Location = new System.Drawing.Point(39, 79);
            this.dataGridViewWohnimmobilie.Name = "dataGridViewWohnimmobilie";
            this.dataGridViewWohnimmobilie.RowHeadersWidth = 51;
            this.dataGridViewWohnimmobilie.RowTemplate.Height = 24;
            this.dataGridViewWohnimmobilie.Size = new System.Drawing.Size(574, 433);
            this.dataGridViewWohnimmobilie.TabIndex = 2;
            // 
            // dataGridViewGewerbeimmo
            // 
            this.dataGridViewGewerbeimmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGewerbeimmo.Location = new System.Drawing.Point(689, 79);
            this.dataGridViewGewerbeimmo.Name = "dataGridViewGewerbeimmo";
            this.dataGridViewGewerbeimmo.RowHeadersWidth = 51;
            this.dataGridViewGewerbeimmo.RowTemplate.Height = 24;
            this.dataGridViewGewerbeimmo.Size = new System.Drawing.Size(538, 433);
            this.dataGridViewGewerbeimmo.TabIndex = 3;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            this.Adresse.Width = 125;
            // 
            // Raumanzahl
            // 
            this.Raumanzahl.HeaderText = "Raumanzahl";
            this.Raumanzahl.MinimumWidth = 6;
            this.Raumanzahl.Name = "Raumanzahl";
            this.Raumanzahl.Width = 125;
            // 
            // PreisProQM
            // 
            this.PreisProQM.HeaderText = "Preis pro qm";
            this.PreisProQM.MinimumWidth = 6;
            this.PreisProQM.Name = "PreisProQM";
            this.PreisProQM.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 574);
            this.Controls.Add(this.dataGridViewGewerbeimmo);
            this.Controls.Add(this.dataGridViewWohnimmobilie);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonW);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWohnimmobilie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGewerbeimmo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.DataGridView dataGridViewWohnimmobilie;
        private System.Windows.Forms.DataGridView dataGridViewGewerbeimmo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raumanzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreisProQM;
    }
}

