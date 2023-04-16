namespace Enigma_Simulator
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
            lbl1 = new Label();
            cB1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cB4 = new ComboBox();
            cB3 = new ComboBox();
            cB2 = new ComboBox();
            label6 = new Label();
            fRotorSet = new TextBox();
            tRotorSet = new TextBox();
            sRotorSet = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            btnEncrypt = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(293, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(223, 65);
            lbl1.TabIndex = 0;
            lbl1.Text = "Enigma 1";
            // 
            // cB1
            // 
            cB1.FlatStyle = FlatStyle.Popup;
            cB1.Items.AddRange(new object[] { "UKW B", "UKW C" });
            cB1.Location = new Point(101, 161);
            cB1.Name = "cB1";
            cB1.Size = new Size(121, 23);
            cB1.TabIndex = 1;
            cB1.Text = "UKW B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 89);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 2;
            label1.Text = "A set of rotors";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 133);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Reversing rotor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "1st rotor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 133);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "2nd rotor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 133);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 6;
            label5.Text = "3rd rotor";
            // 
            // cB4
            // 
            cB4.AutoCompleteCustomSource.AddRange(new string[] { "I", "II", "III" });
            cB4.FlatStyle = FlatStyle.Popup;
            cB4.Items.AddRange(new object[] { "I", "II", "III" });
            cB4.Location = new Point(562, 161);
            cB4.Name = "cB4";
            cB4.Size = new Size(121, 23);
            cB4.TabIndex = 7;
            cB4.Text = "III";
            // 
            // cB3
            // 
            cB3.AutoCompleteCustomSource.AddRange(new string[] { "I", "II", "III" });
            cB3.FlatStyle = FlatStyle.Popup;
            cB3.Items.AddRange(new object[] { "I", "II", "III" });
            cB3.Location = new Point(410, 161);
            cB3.Name = "cB3";
            cB3.Size = new Size(121, 23);
            cB3.TabIndex = 8;
            cB3.Text = "II";
            // 
            // cB2
            // 
            cB2.AutoCompleteCustomSource.AddRange(new string[] { "I", "II", "III" });
            cB2.FlatStyle = FlatStyle.Popup;
            cB2.Items.AddRange(new object[] { "I", "II", "III" });
            cB2.Location = new Point(256, 161);
            cB2.Name = "cB2";
            cB2.Size = new Size(121, 23);
            cB2.TabIndex = 9;
            cB2.Text = "I";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(319, 199);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 10;
            label6.Text = "Rotors settings";
            // 
            // fRotorSet
            // 
            fRotorSet.Location = new Point(256, 272);
            fRotorSet.Name = "fRotorSet";
            fRotorSet.Size = new Size(45, 23);
            fRotorSet.TabIndex = 11;
            fRotorSet.Text = "1";
            // 
            // tRotorSet
            // 
            tRotorSet.Location = new Point(486, 272);
            tRotorSet.Name = "tRotorSet";
            tRotorSet.Size = new Size(45, 23);
            tRotorSet.TabIndex = 12;
            tRotorSet.Text = "1";
            // 
            // sRotorSet
            // 
            sRotorSet.Location = new Point(377, 272);
            sRotorSet.Name = "sRotorSet";
            sRotorSet.Size = new Size(45, 23);
            sRotorSet.TabIndex = 13;
            sRotorSet.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 243);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "1st rotor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 243);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "2nd rotor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(480, 243);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 16;
            label9.Text = "3rd rotor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(347, 313);
            label10.Name = "label10";
            label10.Size = new Size(105, 32);
            label10.TabIndex = 17;
            label10.Text = "Plaintext";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 18;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(480, 357);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 27);
            btnEncrypt.TabIndex = 19;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(256, 387);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(299, 54);
            lblResult.TabIndex = 20;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnEncrypt);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(sRotorSet);
            Controls.Add(tRotorSet);
            Controls.Add(fRotorSet);
            Controls.Add(label6);
            Controls.Add(cB2);
            Controls.Add(cB3);
            Controls.Add(cB4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cB1);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private ComboBox cB1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cB4;
        private ComboBox cB3;
        private ComboBox cB2;
        private Label label6;
        private TextBox fRotorSet;
        private TextBox tRotorSet;
        private TextBox sRotorSet;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private Button btnEncrypt;
        private Label lblResult;
    }
}