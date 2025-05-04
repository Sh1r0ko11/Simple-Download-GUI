namespace Installer_multi_tool
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            downloadProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, -2);
            label1.Name = "label1";
            label1.Size = new Size(353, 98);
            label1.TabIndex = 0;
            label1.Text = "EXtool";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.BlanchedAlmond;
            linkLabel1.Location = new Point(466, 86);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(177, 39);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Installer";
            linkLabel1.VisitedLinkColor = Color.Red;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(47, 209);
            button1.Name = "button1";
            button1.Size = new Size(596, 186);
            button1.TabIndex = 2;
            button1.Text = "Install";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.BlanchedAlmond;
            linkLabel2.Location = new Point(29, 86);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.RightToLeft = RightToLeft.Yes;
            linkLabel2.Size = new Size(177, 39);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Installer";
            linkLabel2.VisitedLinkColor = Color.Red;
            // 
            // downloadProgressBar
            // 
            downloadProgressBar.AccessibleDescription = "downloadProgressBar";
            downloadProgressBar.AccessibleName = "downloadProgressBar";
            downloadProgressBar.BackColor = Color.MediumTurquoise;
            downloadProgressBar.ForeColor = Color.Red;
            downloadProgressBar.Location = new Point(212, 86);
            downloadProgressBar.Name = "downloadProgressBar";
            downloadProgressBar.Size = new Size(226, 42);
            downloadProgressBar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(697, 395);
            Controls.Add(downloadProgressBar);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Youre Installer name";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Button button1;
        private LinkLabel linkLabel2;
        private ProgressBar downloadProgressBar;
    }
}
