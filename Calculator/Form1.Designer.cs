namespace Calculator
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
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.UserResultLabel = new System.Windows.Forms.Label();
            this.Buttons_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.DivideButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.Buttons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputBox.Location = new System.Drawing.Point(5, 2);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(630, 20);
            this.UserInputBox.TabIndex = 0;
            // 
            // UserResultLabel
            // 
            this.UserResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserResultLabel.Location = new System.Drawing.Point(4, 31);
            this.UserResultLabel.Name = "UserResultLabel";
            this.UserResultLabel.Size = new System.Drawing.Size(614, 77);
            this.UserResultLabel.TabIndex = 1;
            this.UserResultLabel.Text = "Enter an Equation ";
            this.UserResultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Buttons_Panel
            // 
            this.Buttons_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buttons_Panel.ColumnCount = 4;
            this.Buttons_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Buttons_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Buttons_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Buttons_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Buttons_Panel.Controls.Add(this.DivideButton, 3, 4);
            this.Buttons_Panel.Controls.Add(this.EqualButton, 2, 4);
            this.Buttons_Panel.Controls.Add(this.ZeroButton, 1, 4);
            this.Buttons_Panel.Controls.Add(this.MultiplyButton, 3, 3);
            this.Buttons_Panel.Controls.Add(this.ThreeButton, 2, 3);
            this.Buttons_Panel.Controls.Add(this.TwoButton, 1, 3);
            this.Buttons_Panel.Controls.Add(this.OneButton, 0, 3);
            this.Buttons_Panel.Controls.Add(this.MinusButton, 3, 2);
            this.Buttons_Panel.Controls.Add(this.SixButton, 2, 2);
            this.Buttons_Panel.Controls.Add(this.FiveButton, 1, 2);
            this.Buttons_Panel.Controls.Add(this.FourButton, 0, 2);
            this.Buttons_Panel.Controls.Add(this.AddButton, 3, 1);
            this.Buttons_Panel.Controls.Add(this.NineButton, 2, 1);
            this.Buttons_Panel.Controls.Add(this.EightButton, 1, 1);
            this.Buttons_Panel.Controls.Add(this.SevenButton, 0, 1);
            this.Buttons_Panel.Controls.Add(this.ModButton, 3, 0);
            this.Buttons_Panel.Controls.Add(this.DeleteButton, 2, 0);
            this.Buttons_Panel.Controls.Add(this.CEButton, 0, 0);
            this.Buttons_Panel.Controls.Add(this.DotButton, 0, 4);
            this.Buttons_Panel.Location = new System.Drawing.Point(5, 73);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.RowCount = 5;
            this.Buttons_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_Panel.Size = new System.Drawing.Size(630, 318);
            this.Buttons_Panel.TabIndex = 2;
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(474, 255);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(153, 60);
            this.DivideButton.TabIndex = 19;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(317, 255);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(151, 60);
            this.EqualButton.TabIndex = 18;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(160, 255);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(151, 60);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(474, 192);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(153, 57);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(317, 192);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(151, 57);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(160, 192);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(151, 57);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(3, 192);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(151, 57);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(474, 129);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(153, 57);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(317, 129);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(151, 57);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(160, 129);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(151, 57);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(3, 129);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(151, 57);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(474, 66);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(153, 57);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(317, 66);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(151, 57);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(160, 66);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(151, 57);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(3, 66);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(151, 57);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModButton.Location = new System.Drawing.Point(474, 3);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(153, 57);
            this.ModButton.TabIndex = 3;
            this.ModButton.Text = "%";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(317, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(151, 57);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Del";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(151, 57);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(3, 255);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(151, 60);
            this.DotButton.TabIndex = 20;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.Buttons_Panel);
            this.Controls.Add(this.UserResultLabel);
            this.Controls.Add(this.UserInputBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Buttons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.Label UserResultLabel;
        private System.Windows.Forms.TableLayoutPanel Buttons_Panel;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button DotButton;
    }
}

