namespace WindowsFormsApp2
{
    partial class Report
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
            this.reportClientPFDataSet1 = new WindowsFormsApp2.ReportClientPFDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientPFDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportClientPFDataSet1
            // 
            this.reportClientPFDataSet1.DataSetName = "ReportClientPFDataSet";
            this.reportClientPFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.reportClientPFDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportClientPFDataSet reportClientPFDataSet1;
    }
}