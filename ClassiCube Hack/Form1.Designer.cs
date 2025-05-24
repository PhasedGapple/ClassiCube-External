namespace ClassiCube_Hack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            TextBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 0, 0);
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(12, 373);
            button1.Name = "button1";
            button1.Size = new Size(235, 65);
            button1.TabIndex = 0;
            button1.Text = "Detect Client";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(430, 144);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "for ClassiCube";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(269, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 152);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(235, 65);
            button2.TabIndex = 3;
            button2.Text = "Force NoClip";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(553, 62);
            button3.Name = "button3";
            button3.Size = new Size(235, 65);
            button3.TabIndex = 4;
            button3.Text = "Teleport";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TextBox1
            // 
            TextBox1.AccessibleDescription = "";
            TextBox1.AccessibleName = "";
            TextBox1.BackColor = Color.FromArgb(44, 44, 63);
            TextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox1.ForeColor = Color.Lime;
            TextBox1.ImeMode = ImeMode.NoControl;
            TextBox1.Location = new Point(553, 13);
            TextBox1.MaxLength = 5;
            TextBox1.Name = "TextBox1";
            TextBox1.PlaceholderText = "   X";
            TextBox1.Size = new Size(75, 43);
            TextBox1.TabIndex = 5;
            TextBox1.Tag = "";
            TextBox1.TextChanged += TextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.AccessibleDescription = "";
            textBox2.AccessibleName = "";
            textBox2.BackColor = Color.FromArgb(44, 44, 63);
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Lime;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(634, 13);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "   Y";
            textBox2.Size = new Size(75, 43);
            textBox2.TabIndex = 6;
            textBox2.Tag = "";
            // 
            // textBox3
            // 
            textBox3.AccessibleDescription = "";
            textBox3.AccessibleName = "";
            textBox3.BackColor = Color.FromArgb(44, 44, 63);
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Lime;
            textBox3.ImeMode = ImeMode.NoControl;
            textBox3.Location = new Point(715, 12);
            textBox3.MaxLength = 5;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "   Z";
            textBox3.Size = new Size(75, 43);
            textBox3.TabIndex = 7;
            textBox3.Tag = "";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(12, 89);
            button4.Name = "button4";
            button4.Size = new Size(235, 65);
            button4.TabIndex = 8;
            button4.Text = "Force Hax";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox6
            // 
            textBox6.AccessibleDescription = "";
            textBox6.AccessibleName = "";
            textBox6.BackColor = Color.FromArgb(44, 44, 63);
            textBox6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.Lime;
            textBox6.ImeMode = ImeMode.NoControl;
            textBox6.Location = new Point(553, 149);
            textBox6.MaxLength = 9999999;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Spoofed Name";
            textBox6.Size = new Size(235, 43);
            textBox6.TabIndex = 11;
            textBox6.Tag = "";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(553, 198);
            button5.Name = "button5";
            button5.Size = new Size(235, 65);
            button5.TabIndex = 10;
            button5.Text = "Spoof Client (requires rejoin)";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(12, 169);
            button6.Name = "button6";
            button6.Size = new Size(235, 65);
            button6.TabIndex = 12;
            button6.Text = "Description";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(12, 250);
            button7.Name = "button7";
            button7.Size = new Size(235, 65);
            button7.TabIndex = 13;
            button7.Text = "Load Lua File";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(TextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "HackMee External";
            TopMost = true;
            TransparencyKey = SystemColors.ControlDark;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private TextBox TextBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox6;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
