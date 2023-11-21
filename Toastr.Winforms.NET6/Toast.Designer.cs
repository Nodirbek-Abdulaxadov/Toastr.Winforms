namespace Toastr.Winforms;

partial class Toast
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
        icon = new PictureBox();
        message = new Label();
        close = new Button();
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
        message.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
        close.BackgroundImage = Toastr.Winforms.Properties.Resources.x_icon_light;
        close.BackgroundImageLayout = ImageLayout.Zoom;
        close.FlatAppearance.BorderSize = 0;
        close.FlatStyle = FlatStyle.Flat;
        close.Location = new Point(365, 3);
        close.Name = "close";
        close.Size = new Size(23, 23);
        close.TabIndex = 2;
        close.UseVisualStyleBackColor = true;
        close.Click += close_Click;
        // 
        // Toast
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(113, 179, 113);
        ClientSize = new Size(391, 66);
        Controls.Add(close);
        Controls.Add(message);
        Controls.Add(icon);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Toast";
        Load += Toastr_Load;
        ((System.ComponentModel.ISupportInitialize)icon).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox icon;
    private Label message;
    private Button close;
}
