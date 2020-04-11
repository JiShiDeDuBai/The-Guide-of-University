namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProName = new System.Windows.Forms.ComboBox();
            this.Batch = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(670, 465);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProName
            // 
            this.ProName.FormattingEnabled = true;
            this.ProName.Items.AddRange(new object[] {
            "四川",
            "重庆",
            "北京",
            "云南"});
            this.ProName.SelectedIndex = 0;
            this.ProName.Location = new System.Drawing.Point(72, 129);
            this.ProName.Name = "ProName";
            this.ProName.Size = new System.Drawing.Size(121, 23);
            this.ProName.TabIndex = 1;
            // 
            // Batch
            // 
            this.Batch.FormattingEnabled = true;
            this.Batch.Items.AddRange(new object[] {
            "本科一批",
            "本科二批"});
            this.Batch.SelectedIndex = 0;
            this.Batch.Location = new System.Drawing.Point(72, 191);
            this.Batch.Name = "Batch";
            this.Batch.Size = new System.Drawing.Size(121, 23);
            this.Batch.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "文科",
            "理科"});
            this.Type.SelectedIndex = 0;
            this.Type.Location = new System.Drawing.Point(72, 255);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 23);
            this.Type.TabIndex = 3;
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.year.SelectedIndex = 1;
            this.year.Location = new System.Drawing.Point(72, 324);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(121, 23);
            this.year.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Batch);
            this.Controls.Add(this.ProName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ProName;
        private System.Windows.Forms.ComboBox Batch;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Button button1;
    }
}

