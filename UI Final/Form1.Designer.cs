namespace UI_Final
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAboutUs = new Button();
            btnAC = new Button();
            btnOurProducts = new Button();
            btnFI = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 84);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "About us";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 117);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Avian consouling";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 151);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Our products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 190);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "For investors";
            // 
            // btnAboutUs
            // 
            btnAboutUs.Location = new Point(375, 77);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(94, 29);
            btnAboutUs.TabIndex = 4;
            btnAboutUs.Text = "Click here";
            btnAboutUs.UseVisualStyleBackColor = true;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnAC
            // 
            btnAC.Location = new Point(375, 112);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(94, 25);
            btnAC.TabIndex = 5;
            btnAC.Text = "Click Here";
            btnAC.UseVisualStyleBackColor = true;
            btnAC.Click += btnAC_Click;
            // 
            // btnOurProducts
            // 
            btnOurProducts.Location = new Point(376, 143);
            btnOurProducts.Name = "btnOurProducts";
            btnOurProducts.Size = new Size(93, 31);
            btnOurProducts.TabIndex = 6;
            btnOurProducts.Text = "Click Here";
            btnOurProducts.UseVisualStyleBackColor = true;
            btnOurProducts.Click += btnOurProducts_Click;
            // 
            // btnFI
            // 
            btnFI.Location = new Point(375, 181);
            btnFI.Name = "btnFI";
            btnFI.Size = new Size(94, 33);
            btnFI.TabIndex = 7;
            btnFI.Text = "Click Here";
            btnFI.UseVisualStyleBackColor = true;
            btnFI.Click += btnFI_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 41);
            label5.Name = "label5";
            label5.Size = new Size(267, 15);
            label5.TabIndex = 8;
            label5.Text = "Welcome to Deep Creek Outdoors mini-webpage";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 309);
            Controls.Add(label5);
            Controls.Add(btnFI);
            Controls.Add(btnOurProducts);
            Controls.Add(btnAC);
            Controls.Add(btnAboutUs);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAboutUs;
        private Button btnAC;
        private Button btnOurProducts;
        private Button btnFI;
        private Label label5;
    }
}