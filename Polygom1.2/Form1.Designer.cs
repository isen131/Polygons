namespace Polygom1._2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.TextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CircleButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(279, 238);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(88, 20);
            this.Result.TabIndex = 2;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(280, 13);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(88, 31);
            this.ClearAllButton.TabIndex = 3;
            this.ClearAllButton.Text = "Сброс";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывод";
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(471, 13);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(89, 31);
            this.CircleButton.TabIndex = 11;
            this.CircleButton.Text = "Окружность";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.Circle_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.Location = new System.Drawing.Point(85, 12);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(93, 30);
            this.PolygonButton.TabIndex = 12;
            this.PolygonButton.Text = "Многоугольник";
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 492);
            this.Controls.Add(this.PolygonButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Polygons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button PolygonButton;
        public System.Windows.Forms.TextBox Result;
    }
}

