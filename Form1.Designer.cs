namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            ClearButton = new Button();
            BackspaceButton = new Button();
            Modulusbutton = new Button();
            DivideButton = new Button();
            MultiplyButton = new Button();
            SevenButton = new Button();
            EightButton = new Button();
            NineButton = new Button();
            Fourbutton = new Button();
            Fivebutton = new Button();
            SixButton = new Button();
            MinusButton = new Button();
            OneButton = new Button();
            TwoButton = new Button();
            ThreeButton = new Button();
            PlusButton = new Button();
            JiggyButton = new Button();
            ZeroButton = new Button();
            DecimalButton = new Button();
            EqualButton = new Button();
            TextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 21);
            label1.Name = "label1";
            label1.Size = new Size(192, 52);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.Click += label1_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ActiveCaption;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(40, 250);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 50);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // BackspaceButton
            // 
            BackspaceButton.BackColor = SystemColors.ActiveCaption;
            BackspaceButton.Cursor = Cursors.Hand;
            BackspaceButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackspaceButton.Location = new Point(218, 250);
            BackspaceButton.Name = "BackspaceButton";
            BackspaceButton.Size = new Size(117, 50);
            BackspaceButton.TabIndex = 2;
            BackspaceButton.Text = "Backspace";
            BackspaceButton.UseVisualStyleBackColor = false;
            BackspaceButton.Click += BackspaceButton_Click;
            // 
            // Modulusbutton
            // 
            Modulusbutton.BackColor = SystemColors.ActiveCaption;
            Modulusbutton.Cursor = Cursors.Hand;
            Modulusbutton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Modulusbutton.Location = new Point(396, 250);
            Modulusbutton.Name = "Modulusbutton";
            Modulusbutton.Size = new Size(117, 50);
            Modulusbutton.TabIndex = 3;
            Modulusbutton.Text = "%";
            Modulusbutton.UseVisualStyleBackColor = false;
            Modulusbutton.Click += Modulusbutton_Click;
            // 
            // DivideButton
            // 
            DivideButton.BackColor = SystemColors.ActiveCaption;
            DivideButton.Cursor = Cursors.Hand;
            DivideButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DivideButton.Location = new Point(580, 250);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(117, 50);
            DivideButton.TabIndex = 4;
            DivideButton.Text = "÷";
            DivideButton.UseVisualStyleBackColor = false;
            DivideButton.Click += DivideButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.BackColor = SystemColors.ActiveCaption;
            MultiplyButton.Cursor = Cursors.Hand;
            MultiplyButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MultiplyButton.Location = new Point(580, 331);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(117, 50);
            MultiplyButton.TabIndex = 5;
            MultiplyButton.Text = "*";
            MultiplyButton.UseVisualStyleBackColor = false;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // SevenButton
            // 
            SevenButton.BackColor = SystemColors.ActiveCaption;
            SevenButton.Cursor = Cursors.Hand;
            SevenButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SevenButton.Location = new Point(40, 331);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(117, 50);
            SevenButton.TabIndex = 6;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = false;
            SevenButton.Click += SevenButton_Click;
            // 
            // EightButton
            // 
            EightButton.BackColor = SystemColors.ActiveCaption;
            EightButton.Cursor = Cursors.Hand;
            EightButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EightButton.Location = new Point(218, 331);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(117, 50);
            EightButton.TabIndex = 7;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = false;
            EightButton.Click += EightButton_Click;
            // 
            // NineButton
            // 
            NineButton.BackColor = SystemColors.ActiveCaption;
            NineButton.Cursor = Cursors.Hand;
            NineButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NineButton.Location = new Point(396, 331);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(117, 50);
            NineButton.TabIndex = 8;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = false;
            NineButton.Click += NineButton_Click;
            // 
            // Fourbutton
            // 
            Fourbutton.BackColor = SystemColors.ActiveCaption;
            Fourbutton.Cursor = Cursors.Hand;
            Fourbutton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fourbutton.Location = new Point(40, 426);
            Fourbutton.Name = "Fourbutton";
            Fourbutton.Size = new Size(117, 50);
            Fourbutton.TabIndex = 9;
            Fourbutton.Text = "4";
            Fourbutton.UseVisualStyleBackColor = false;
            Fourbutton.Click += Fourbutton_Click;
            // 
            // Fivebutton
            // 
            Fivebutton.BackColor = SystemColors.ActiveCaption;
            Fivebutton.Cursor = Cursors.Hand;
            Fivebutton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fivebutton.Location = new Point(218, 426);
            Fivebutton.Name = "Fivebutton";
            Fivebutton.Size = new Size(117, 50);
            Fivebutton.TabIndex = 10;
            Fivebutton.Text = "5";
            Fivebutton.UseVisualStyleBackColor = false;
            Fivebutton.Click += Fivebutton_Click;
            // 
            // SixButton
            // 
            SixButton.BackColor = SystemColors.ActiveCaption;
            SixButton.Cursor = Cursors.Hand;
            SixButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SixButton.Location = new Point(396, 426);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(117, 50);
            SixButton.TabIndex = 11;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = false;
            SixButton.Click += SixButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.BackColor = SystemColors.ActiveCaption;
            MinusButton.Cursor = Cursors.Hand;
            MinusButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinusButton.Location = new Point(580, 426);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(117, 50);
            MinusButton.TabIndex = 12;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = false;
            MinusButton.Click += MinusButton_Click;
            // 
            // OneButton
            // 
            OneButton.BackColor = SystemColors.ActiveCaption;
            OneButton.Cursor = Cursors.Hand;
            OneButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OneButton.Location = new Point(40, 530);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(117, 50);
            OneButton.TabIndex = 13;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = false;
            OneButton.Click += OneButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.BackColor = SystemColors.ActiveCaption;
            TwoButton.Cursor = Cursors.Hand;
            TwoButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TwoButton.Location = new Point(218, 530);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(117, 50);
            TwoButton.TabIndex = 14;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = false;
            TwoButton.Click += TwoButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.BackColor = SystemColors.ActiveCaption;
            ThreeButton.Cursor = Cursors.Hand;
            ThreeButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThreeButton.Location = new Point(396, 530);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(117, 50);
            ThreeButton.TabIndex = 15;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = false;
            ThreeButton.Click += ThreeButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.BackColor = SystemColors.ActiveCaption;
            PlusButton.Cursor = Cursors.Hand;
            PlusButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusButton.Location = new Point(580, 530);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(117, 50);
            PlusButton.TabIndex = 16;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = false;
            PlusButton.Click += PlusButton_Click;
            // 
            // JiggyButton
            // 
            JiggyButton.BackColor = SystemColors.ActiveCaption;
            JiggyButton.Cursor = Cursors.Hand;
            JiggyButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JiggyButton.Location = new Point(40, 620);
            JiggyButton.Name = "JiggyButton";
            JiggyButton.Size = new Size(117, 50);
            JiggyButton.TabIndex = 17;
            JiggyButton.Text = "Jigggy";
            JiggyButton.UseVisualStyleBackColor = false;
            JiggyButton.Click += button16_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.BackColor = SystemColors.ActiveCaption;
            ZeroButton.Cursor = Cursors.Hand;
            ZeroButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZeroButton.Location = new Point(218, 620);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(117, 50);
            ZeroButton.TabIndex = 18;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = false;
            ZeroButton.Click += ZeroButton_Click;
            // 
            // DecimalButton
            // 
            DecimalButton.BackColor = SystemColors.ActiveCaption;
            DecimalButton.Cursor = Cursors.Hand;
            DecimalButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DecimalButton.Location = new Point(396, 620);
            DecimalButton.Name = "DecimalButton";
            DecimalButton.Size = new Size(117, 50);
            DecimalButton.TabIndex = 19;
            DecimalButton.Text = ".";
            DecimalButton.UseVisualStyleBackColor = false;
            DecimalButton.Click += DecimalButton_Click;
            // 
            // EqualButton
            // 
            EqualButton.BackColor = SystemColors.ActiveCaption;
            EqualButton.Cursor = Cursors.Hand;
            EqualButton.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EqualButton.Location = new Point(580, 620);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(117, 50);
            EqualButton.TabIndex = 20;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = false;
            EqualButton.Click += EqualButton_Click;
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox.Location = new Point(12, 108);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(685, 79);
            TextBox.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 691);
            Controls.Add(TextBox);
            Controls.Add(EqualButton);
            Controls.Add(DecimalButton);
            Controls.Add(ZeroButton);
            Controls.Add(JiggyButton);
            Controls.Add(PlusButton);
            Controls.Add(ThreeButton);
            Controls.Add(TwoButton);
            Controls.Add(OneButton);
            Controls.Add(MinusButton);
            Controls.Add(SixButton);
            Controls.Add(Fivebutton);
            Controls.Add(Fourbutton);
            Controls.Add(NineButton);
            Controls.Add(EightButton);
            Controls.Add(SevenButton);
            Controls.Add(MultiplyButton);
            Controls.Add(DivideButton);
            Controls.Add(Modulusbutton);
            Controls.Add(BackspaceButton);
            Controls.Add(ClearButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ClearButton;
        private Button BackspaceButton;
        private Button Modulusbutton;
        private Button DivideButton;
        private Button MultiplyButton;
        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button Fourbutton;
        private Button Fivebutton;
        private Button SixButton;
        private Button MinusButton;
        private Button OneButton;
        private Button TwoButton;
        private Button ThreeButton;
        private Button PlusButton;
        private Button JiggyButton;
        private Button ZeroButton;
        private Button DecimalButton;
        private Button EqualButton;
        private TextBox TextBox;
    }
}
