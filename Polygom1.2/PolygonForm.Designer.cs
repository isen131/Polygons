namespace Polygom1._2
{
    partial class PolygonForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.TextBox();
            this.PointBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(89, 72);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(192, 20);
            this.Y.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите координаты вершин многоугольника через запятую";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(134, 158);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(91, 31);
            this.OK.TabIndex = 12;
            this.OK.Text = "Готово";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(89, 46);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(192, 20);
            this.X.TabIndex = 11;
            // 
            // PointBox
            // 
            this.PointBox.Location = new System.Drawing.Point(89, 128);
            this.PointBox.Name = "PointBox";
            this.PointBox.Size = new System.Drawing.Size(192, 20);
            this.PointBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Координаты точки (через запятую)";
            // 
            // PolygonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 201);
            this.Controls.Add(this.PointBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.X);
            this.Name = "PolygonForm";
            this.Text = "PolygonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox PointBox;
        private System.Windows.Forms.Label label3;
    }
}