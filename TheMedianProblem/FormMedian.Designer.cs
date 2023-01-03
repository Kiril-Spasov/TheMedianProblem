namespace TheMedianProblem
{
    partial class FormMedian
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
            this.label2 = new System.Windows.Forms.Label();
            this.LstOriginal = new System.Windows.Forms.ListBox();
            this.LstSorted = new System.Windows.Forms.ListBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(381, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sorted List";
            // 
            // LstOriginal
            // 
            this.LstOriginal.FormattingEnabled = true;
            this.LstOriginal.ItemHeight = 16;
            this.LstOriginal.Location = new System.Drawing.Point(67, 87);
            this.LstOriginal.Name = "LstOriginal";
            this.LstOriginal.Size = new System.Drawing.Size(256, 244);
            this.LstOriginal.TabIndex = 2;
            // 
            // LstSorted
            // 
            this.LstSorted.FormattingEnabled = true;
            this.LstSorted.ItemHeight = 16;
            this.LstSorted.Location = new System.Drawing.Point(385, 87);
            this.LstSorted.Name = "LstSorted";
            this.LstSorted.Size = new System.Drawing.Size(256, 244);
            this.LstSorted.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(496, 358);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(145, 50);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(67, 358);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(145, 50);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // FormMedian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LstSorted);
            this.Controls.Add(this.LstOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMedian";
            this.Text = "The Median";
            this.Load += new System.EventHandler(this.FormMedian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstOriginal;
        private System.Windows.Forms.ListBox LstSorted;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

