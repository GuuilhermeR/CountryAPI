namespace FindCountryAPI
{
    partial class frmFindCountry
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(12, 82);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(540, 231);
            this.dtgDados.TabIndex = 2;
            this.dtgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(477, 53);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 53);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(12, 12);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(162, 20);
            this.txtCountry.TabIndex = 0;
            // 
            // frmFindCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 325);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtgDados);
            this.Name = "frmFindCountry";
            this.Text = "Países";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCountry;
    }
}

