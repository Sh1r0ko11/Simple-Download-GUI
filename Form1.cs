using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Installer_multi_tool
{
    public partial class Form1 : Form
    {
        //Левый
        private string downloadUrl = "https://github.com/Sh1r0ko11/IP-Beast/releases/download/Beta/beast.Tool.Beta.1.ONLY.open.source.zip";
        private string redirectUrl = "https://github.com/Sh1r0ko11";

       
        private bool isMouseDown = false;
        private Point mouseOffset;

        public Form1()
        {
            InitializeComponent();

            
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Opacity = 0.95; 
            this.BackColor = System.Drawing.Color.White; 
            this.DoubleBuffered = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ControlBox = true;
            this.ShowInTaskbar = true;

            
            this.TransparencyKey = System.Drawing.Color.White;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableBlur(); 

            
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Click += Button_Click;
                }
                else if (control is LinkLabel linkLabel)
                {
                    linkLabel.LinkClicked += LinkLabel_LinkClicked;
                }
            }

            
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

            downloadProgressBar.Value = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fileName = Path.GetFileName(new Uri(downloadUrl).AbsolutePath);
            string destinationPath = Path.Combine(downloadsPath, fileName);

            WebClient client = new WebClient();

            client.DownloadProgressChanged += (s, args) =>
            {
                downloadProgressBar.Value = args.ProgressPercentage;
            };

            client.DownloadFileCompleted += (s, args) =>
            {
                MessageBox.Show($"Download completed:\n{destinationPath}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                downloadProgressBar.Value = 0;
            };

            try
            {
                client.DownloadFileAsync(new Uri(downloadUrl), destinationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Download failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = redirectUrl,
                UseShellExecute = true
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void EnableBlur()
        {
            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND;

            
            accent.GradientColor = unchecked((int)0x99A0A0A0); 

            int size = Marshal.SizeOf(accent);
            IntPtr accentPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData();
            data.Attribute = 19;
            data.SizeOfData = size;
            data.Data = accentPtr;

            NativeMethods.SetWindowCompositionAttribute(this.Handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        
        enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_ENABLE_ACRYLICBLURBEHIND = 4,
            ACCENT_ENABLE_HOSTBACKDROP = 5,
            ACCENT_INVALID_STATE = 6
        }

        struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        struct WindowCompositionAttributeData
        {
            public int Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);
        }

        // To allow dragging the form
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(this.Left + e.X - mouseOffset.X, this.Top + e.Y - mouseOffset.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
