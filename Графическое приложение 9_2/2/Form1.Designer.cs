
namespace _2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ch_TextBox = new System.Windows.Forms.TextBox();
            this.res_Button = new System.Windows.Forms.Button();
            this.res_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите символ:";
            // 
            // ch_TextBox
            // 
            this.ch_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch_TextBox.Location = new System.Drawing.Point(250, 47);
            this.ch_TextBox.Name = "ch_TextBox";
            this.ch_TextBox.Size = new System.Drawing.Size(167, 30);
            this.ch_TextBox.TabIndex = 1;
            // 
            // res_Button
            // 
            this.res_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_Button.Location = new System.Drawing.Point(91, 112);
            this.res_Button.Name = "res_Button";
            this.res_Button.Size = new System.Drawing.Size(272, 41);
            this.res_Button.TabIndex = 2;
            this.res_Button.Text = "Вывести строки";
            this.res_Button.UseVisualStyleBackColor = true;
            this.res_Button.Click += new System.EventHandler(this.res_Button_Click);
            // 
            // res_TextBox
            // 
            this.res_TextBox.Location = new System.Drawing.Point(27, 187);
            this.res_TextBox.Name = "res_TextBox";
            this.res_TextBox.Size = new System.Drawing.Size(390, 149);
            this.res_TextBox.TabIndex = 3;
            this.res_TextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 360);
            this.Controls.Add(this.res_TextBox);
            this.Controls.Add(this.res_Button);
            this.Controls.Add(this.ch_TextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Работа с файлами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ch_TextBox;
        private System.Windows.Forms.Button res_Button;
        private System.Windows.Forms.RichTextBox res_TextBox;
    }
}

