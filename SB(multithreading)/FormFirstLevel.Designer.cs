
namespace SB_multithreading_
{
    partial class FormFirstLevel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewField1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonToRun1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewMove1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonup = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonright = new System.Windows.Forms.Button();
            this.buttondown = new System.Windows.Forms.Button();
            this.pictureBoxYel = new System.Windows.Forms.PictureBox();
            this.pictureBoxViol = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewField1
            // 
            this.dataGridViewField1.AllowUserToAddRows = false;
            this.dataGridViewField1.AllowUserToDeleteRows = false;
            this.dataGridViewField1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewField1.ColumnHeadersVisible = false;
            this.dataGridViewField1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewField1.Location = new System.Drawing.Point(51, 127);
            this.dataGridViewField1.Name = "dataGridViewField1";
            this.dataGridViewField1.ReadOnly = true;
            this.dataGridViewField1.RowHeadersVisible = false;
            this.dataGridViewField1.RowTemplate.Height = 50;
            this.dataGridViewField1.Size = new System.Drawing.Size(205, 205);
            this.dataGridViewField1.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // buttonToRun1
            // 
            this.buttonToRun1.BackColor = System.Drawing.Color.White;
            this.buttonToRun1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRun1.Location = new System.Drawing.Point(51, 350);
            this.buttonToRun1.Name = "buttonToRun1";
            this.buttonToRun1.Size = new System.Drawing.Size(205, 33);
            this.buttonToRun1.TabIndex = 1;
            this.buttonToRun1.Text = "Запустить";
            this.buttonToRun1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(51, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Начать заново";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewMove1
            // 
            this.dataGridViewMove1.AllowUserToAddRows = false;
            this.dataGridViewMove1.AllowUserToDeleteRows = false;
            this.dataGridViewMove1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMove1.ColumnHeadersVisible = false;
            this.dataGridViewMove1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewMove1.Location = new System.Drawing.Point(568, 156);
            this.dataGridViewMove1.Name = "dataGridViewMove1";
            this.dataGridViewMove1.ReadOnly = true;
            this.dataGridViewMove1.RowHeadersVisible = false;
            this.dataGridViewMove1.RowTemplate.Height = 45;
            this.dataGridViewMove1.Size = new System.Drawing.Size(95, 185);
            this.dataGridViewMove1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(352, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Уровень 1";
            // 
            // buttonup
            // 
            this.buttonup.Image = global::SB_multithreading_.Properties.Resources.up1;
            this.buttonup.Location = new System.Drawing.Point(541, 360);
            this.buttonup.Name = "buttonup";
            this.buttonup.Size = new System.Drawing.Size(40, 40);
            this.buttonup.TabIndex = 11;
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonleft
            // 
            this.buttonleft.Image = global::SB_multithreading_.Properties.Resources.left;
            this.buttonleft.Location = new System.Drawing.Point(679, 360);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(40, 40);
            this.buttonleft.TabIndex = 10;
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonright
            // 
            this.buttonright.Image = global::SB_multithreading_.Properties.Resources.right;
            this.buttonright.Location = new System.Drawing.Point(633, 360);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(40, 40);
            this.buttonright.TabIndex = 9;
            this.buttonright.UseVisualStyleBackColor = true;
            this.buttonright.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttondown
            // 
            this.buttondown.Image = global::SB_multithreading_.Properties.Resources.down;
            this.buttondown.Location = new System.Drawing.Point(587, 360);
            this.buttondown.Name = "buttondown";
            this.buttondown.Size = new System.Drawing.Size(40, 40);
            this.buttondown.TabIndex = 8;
            this.buttondown.UseVisualStyleBackColor = true;
            this.buttondown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxYel
            // 
            this.pictureBoxYel.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYel.Location = new System.Drawing.Point(568, 113);
            this.pictureBoxYel.Name = "pictureBoxYel";
            this.pictureBoxYel.Size = new System.Drawing.Size(47, 47);
            this.pictureBoxYel.TabIndex = 5;
            this.pictureBoxYel.TabStop = false;
            // 
            // pictureBoxViol
            // 
            this.pictureBoxViol.BackColor = System.Drawing.Color.Violet;
            this.pictureBoxViol.Location = new System.Drawing.Point(614, 113);
            this.pictureBoxViol.Name = "pictureBoxViol";
            this.pictureBoxViol.Size = new System.Drawing.Size(49, 47);
            this.pictureBoxViol.TabIndex = 4;
            this.pictureBoxViol.TabStop = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 45;
            // 
            // FormFirstLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonup);
            this.Controls.Add(this.buttonleft);
            this.Controls.Add(this.buttonright);
            this.Controls.Add(this.buttondown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxYel);
            this.Controls.Add(this.pictureBoxViol);
            this.Controls.Add(this.dataGridViewMove1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonToRun1);
            this.Controls.Add(this.dataGridViewField1);
            this.Name = "FormFirstLevel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFirstLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewField1;
        private System.Windows.Forms.Button buttonToRun1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewMove1;
        private System.Windows.Forms.PictureBox pictureBoxViol;
        private System.Windows.Forms.PictureBox pictureBoxYel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttondown;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button buttonup;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}