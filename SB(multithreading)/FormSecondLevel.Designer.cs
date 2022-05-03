
namespace SB_multithreading_
{
    partial class FormSecondLevel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvField2 = new System.Windows.Forms.DataGridView();
            this.dgvMove2 = new System.Windows.Forms.DataGridView();
            this.buttonToRun2 = new System.Windows.Forms.Button();
            this.buttonStartOver2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonright = new System.Windows.Forms.Button();
            this.buttondown = new System.Windows.Forms.Button();
            this.buttonup = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvField2
            // 
            this.dgvField2.AllowUserToAddRows = false;
            this.dgvField2.AllowUserToDeleteRows = false;
            this.dgvField2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvField2.ColumnHeadersVisible = false;
            this.dgvField2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvField2.Location = new System.Drawing.Point(46, 107);
            this.dgvField2.Name = "dgvField2";
            this.dgvField2.ReadOnly = true;
            this.dgvField2.RowHeadersVisible = false;
            this.dgvField2.RowTemplate.Height = 45;
            this.dgvField2.Size = new System.Drawing.Size(230, 230);
            this.dgvField2.TabIndex = 0;
            // 
            // dgvMove2
            // 
            this.dgvMove2.AllowUserToAddRows = false;
            this.dgvMove2.AllowUserToDeleteRows = false;
            this.dgvMove2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMove2.ColumnHeadersVisible = false;
            this.dgvMove2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvMove2.Location = new System.Drawing.Point(547, 132);
            this.dgvMove2.Name = "dgvMove2";
            this.dgvMove2.ReadOnly = true;
            this.dgvMove2.RowHeadersVisible = false;
            this.dgvMove2.RowTemplate.Height = 40;
            this.dgvMove2.Size = new System.Drawing.Size(123, 205);
            this.dgvMove2.TabIndex = 1;
            // 
            // buttonToRun2
            // 
            this.buttonToRun2.BackColor = System.Drawing.Color.White;
            this.buttonToRun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRun2.Location = new System.Drawing.Point(46, 354);
            this.buttonToRun2.Name = "buttonToRun2";
            this.buttonToRun2.Size = new System.Drawing.Size(230, 40);
            this.buttonToRun2.TabIndex = 2;
            this.buttonToRun2.Text = "Запустить";
            this.buttonToRun2.UseVisualStyleBackColor = false;
            // 
            // buttonStartOver2
            // 
            this.buttonStartOver2.BackColor = System.Drawing.Color.White;
            this.buttonStartOver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartOver2.Location = new System.Drawing.Point(46, 401);
            this.buttonStartOver2.Name = "buttonStartOver2";
            this.buttonStartOver2.Size = new System.Drawing.Size(230, 37);
            this.buttonStartOver2.TabIndex = 3;
            this.buttonStartOver2.Text = "Начать заново";
            this.buttonStartOver2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Уровень 2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 45;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox3.Location = new System.Drawing.Point(628, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 40);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DeepPink;
            this.pictureBox2.Location = new System.Drawing.Point(586, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 40);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox1.Location = new System.Drawing.Point(547, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonleft
            // 
            this.buttonleft.Image = global::SB_multithreading_.Properties.Resources.left;
            this.buttonleft.Location = new System.Drawing.Point(663, 354);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(40, 40);
            this.buttonleft.TabIndex = 7;
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonright
            // 
            this.buttonright.Image = global::SB_multithreading_.Properties.Resources.right;
            this.buttonright.Location = new System.Drawing.Point(617, 354);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(40, 40);
            this.buttonright.TabIndex = 6;
            this.buttonright.UseVisualStyleBackColor = true;
            this.buttonright.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttondown
            // 
            this.buttondown.Image = global::SB_multithreading_.Properties.Resources.down;
            this.buttondown.Location = new System.Drawing.Point(571, 354);
            this.buttondown.Name = "buttondown";
            this.buttondown.Size = new System.Drawing.Size(40, 40);
            this.buttondown.TabIndex = 5;
            this.buttondown.UseVisualStyleBackColor = true;
            this.buttondown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonup
            // 
            this.buttonup.Image = global::SB_multithreading_.Properties.Resources.up1;
            this.buttonup.Location = new System.Drawing.Point(525, 354);
            this.buttonup.Name = "buttonup";
            this.buttonup.Size = new System.Drawing.Size(40, 40);
            this.buttonup.TabIndex = 4;
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 40;
            // 
            // FormSecondLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonleft);
            this.Controls.Add(this.buttonright);
            this.Controls.Add(this.buttondown);
            this.Controls.Add(this.buttonup);
            this.Controls.Add(this.buttonStartOver2);
            this.Controls.Add(this.buttonToRun2);
            this.Controls.Add(this.dgvMove2);
            this.Controls.Add(this.dgvField2);
            this.Name = "FormSecondLevel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSecondLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvField2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvField2;
        private System.Windows.Forms.DataGridView dgvMove2;
        private System.Windows.Forms.Button buttonToRun2;
        private System.Windows.Forms.Button buttonStartOver2;
        private System.Windows.Forms.Button buttonup;
        private System.Windows.Forms.Button buttondown;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}