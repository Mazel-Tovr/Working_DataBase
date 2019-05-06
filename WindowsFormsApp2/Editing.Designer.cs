namespace WindowsFormsApp2
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.filds = new System.Windows.Forms.TextBox();
            this.tables = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filds
            // 
            this.filds.Location = new System.Drawing.Point(669, 96);
            this.filds.Name = "filds";
            this.filds.Size = new System.Drawing.Size(10, 20);
            this.filds.TabIndex = 2;
            this.filds.Visible = false;
            // 
            // tables
            // 
            this.tables.Location = new System.Drawing.Point(644, 96);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(10, 20);
            this.tables.TabIndex = 3;
            this.tables.Visible = false;
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.filds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editing";
            this.Text = "Editing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editing_FormClosing);
            this.Load += new System.EventHandler(this.Editing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filds;
        private System.Windows.Forms.TextBox tables;
    }
}