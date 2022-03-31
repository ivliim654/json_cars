namespace JSON_cars
{
    partial class Form1
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
            this.first = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.Last_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.HP_textBox = new System.Windows.Forms.TextBox();
            this.MPG_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ADD_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(12, 276);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(75, 23);
            this.first.TabIndex = 0;
            this.first.Text = "first";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.button1_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(188, 276);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "--->";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Last_button
            // 
            this.Last_button.Location = new System.Drawing.Point(269, 276);
            this.Last_button.Name = "Last_button";
            this.Last_button.Size = new System.Drawing.Size(75, 23);
            this.Last_button.TabIndex = 3;
            this.Last_button.Text = "Last";
            this.Last_button.UseVisualStyleBackColor = true;
            this.Last_button.Click += new System.EventHandler(this.Last_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(93, 276);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "<---";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(136, 52);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Name_textBox.TabIndex = 5;
            // 
            // HP_textBox
            // 
            this.HP_textBox.Location = new System.Drawing.Point(136, 135);
            this.HP_textBox.Name = "HP_textBox";
            this.HP_textBox.Size = new System.Drawing.Size(100, 20);
            this.HP_textBox.TabIndex = 6;
            // 
            // MPG_textBox
            // 
            this.MPG_textBox.Location = new System.Drawing.Point(136, 93);
            this.MPG_textBox.Name = "MPG_textBox";
            this.MPG_textBox.Size = new System.Drawing.Size(100, 20);
            this.MPG_textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MPG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "HP:";
            // 
            // ADD_button
            // 
            this.ADD_button.Location = new System.Drawing.Point(12, 331);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(75, 23);
            this.ADD_button.TabIndex = 11;
            this.ADD_button.Text = "add";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Visible = false;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(98, 331);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 12;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 480);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MPG_textBox);
            this.Controls.Add(this.HP_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Last_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button Last_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox HP_textBox;
        private System.Windows.Forms.TextBox MPG_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.Button Save_button;
    }
}

