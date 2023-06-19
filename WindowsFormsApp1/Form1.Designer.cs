namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.MessagesLB = new System.Windows.Forms.ListBox();
            this.MessangTextBox = new System.Windows.Forms.TextBox();
            this.UsrNameTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MessagesLB
            // 
            this.MessagesLB.FormattingEnabled = true;
            this.MessagesLB.ItemHeight = 16;
            this.MessagesLB.Location = new System.Drawing.Point(10, 12);
            this.MessagesLB.Name = "MessagesLB";
            this.MessagesLB.Size = new System.Drawing.Size(681, 372);
            this.MessagesLB.TabIndex = 1;
            // 
            // MessangTextBox
            // 
            this.MessangTextBox.Location = new System.Drawing.Point(12, 416);
            this.MessangTextBox.Name = "MessangTextBox";
            this.MessangTextBox.Size = new System.Drawing.Size(681, 22);
            this.MessangTextBox.TabIndex = 2;
            // 
            // UsrNameTextBox
            // 
            this.UsrNameTextBox.Location = new System.Drawing.Point(12, 388);
            this.UsrNameTextBox.Name = "UsrNameTextBox";
            this.UsrNameTextBox.Size = new System.Drawing.Size(681, 22);
            this.UsrNameTextBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsrNameTextBox);
            this.Controls.Add(this.MessangTextBox);
            this.Controls.Add(this.MessagesLB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox MessagesLB;
        private System.Windows.Forms.TextBox MessangTextBox;
        private System.Windows.Forms.TextBox UsrNameTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

