namespace WidgetDemoProjectSp24
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
            label1 = new Label();
            txtWName = new TextBox();
            label2 = new Label();
            cboColor = new ComboBox();
            txtWDescription = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            btnCreate = new Button();
            btnQuit = new Button();
            openFileDialog1 = new OpenFileDialog();
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 132);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Widget &Name";
            // 
            // txtWName
            // 
            txtWName.Location = new Point(175, 132);
            txtWName.Name = "txtWName";
            txtWName.Size = new Size(100, 23);
            txtWName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 29);
            label2.Name = "label2";
            label2.Size = new Size(188, 30);
            label2.TabIndex = 2;
            label2.Text = "Widget Input Form";
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(154, 83);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(121, 23);
            cboColor.TabIndex = 3;
            // 
            // txtWDescription
            // 
            txtWDescription.Location = new Point(175, 181);
            txtWDescription.Name = "txtWDescription";
            txtWDescription.Size = new Size(100, 23);
            txtWDescription.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 184);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Widget &Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 86);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Widget Color";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(175, 223);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 226);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 7;
            label5.Text = "Widget &Price";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(30, 330);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "&Create Widget";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(175, 330);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.HorizontalScrollbar = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(18, 256);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(257, 64);
            lstOut.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 365);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnCreate);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtWDescription);
            Controls.Add(label3);
            Controls.Add(cboColor);
            Controls.Add(label2);
            Controls.Add(txtWName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Create widget Object based on Widget Class";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWName;
        private Label label2;
        private ComboBox cboColor;
        private TextBox txtWDescription;
        private Label label3;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Button btnCreate;
        private Button btnQuit;
        private OpenFileDialog openFileDialog1;
        private ListBox lstOut;
    }
}
