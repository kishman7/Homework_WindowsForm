
namespace My_Classwork_WindowsForm
{
    partial class FormUkraine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUkraine));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpacityPlus = new System.Windows.Forms.Button();
            this.OpacityMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(66, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(348, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(128, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OpacityPlus
            // 
            this.OpacityPlus.BackColor = System.Drawing.Color.Yellow;
            this.OpacityPlus.Location = new System.Drawing.Point(200, 25);
            this.OpacityPlus.Name = "OpacityPlus";
            this.OpacityPlus.Size = new System.Drawing.Size(75, 23);
            this.OpacityPlus.TabIndex = 3;
            this.OpacityPlus.Text = "Opacity +";
            this.OpacityPlus.UseVisualStyleBackColor = false;
            this.OpacityPlus.Click += new System.EventHandler(this.OpacityPlus_Click);
            // 
            // OpacityMinus
            // 
            this.OpacityMinus.BackColor = System.Drawing.Color.Yellow;
            this.OpacityMinus.Location = new System.Drawing.Point(200, 97);
            this.OpacityMinus.Name = "OpacityMinus";
            this.OpacityMinus.Size = new System.Drawing.Size(75, 23);
            this.OpacityMinus.TabIndex = 4;
            this.OpacityMinus.Text = "Opacity -";
            this.OpacityMinus.UseVisualStyleBackColor = false;
            this.OpacityMinus.Click += new System.EventHandler(this.OpacityMinus_Click);
            // 
            // FormUkraine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 384);
            this.Controls.Add(this.OpacityMinus);
            this.Controls.Add(this.OpacityPlus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUkraine";
            this.Text = "FormUkraine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpacityPlus;
        private System.Windows.Forms.Button OpacityMinus;
    }
}

