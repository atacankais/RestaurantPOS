namespace UI
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            SSB = new PictureBox();
            FKB = new PictureBox();
            FFB = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)SSB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FKB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FFB).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SSB
            // 
            SSB.Image = Properties.Resources.hamburger_5630646_1280;
            SSB.Location = new Point(6, 0);
            SSB.Name = "SSB";
            SSB.Size = new Size(436, 289);
            SSB.SizeMode = PictureBoxSizeMode.Zoom;
            SSB.TabIndex = 0;
            SSB.TabStop = false;
            // 
            // FKB
            // 
            FKB.Image = (Image)resources.GetObject("FKB.Image");
            FKB.Location = new Point(515, 0);
            FKB.Name = "FKB";
            FKB.Size = new Size(386, 289);
            FKB.SizeMode = PictureBoxSizeMode.Zoom;
            FKB.TabIndex = 1;
            FKB.TabStop = false;
            // 
            // FFB
            // 
            FFB.Image = Properties.Resources.hamburger_1238246_640;
            FFB.Location = new Point(976, 0);
            FFB.Name = "FFB";
            FFB.Size = new Size(387, 289);
            FFB.SizeMode = PictureBoxSizeMode.Zoom;
            FFB.TabIndex = 2;
            FFB.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 292);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Sizzle n' Spice Burger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(648, 291);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Flame-Kissed Burger";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1117, 291);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 5;
            label3.Text = "Flavor Fusion Burger";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 312);
            label4.Name = "label4";
            label4.Size = new Size(391, 45);
            label4.TabIndex = 6;
            label4.Text = "Premium beef, melting pepper jack cheese, chipotle-caramelized onion, \r\njalapeño salad, tomato, homemade chipotle mayo, homemade jalapeño \r\nmustard, brioche burger bun.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 312);
            label5.Name = "label5";
            label5.Size = new Size(392, 45);
            label5.TabIndex = 7;
            label5.Text = "Juicy premium beef, melting cheddar cheese, smoky bacon, caramelized \r\nonion, crispy iceberg lettuce and tomato, all enclosed in a freshly grilled \r\nbrioche bun.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(976, 306);
            label6.Name = "label6";
            label6.Size = new Size(392, 45);
            label6.TabIndex = 8;
            label6.Text = "Juicy premium beef, creamy mozzarella cheese, melting cheddar cheese, \r\ntomato, grilled bell pepper and onion, pickles, peppery arugula, and a \r\ntouch of our homemade basil pesto.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(FKB);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(SSB);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(FFB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 363);
            panel1.TabIndex = 9;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1387, 859);
            Controls.Add(panel1);
            Name = "Form";
            Text = "Burger Mansion";
            ((System.ComponentModel.ISupportInitialize)SSB).EndInit();
            ((System.ComponentModel.ISupportInitialize)FKB).EndInit();
            ((System.ComponentModel.ISupportInitialize)FFB).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox SSB;
        private PictureBox FKB;
        private PictureBox FFB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}
