namespace WindowsFormsApp2
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.Search_request = new System.Windows.Forms.Button();
            this.del_request = new System.Windows.Forms.Button();
            this.your_request = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_request = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_request
            // 
            this.Search_request.Location = new System.Drawing.Point(12, 366);
            this.Search_request.Name = "Search_request";
            this.Search_request.Size = new System.Drawing.Size(183, 62);
            this.Search_request.TabIndex = 0;
            this.Search_request.Text = "Запрос на поиск по id";
            this.Search_request.UseVisualStyleBackColor = true;
            this.Search_request.Click += new System.EventHandler(this.Search_request_Click);
            // 
            // del_request
            // 
            this.del_request.Location = new System.Drawing.Point(422, 366);
            this.del_request.Name = "del_request";
            this.del_request.Size = new System.Drawing.Size(173, 62);
            this.del_request.TabIndex = 2;
            this.del_request.Text = "Запрос на удаление записей по id";
            this.del_request.UseVisualStyleBackColor = true;
            this.del_request.Click += new System.EventHandler(this.del_request_Click);
            // 
            // your_request
            // 
            this.your_request.Location = new System.Drawing.Point(601, 366);
            this.your_request.Name = "your_request";
            this.your_request.Size = new System.Drawing.Size(164, 62);
            this.your_request.TabIndex = 3;
            this.your_request.Text = "Введите свой запрос";
            this.your_request.UseVisualStyleBackColor = true;
            this.your_request.Click += new System.EventHandler(this.your_request_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 331);
            this.dataGridView1.TabIndex = 5;
            // 
            // add_request
            // 
            this.add_request.Location = new System.Drawing.Point(220, 366);
            this.add_request.Name = "add_request";
            this.add_request.Size = new System.Drawing.Size(173, 62);
            this.add_request.TabIndex = 6;
            this.add_request.Text = "Запрос на добавление записей";
            this.add_request.UseVisualStyleBackColor = true;
            this.add_request.Click += new System.EventHandler(this.add_request_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 440);
            this.Controls.Add(this.add_request);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.your_request);
            this.Controls.Add(this.del_request);
            this.Controls.Add(this.Search_request);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Requests";
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Requests_FormClosed);
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search_request;
        private System.Windows.Forms.Button del_request;
        private System.Windows.Forms.Button your_request;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_request;
    }
}