namespace LottoNumberGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.lblNumberOfDraws = new System.Windows.Forms.Label();
            this.nudNumberOfDraws = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDraws)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPreview.Location = new System.Drawing.Point(12, 90);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreview.Size = new System.Drawing.Size(435, 219);
            this.txtPreview.TabIndex = 2;
            this.txtPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerateNumbers.Location = new System.Drawing.Point(12, 314);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(157, 64);
            this.btnGenerateNumbers.TabIndex = 3;
            this.btnGenerateNumbers.Text = "Generate numbers";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.Enabled = false;
            this.btnExportToCsv.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExportToCsv.Location = new System.Drawing.Point(290, 314);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(157, 64);
            this.btnExportToCsv.TabIndex = 4;
            this.btnExportToCsv.Text = "Export to .csv";
            this.btnExportToCsv.UseVisualStyleBackColor = true;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // lblNumberOfDraws
            // 
            this.lblNumberOfDraws.AutoSize = true;
            this.lblNumberOfDraws.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumberOfDraws.Location = new System.Drawing.Point(155, 9);
            this.lblNumberOfDraws.Name = "lblNumberOfDraws";
            this.lblNumberOfDraws.Size = new System.Drawing.Size(159, 22);
            this.lblNumberOfDraws.TabIndex = 0;
            this.lblNumberOfDraws.Text = "Number of draws";
            // 
            // nudNumberOfDraws
            // 
            this.nudNumberOfDraws.Location = new System.Drawing.Point(209, 34);
            this.nudNumberOfDraws.Name = "nudNumberOfDraws";
            this.nudNumberOfDraws.Size = new System.Drawing.Size(42, 20);
            this.nudNumberOfDraws.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 397);
            this.Controls.Add(this.nudNumberOfDraws);
            this.Controls.Add(this.lblNumberOfDraws);
            this.Controls.Add(this.btnExportToCsv);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Controls.Add(this.txtPreview);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lotto number generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDraws)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.Button btnExportToCsv;
        private System.Windows.Forms.Label lblNumberOfDraws;
        private System.Windows.Forms.NumericUpDown nudNumberOfDraws;
    }
}

