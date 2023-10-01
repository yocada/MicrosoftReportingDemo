namespace MicrosoftReportingDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bLaunchReport = new System.Windows.Forms.Button();
            this.rvDemo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lSubTitle = new System.Windows.Forms.Label();
            this.txtSubTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bLaunchReport
            // 
            this.bLaunchReport.Location = new System.Drawing.Point(665, 12);
            this.bLaunchReport.Name = "bLaunchReport";
            this.bLaunchReport.Size = new System.Drawing.Size(112, 48);
            this.bLaunchReport.TabIndex = 0;
            this.bLaunchReport.Text = "Launch report";
            this.bLaunchReport.UseVisualStyleBackColor = true;
            // 
            // rvDemo
            // 
            this.rvDemo.LocalReport.ReportEmbeddedResource = "MicrosoftReportingDemo.ReportDemo.rdlc";
            this.rvDemo.Location = new System.Drawing.Point(12, 70);
            this.rvDemo.Name = "rvDemo";
            this.rvDemo.ServerReport.BearerToken = null;
            this.rvDemo.Size = new System.Drawing.Size(765, 368);
            this.rvDemo.TabIndex = 1;
            // 
            // lSubTitle
            // 
            this.lSubTitle.AutoSize = true;
            this.lSubTitle.Location = new System.Drawing.Point(12, 12);
            this.lSubTitle.Name = "lSubTitle";
            this.lSubTitle.Size = new System.Drawing.Size(42, 13);
            this.lSubTitle.TabIndex = 2;
            this.lSubTitle.Text = "Subtitle";
            // 
            // txtSubTitle
            // 
            this.txtSubTitle.Location = new System.Drawing.Point(53, 9);
            this.txtSubTitle.Name = "txtSubTitle";
            this.txtSubTitle.Size = new System.Drawing.Size(158, 20);
            this.txtSubTitle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSubTitle);
            this.Controls.Add(this.lSubTitle);
            this.Controls.Add(this.rvDemo);
            this.Controls.Add(this.bLaunchReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLaunchReport;
        private Microsoft.Reporting.WinForms.ReportViewer rvDemo;
        private System.Windows.Forms.Label lSubTitle;
        private System.Windows.Forms.TextBox txtSubTitle;
    }
}

