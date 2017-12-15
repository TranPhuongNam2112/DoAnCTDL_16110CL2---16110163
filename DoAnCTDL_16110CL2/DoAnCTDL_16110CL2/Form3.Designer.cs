namespace DoAnCTDL_16110CL2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxSortTheo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxTTSort = new System.Windows.Forms.ComboBox();
            this.btnOKSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sort theo";
            // 
            // CBoxSortTheo
            // 
            this.CBoxSortTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CBoxSortTheo.FormattingEnabled = true;
            this.CBoxSortTheo.Items.AddRange(new object[] {
            "Mã SV",
            "Tên SV",
            "Giới",
            "Khoa",
            "Lớp",
            "Điểm môn 1",
            "Điểm môn 2",
            "Điểm môn 3",
            "Điểm TB"});
            this.CBoxSortTheo.Location = new System.Drawing.Point(188, 42);
            this.CBoxSortTheo.Name = "CBoxSortTheo";
            this.CBoxSortTheo.Size = new System.Drawing.Size(121, 32);
            this.CBoxSortTheo.TabIndex = 1;
            this.CBoxSortTheo.SelectedIndexChanged += new System.EventHandler(this.CBoxSortTheo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(59, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trình tự sort";
            // 
            // CBoxTTSort
            // 
            this.CBoxTTSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CBoxTTSort.FormattingEnabled = true;
            this.CBoxTTSort.Items.AddRange(new object[] {
            "a->z",
            "z->a",
            "max->min",
            "min->max"});
            this.CBoxTTSort.Location = new System.Drawing.Point(188, 123);
            this.CBoxTTSort.Name = "CBoxTTSort";
            this.CBoxTTSort.Size = new System.Drawing.Size(121, 32);
            this.CBoxTTSort.TabIndex = 3;
            // 
            // btnOKSort
            // 
            this.btnOKSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOKSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOKSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOKSort.Location = new System.Drawing.Point(157, 195);
            this.btnOKSort.Name = "btnOKSort";
            this.btnOKSort.Size = new System.Drawing.Size(84, 31);
            this.btnOKSort.TabIndex = 4;
            this.btnOKSort.Text = "OK";
            this.btnOKSort.UseVisualStyleBackColor = false;
            this.btnOKSort.Click += new System.EventHandler(this.btnOKSort_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 261);
            this.Controls.Add(this.btnOKSort);
            this.Controls.Add(this.CBoxTTSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSortTheo);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxSortTheo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxTTSort;
        private System.Windows.Forms.Button btnOKSort;
    }
}