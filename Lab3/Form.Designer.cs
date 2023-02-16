namespace Lab3
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxText = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxText
            // 
            this.listBoxText.FormattingEnabled = true;
            this.listBoxText.ItemHeight = 16;
            this.listBoxText.Location = new System.Drawing.Point(12, 12);
            this.listBoxText.Name = "listBoxText";
            this.listBoxText.Size = new System.Drawing.Size(776, 244);
            this.listBoxText.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(308, 319);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(199, 76);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Проверка соединения";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.listBoxText);
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxText;
        private System.Windows.Forms.Button btnRun;
    }
}

