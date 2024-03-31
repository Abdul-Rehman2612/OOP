namespace TASK1
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NInput = new System.Windows.Forms.TextBox();
            this.AInput = new System.Windows.Forms.TextBox();
            this.MInput = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(251, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(298, 33);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Student Registration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(359, 348);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(12, 81);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(82, 29);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "FscMarks";
            // 
            // NInput
            // 
            this.NInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NInput.Location = new System.Drawing.Point(159, 81);
            this.NInput.Name = "NInput";
            this.NInput.Size = new System.Drawing.Size(100, 29);
            this.NInput.TabIndex = 6;
            this.NInput.TextChanged += new System.EventHandler(this.NInput_TextChanged);
            // 
            // AInput
            // 
            this.AInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AInput.Location = new System.Drawing.Point(159, 133);
            this.AInput.Name = "AInput";
            this.AInput.Size = new System.Drawing.Size(100, 29);
            this.AInput.TabIndex = 7;
            // 
            // MInput
            // 
            this.MInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MInput.Location = new System.Drawing.Point(159, 186);
            this.MInput.Name = "MInput";
            this.MInput.Size = new System.Drawing.Size(100, 29);
            this.MInput.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(19, 290);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 35);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(159, 290);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 35);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(298, 290);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 35);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.MInput);
            this.Controls.Add(this.AInput);
            this.Controls.Add(this.NInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
           // this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NInput;
        private System.Windows.Forms.TextBox AInput;
        private System.Windows.Forms.TextBox MInput;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
    }
}

