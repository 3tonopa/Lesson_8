
namespace Lesson_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.CheckBTrue = new System.Windows.Forms.CheckBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.TextBoxQuestions = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(897, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem1,
            this.OpenMenuItem2,
            this.SaveMenuItem3,
            this.toolStripSeparator1,
            this.ExitMenuItem5});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // NewMenuItem1
            // 
            this.NewMenuItem1.Name = "NewMenuItem1";
            this.NewMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.NewMenuItem1.Text = "New";
            this.NewMenuItem1.Click += new System.EventHandler(this.NewMenuItem1_Click);
            // 
            // OpenMenuItem2
            // 
            this.OpenMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenMenuItem2.Name = "OpenMenuItem2";
            this.OpenMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.OpenMenuItem2.Text = "Open";
            this.OpenMenuItem2.Click += new System.EventHandler(this.OpenMenuItem2_Click);
            // 
            // SaveMenuItem3
            // 
            this.SaveMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveMenuItem3.Name = "SaveMenuItem3";
            this.SaveMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.SaveMenuItem3.Text = "Save";
            this.SaveMenuItem3.Click += new System.EventHandler(this.SaveMenuItem3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // ExitMenuItem5
            // 
            this.ExitMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitMenuItem5.Name = "ExitMenuItem5";
            this.ExitMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.ExitMenuItem5.Text = "Exit";
            this.ExitMenuItem5.Click += new System.EventHandler(this.ExitMenuItem5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.UpDownNumber);
            this.panel1.Controls.Add(this.CheckBTrue);
            this.panel1.Controls.Add(this.Updatebutton);
            this.panel1.Controls.Add(this.Deletebutton);
            this.panel1.Controls.Add(this.Addbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 100);
            this.panel1.TabIndex = 2;
            // 
            // UpDownNumber
            // 
            this.UpDownNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpDownNumber.Location = new System.Drawing.Point(667, 36);
            this.UpDownNumber.Name = "UpDownNumber";
            this.UpDownNumber.Size = new System.Drawing.Size(120, 22);
            this.UpDownNumber.TabIndex = 4;
            this.UpDownNumber.ValueChanged += new System.EventHandler(this.UpDownNumber_ValueChanged);
            // 
            // CheckBTrue
            // 
            this.CheckBTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBTrue.AutoSize = true;
            this.CheckBTrue.Location = new System.Drawing.Point(809, 36);
            this.CheckBTrue.Name = "CheckBTrue";
            this.CheckBTrue.Size = new System.Drawing.Size(60, 21);
            this.CheckBTrue.TabIndex = 3;
            this.CheckBTrue.Text = "True";
            this.CheckBTrue.UseVisualStyleBackColor = true;
            this.CheckBTrue.CheckedChanged += new System.EventHandler(this.CheckBTrue_CheckedChanged);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(200, 36);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 2;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(104, 36);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 1;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(12, 36);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // TextBoxQuestions
            // 
            this.TextBoxQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxQuestions.Location = new System.Drawing.Point(0, 27);
            this.TextBoxQuestions.Multiline = true;
            this.TextBoxQuestions.Name = "TextBoxQuestions";
            this.TextBoxQuestions.Size = new System.Drawing.Size(897, 327);
            this.TextBoxQuestions.TabIndex = 3;
            this.TextBoxQuestions.TextChanged += new System.EventHandler(this.TextBoxQuestions_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 454);
            this.Controls.Add(this.TextBoxQuestions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Believe Or Not Believe";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown UpDownNumber;
        private System.Windows.Forms.CheckBox CheckBTrue;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox TextBoxQuestions;
    }
}

