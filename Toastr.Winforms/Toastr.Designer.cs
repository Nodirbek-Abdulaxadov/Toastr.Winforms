
namespace Toastr.Winforms
{
    partial class Toastr
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            icon = new PictureBox();
            message = new Label();
            close = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // icon
            // 
            icon.Location = new Point(10, 8);
            icon.Name = "icon";
            icon.Size = new Size(50, 50);
            icon.TabIndex = 0;
            icon.TabStop = false;
            // 
            // message
            // 
            message.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            message.ForeColor = Color.White;
            message.Location = new Point(66, 9);
            message.Name = "message";
            message.Size = new Size(300, 48);
            message.TabIndex = 1;
            message.Text = "Muvoffaqqiyatli saqlandi!";
            message.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // close
            // 
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.BorderColor = Color.LightGray;
            close.BorderRadius = 5;
            close.Cursor = Cursors.Hand;
            close.CustomizableEdges = customizableEdges1;
            close.DisabledState.BorderColor = Color.DarkGray;
            close.DisabledState.CustomBorderColor = Color.DarkGray;
            close.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            close.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            close.FillColor = Color.Transparent;
            close.Font = new Font("Segoe UI", 9F);
            close.ForeColor = Color.White;
            close.ImageSize = new Size(15, 15);
            close.Location = new Point(361, -1);
            close.Name = "close";
            close.ShadowDecoration.CustomizableEdges = customizableEdges2;
            close.Size = new Size(30, 30);
            close.TabIndex = 5;
            close.Click += close_Click;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 15;
            guna2ShadowForm1.TargetForm = this;
            // 
            // Toastr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 179, 113);
            ClientSize = new Size(391, 66);
            Controls.Add(close);
            Controls.Add(message);
            Controls.Add(icon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Toastr";
            Load += Toastr_Load;
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox icon;
        private Label message;
        private Guna.UI2.WinForms.Guna2Button close;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
