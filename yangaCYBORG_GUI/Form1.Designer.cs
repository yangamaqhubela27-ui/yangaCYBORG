namespace yangaCYBORG_GUI
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
            rtbChat = new RichTextBox();
            txtUserInput = new TextBox();
            btnSend = new Button();
            logo = new PictureBox();
            flowChat = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 37);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(654, 38);
            label1.TabIndex = 0;
            label1.Text = "YangaCYBORG-Cybersecurity Awereness Chatbot";
            label1.Click += label1_Click;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.FromArgb(30, 41, 59);
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbChat.ForeColor = Color.White;
            rtbChat.Location = new Point(176, 141);
            rtbChat.Margin = new Padding(6);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(1304, 448);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "";
            rtbChat.Visible = false;
            // 
            // txtUserInput
            // 
            txtUserInput.BackColor = Color.FromArgb(51, 65, 85);
            txtUserInput.BorderStyle = BorderStyle.FixedSingle;
            txtUserInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserInput.ForeColor = Color.White;
            txtUserInput.Location = new Point(176, 651);
            txtUserInput.Margin = new Padding(6);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(704, 31);
            txtUserInput.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(37, 99, 235);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(1190, 646);
            btnSend.Margin = new Padding(6);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(188, 54);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(161, -5);
            logo.Margin = new Padding(6, 7, 6, 7);
            logo.Name = "logo";
            logo.Size = new Size(284, 136);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 4;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // flowChat
            // 
            flowChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowChat.AutoScroll = true;
            flowChat.BackColor = Color.FromArgb(30, 41, 59);
            flowChat.FlowDirection = FlowDirection.TopDown;
            flowChat.Location = new Point(176, 141);
            flowChat.Name = "flowChat";
            flowChat.Size = new Size(1179, 448);
            flowChat.TabIndex = 5;
            flowChat.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 27, 48);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1600, 834);
            Controls.Add(flowChat);
            Controls.Add(logo);
            Controls.Add(btnSend);
            Controls.Add(txtUserInput);
            Controls.Add(rtbChat);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbChat;
        private TextBox txtUserInput;
        private Button btnSend;
        private PictureBox logo;
        private FlowLayoutPanel flowChat;
    }
}
