namespace Hello_
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
            msgbtn = new Button();
            cubiepng = new PictureBox();
            dioForcubie = new Label();
            ((System.ComponentModel.ISupportInitialize)cubiepng).BeginInit();
            SuspendLayout();
            // 
            // msgbtn
            // 
            msgbtn.BackColor = SystemColors.ControlText;
            msgbtn.Font = new Font("Chiller", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            msgbtn.ForeColor = SystemColors.ButtonHighlight;
            msgbtn.Location = new Point(193, 35);
            msgbtn.Name = "msgbtn";
            msgbtn.Size = new Size(87, 38);
            msgbtn.TabIndex = 0;
            msgbtn.Text = "Whats this?";
            msgbtn.UseVisualStyleBackColor = false;
            msgbtn.Click += msgbtn_Click;
            // 
            // cubiepng
            // 
            cubiepng.Image = (Image)resources.GetObject("cubiepng.Image");
            cubiepng.InitialImage = (Image)resources.GetObject("cubiepng.InitialImage");
            cubiepng.Location = new Point(15, 96);
            cubiepng.Name = "cubiepng";
            cubiepng.Size = new Size(65, 64);
            cubiepng.SizeMode = PictureBoxSizeMode.AutoSize;
            cubiepng.TabIndex = 1;
            cubiepng.TabStop = false;
            // 
            // dioForcubie
            // 
            dioForcubie.AutoSize = true;
            dioForcubie.BackColor = SystemColors.AppWorkspace;
            dioForcubie.ForeColor = SystemColors.ActiveCaptionText;
            dioForcubie.Location = new Point(33, 96);
            dioForcubie.Name = "dioForcubie";
            dioForcubie.Size = new Size(47, 15);
            dioForcubie.TabIndex = 2;
            dioForcubie.Text = "oh no...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(302, 205);
            Controls.Add(dioForcubie);
            Controls.Add(cubiepng);
            Controls.Add(msgbtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cubiepng).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button msgbtn;
        private PictureBox cubiepng;
        private Label dioForcubie;
    }
}
