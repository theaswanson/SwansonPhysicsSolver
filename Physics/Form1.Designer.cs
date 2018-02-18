namespace Physics
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
            this.Motion1Button = new System.Windows.Forms.Button();
            this.Motion2Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SolveButton = new System.Windows.Forms.Button();
            this.TLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.FinalVLabel = new System.Windows.Forms.Label();
            this.InitialVLabel = new System.Windows.Forms.Label();
            this.FinalYLabel = new System.Windows.Forms.Label();
            this.InitialYLabel = new System.Windows.Forms.Label();
            this.TTextBox = new System.Windows.Forms.TextBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.FinalVTextBox = new System.Windows.Forms.TextBox();
            this.InitialVTextBox = new System.Windows.Forms.TextBox();
            this.FinalYTextBox = new System.Windows.Forms.TextBox();
            this.InitialYTextBox = new System.Windows.Forms.TextBox();
            this.FinalXTextBox = new System.Windows.Forms.TextBox();
            this.FinalXLabel = new System.Windows.Forms.Label();
            this.InitialXLabel = new System.Windows.Forms.Label();
            this.InitialXTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Motion1Button
            // 
            this.Motion1Button.Location = new System.Drawing.Point(6, 19);
            this.Motion1Button.Name = "Motion1Button";
            this.Motion1Button.Size = new System.Drawing.Size(75, 23);
            this.Motion1Button.TabIndex = 0;
            this.Motion1Button.Text = "1-D";
            this.Motion1Button.UseVisualStyleBackColor = true;
            // 
            // Motion2Button
            // 
            this.Motion2Button.Location = new System.Drawing.Point(6, 48);
            this.Motion2Button.Name = "Motion2Button";
            this.Motion2Button.Size = new System.Drawing.Size(75, 23);
            this.Motion2Button.TabIndex = 1;
            this.Motion2Button.Text = "2-D";
            this.Motion2Button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Motion2Button);
            this.groupBox1.Controls.Add(this.Motion1Button);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motion";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 466);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(127, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 466);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.SolveButton);
            this.panel1.Controls.Add(this.TLabel);
            this.panel1.Controls.Add(this.ALabel);
            this.panel1.Controls.Add(this.FinalVLabel);
            this.panel1.Controls.Add(this.InitialVLabel);
            this.panel1.Controls.Add(this.FinalYLabel);
            this.panel1.Controls.Add(this.InitialYLabel);
            this.panel1.Controls.Add(this.TTextBox);
            this.panel1.Controls.Add(this.ATextBox);
            this.panel1.Controls.Add(this.FinalVTextBox);
            this.panel1.Controls.Add(this.InitialVTextBox);
            this.panel1.Controls.Add(this.FinalYTextBox);
            this.panel1.Controls.Add(this.InitialYTextBox);
            this.panel1.Controls.Add(this.FinalXTextBox);
            this.panel1.Controls.Add(this.FinalXLabel);
            this.panel1.Controls.Add(this.InitialXLabel);
            this.panel1.Controls.Add(this.InitialXTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 283);
            this.panel1.TabIndex = 2;
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(34, 228);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(75, 23);
            this.SolveButton.TabIndex = 16;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Location = new System.Drawing.Point(31, 193);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(10, 13);
            this.TLabel.TabIndex = 15;
            this.TLabel.Text = "t";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(31, 166);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(13, 13);
            this.ALabel.TabIndex = 14;
            this.ALabel.Text = "a";
            // 
            // FinalVLabel
            // 
            this.FinalVLabel.AutoSize = true;
            this.FinalVLabel.Location = new System.Drawing.Point(31, 139);
            this.FinalVLabel.Name = "FinalVLabel";
            this.FinalVLabel.Size = new System.Drawing.Size(13, 13);
            this.FinalVLabel.TabIndex = 13;
            this.FinalVLabel.Text = "v";
            // 
            // InitialVLabel
            // 
            this.InitialVLabel.AutoSize = true;
            this.InitialVLabel.Location = new System.Drawing.Point(31, 112);
            this.InitialVLabel.Name = "InitialVLabel";
            this.InitialVLabel.Size = new System.Drawing.Size(19, 13);
            this.InitialVLabel.TabIndex = 12;
            this.InitialVLabel.Text = "v0";
            // 
            // FinalYLabel
            // 
            this.FinalYLabel.AutoSize = true;
            this.FinalYLabel.Location = new System.Drawing.Point(31, 85);
            this.FinalYLabel.Name = "FinalYLabel";
            this.FinalYLabel.Size = new System.Drawing.Size(12, 13);
            this.FinalYLabel.TabIndex = 11;
            this.FinalYLabel.Text = "y";
            // 
            // InitialYLabel
            // 
            this.InitialYLabel.AutoSize = true;
            this.InitialYLabel.Location = new System.Drawing.Point(31, 59);
            this.InitialYLabel.Name = "InitialYLabel";
            this.InitialYLabel.Size = new System.Drawing.Size(18, 13);
            this.InitialYLabel.TabIndex = 10;
            this.InitialYLabel.Text = "y0";
            // 
            // TTextBox
            // 
            this.TTextBox.Location = new System.Drawing.Point(72, 190);
            this.TTextBox.Name = "TTextBox";
            this.TTextBox.Size = new System.Drawing.Size(100, 20);
            this.TTextBox.TabIndex = 9;
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(72, 163);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 20);
            this.ATextBox.TabIndex = 8;
            // 
            // FinalVTextBox
            // 
            this.FinalVTextBox.Location = new System.Drawing.Point(72, 136);
            this.FinalVTextBox.Name = "FinalVTextBox";
            this.FinalVTextBox.Size = new System.Drawing.Size(100, 20);
            this.FinalVTextBox.TabIndex = 7;
            // 
            // InitialVTextBox
            // 
            this.InitialVTextBox.Location = new System.Drawing.Point(72, 109);
            this.InitialVTextBox.Name = "InitialVTextBox";
            this.InitialVTextBox.Size = new System.Drawing.Size(100, 20);
            this.InitialVTextBox.TabIndex = 6;
            // 
            // FinalYTextBox
            // 
            this.FinalYTextBox.Location = new System.Drawing.Point(72, 82);
            this.FinalYTextBox.Name = "FinalYTextBox";
            this.FinalYTextBox.Size = new System.Drawing.Size(100, 20);
            this.FinalYTextBox.TabIndex = 5;
            // 
            // InitialYTextBox
            // 
            this.InitialYTextBox.Location = new System.Drawing.Point(72, 56);
            this.InitialYTextBox.Name = "InitialYTextBox";
            this.InitialYTextBox.Size = new System.Drawing.Size(100, 20);
            this.InitialYTextBox.TabIndex = 4;
            // 
            // FinalXTextBox
            // 
            this.FinalXTextBox.Location = new System.Drawing.Point(72, 29);
            this.FinalXTextBox.Name = "FinalXTextBox";
            this.FinalXTextBox.Size = new System.Drawing.Size(100, 20);
            this.FinalXTextBox.TabIndex = 3;
            // 
            // FinalXLabel
            // 
            this.FinalXLabel.AutoSize = true;
            this.FinalXLabel.Location = new System.Drawing.Point(31, 32);
            this.FinalXLabel.Name = "FinalXLabel";
            this.FinalXLabel.Size = new System.Drawing.Size(12, 13);
            this.FinalXLabel.TabIndex = 2;
            this.FinalXLabel.Text = "x";
            // 
            // InitialXLabel
            // 
            this.InitialXLabel.AutoSize = true;
            this.InitialXLabel.Location = new System.Drawing.Point(31, 6);
            this.InitialXLabel.Name = "InitialXLabel";
            this.InitialXLabel.Size = new System.Drawing.Size(18, 13);
            this.InitialXLabel.TabIndex = 1;
            this.InitialXLabel.Text = "x0";
            // 
            // InitialXTextBox
            // 
            this.InitialXTextBox.Location = new System.Drawing.Point(72, 3);
            this.InitialXTextBox.Name = "InitialXTextBox";
            this.InitialXTextBox.Size = new System.Drawing.Size(100, 20);
            this.InitialXTextBox.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(34, 257);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 466);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Physics Solver";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Motion1Button;
        private System.Windows.Forms.Button Motion2Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Label TLabel;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label FinalVLabel;
        private System.Windows.Forms.Label InitialVLabel;
        private System.Windows.Forms.Label FinalYLabel;
        private System.Windows.Forms.Label InitialYLabel;
        private System.Windows.Forms.TextBox TTextBox;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox FinalVTextBox;
        private System.Windows.Forms.TextBox InitialVTextBox;
        private System.Windows.Forms.TextBox FinalYTextBox;
        private System.Windows.Forms.TextBox InitialYTextBox;
        private System.Windows.Forms.TextBox FinalXTextBox;
        private System.Windows.Forms.Label FinalXLabel;
        private System.Windows.Forms.Label InitialXLabel;
        private System.Windows.Forms.TextBox InitialXTextBox;
        private System.Windows.Forms.Button ClearButton;
    }
}

