namespace WindowsFormsApp8
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.чёрнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чёрная = new System.Windows.Forms.ToolStripMenuItem();
            this.розовая = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартная = new System.Windows.Forms.ToolStripMenuItem();
            this.оранжевая = new System.Windows.Forms.ToolStripMenuItem();
            this.англToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.black = new System.Windows.Forms.ToolStripMenuItem();
            this.pink = new System.Windows.Forms.ToolStripMenuItem();
            this.orange = new System.Windows.Forms.ToolStripMenuItem();
            this.standart = new System.Windows.Forms.ToolStripMenuItem();
            this.langseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Размер = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(85, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чёрнаяToolStripMenuItem,
            this.стандартнаяToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(122, 20);
            this.ToolStripMenuItem1.Text = "tooStripMenuItem1";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.langseToolStripMenuItem});
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(122, 20);
            this.ToolStripMenuItem2.Text = "tooStripMenuItem2";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.розоваяToolStripMenuItem_Click);
            // 
            // чёрнаяToolStripMenuItem
            // 
            this.чёрнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чёрная,
            this.розовая,
            this.стандартная,
            this.оранжевая});
            this.чёрнаяToolStripMenuItem.Name = "чёрнаяToolStripMenuItem";
            this.чёрнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.чёрнаяToolStripMenuItem.Text = "Тема";
            // 
            // стандартнаяToolStripMenuItem
            // 
            this.стандартнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.англToolStripMenuItem,
            this.русToolStripMenuItem});
            this.стандартнаяToolStripMenuItem.Name = "стандартнаяToolStripMenuItem";
            this.стандартнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.стандартнаяToolStripMenuItem.Text = "Язык";
            // 
            // чёрная
            // 
            this.чёрная.Name = "чёрная";
            this.чёрная.Size = new System.Drawing.Size(180, 22);
            this.чёрная.Text = "Чёрная";
            this.чёрная.Click += new System.EventHandler(this.чёрная_Click);
            // 
            // розовая
            // 
            this.розовая.Name = "розовая";
            this.розовая.Size = new System.Drawing.Size(180, 22);
            this.розовая.Text = "Розовая";
            this.розовая.Click += new System.EventHandler(this.розовая_Click);
            // 
            // стандартная
            // 
            this.стандартная.Name = "стандартная";
            this.стандартная.Size = new System.Drawing.Size(180, 22);
            this.стандартная.Text = "Стандартная";
            this.стандартная.Click += new System.EventHandler(this.стандартная_Click);
            // 
            // оранжевая
            // 
            this.оранжевая.Name = "оранжевая";
            this.оранжевая.Size = new System.Drawing.Size(180, 22);
            this.оранжевая.Text = "Оранжевая";
            this.оранжевая.Click += new System.EventHandler(this.оранжевая_Click);
            // 
            // англToolStripMenuItem
            // 
            this.англToolStripMenuItem.Name = "англToolStripMenuItem";
            this.англToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.англToolStripMenuItem.Text = "Англ";
            this.англToolStripMenuItem.Click += new System.EventHandler(this.англToolStripMenuItem_Click);
            // 
            // русToolStripMenuItem
            // 
            this.русToolStripMenuItem.Name = "русToolStripMenuItem";
            this.русToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.русToolStripMenuItem.Text = "Рус";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.black,
            this.pink,
            this.orange,
            this.standart});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "theme";
            // 
            // black
            // 
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(180, 22);
            this.black.Text = "Black";
            this.black.Click += new System.EventHandler(this.чёрная_Click);
            // 
            // pink
            // 
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(180, 22);
            this.pink.Text = "Pink";
            this.pink.Click += new System.EventHandler(this.розовая_Click);
            // 
            // orange
            // 
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(180, 22);
            this.orange.Text = "Orange";
            this.orange.Click += new System.EventHandler(this.оранжевая_Click);
            // 
            // standart
            // 
            this.standart.Name = "standart";
            this.standart.Size = new System.Drawing.Size(180, 22);
            this.standart.Text = "standart";
            this.standart.Click += new System.EventHandler(this.стандартная_Click);
            // 
            // langseToolStripMenuItem
            // 
            this.langseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rusToolStripMenuItem,
            this.engToolStripMenuItem});
            this.langseToolStripMenuItem.Name = "langseToolStripMenuItem";
            this.langseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.langseToolStripMenuItem.Text = "langse";
            // 
            // rusToolStripMenuItem
            // 
            this.rusToolStripMenuItem.Name = "rusToolStripMenuItem";
            this.rusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rusToolStripMenuItem.Text = "Rus";
            this.rusToolStripMenuItem.Click += new System.EventHandler(this.rusToolStripMenuItem_Click);
            // 
            // engToolStripMenuItem
            // 
            this.engToolStripMenuItem.Name = "engToolStripMenuItem";
            this.engToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.engToolStripMenuItem.Text = "Eng";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(134, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 175);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Text";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(385, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(567, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 20);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(595, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 20);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(623, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 20);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(639, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Размер
            // 
            this.Размер.Location = new System.Drawing.Point(664, 292);
            this.Размер.Name = "Размер";
            this.Размер.Size = new System.Drawing.Size(75, 23);
            this.Размер.TabIndex = 10;
            this.Размер.Text = "Размер";
            this.Размер.UseVisualStyleBackColor = true;
            this.Размер.Click += new System.EventHandler(this.Размер_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Размер);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem чёрнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem чёрная;
        private System.Windows.Forms.ToolStripMenuItem розовая;
        private System.Windows.Forms.ToolStripMenuItem стандартная;
        private System.Windows.Forms.ToolStripMenuItem оранжевая;
        private System.Windows.Forms.ToolStripMenuItem англToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem black;
        private System.Windows.Forms.ToolStripMenuItem pink;
        private System.Windows.Forms.ToolStripMenuItem orange;
        private System.Windows.Forms.ToolStripMenuItem standart;
        private System.Windows.Forms.ToolStripMenuItem langseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Размер;
    }
}

