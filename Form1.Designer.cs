
namespace serialPortInterrupt
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGetPortsIn = new System.Windows.Forms.Button();
            this.txtMex = new System.Windows.Forms.TextBox();
            this.cbIn = new System.Windows.Forms.ComboBox();
            this.cbOut = new System.Windows.Forms.ComboBox();
            this.btnGetPortOut = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnGetMex = new System.Windows.Forms.Button();
            this.Chat = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetPortsIn
            // 
            this.btnGetPortsIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPortsIn.FlatAppearance.BorderSize = 0;
            this.btnGetPortsIn.Location = new System.Drawing.Point(555, 65);
            this.btnGetPortsIn.Name = "btnGetPortsIn";
            this.btnGetPortsIn.Size = new System.Drawing.Size(95, 27);
            this.btnGetPortsIn.TabIndex = 0;
            this.btnGetPortsIn.Text = "GetPortIn";
            this.btnGetPortsIn.UseVisualStyleBackColor = true;
            this.btnGetPortsIn.Click += new System.EventHandler(this.btnGetPortsIn_Click);
            // 
            // txtMex
            // 
            this.txtMex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMex.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMex.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMex.Location = new System.Drawing.Point(15, 397);
            this.txtMex.Name = "txtMex";
            this.txtMex.Size = new System.Drawing.Size(650, 28);
            this.txtMex.TabIndex = 1;
            this.txtMex.Text = "enter a message";
            this.txtMex.Click += new System.EventHandler(this.txtMex_Click);
            this.txtMex.TextChanged += new System.EventHandler(this.txtMex_TextChanged);
            this.txtMex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMex_KeyDown);
            // 
            // cbIn
            // 
            this.cbIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIn.FormattingEnabled = true;
            this.cbIn.Location = new System.Drawing.Point(656, 67);
            this.cbIn.Name = "cbIn";
            this.cbIn.Size = new System.Drawing.Size(121, 24);
            this.cbIn.TabIndex = 3;
            // 
            // cbOut
            // 
            this.cbOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOut.FormattingEnabled = true;
            this.cbOut.Location = new System.Drawing.Point(656, 97);
            this.cbOut.Name = "cbOut";
            this.cbOut.Size = new System.Drawing.Size(121, 24);
            this.cbOut.TabIndex = 4;
            // 
            // btnGetPortOut
            // 
            this.btnGetPortOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPortOut.FlatAppearance.BorderSize = 0;
            this.btnGetPortOut.Location = new System.Drawing.Point(555, 95);
            this.btnGetPortOut.Name = "btnGetPortOut";
            this.btnGetPortOut.Size = new System.Drawing.Size(95, 27);
            this.btnGetPortOut.TabIndex = 5;
            this.btnGetPortOut.Text = "GetPortOut";
            this.btnGetPortOut.UseVisualStyleBackColor = true;
            this.btnGetPortOut.Click += new System.EventHandler(this.btnGetPortOut_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Location = new System.Drawing.Point(671, 396);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(106, 30);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::serialPortInterrupt.Properties.Resources.h__1_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bad Signal", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "yperTerminal";
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.ForeColor = System.Drawing.Color.Red;
            this.btnSwitch.Location = new System.Drawing.Point(731, 12);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(59, 27);
            this.btnSwitch.TabIndex = 9;
            this.btnSwitch.Text = "OFF";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnGetMex
            // 
            this.btnGetMex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMex.FlatAppearance.BorderSize = 0;
            this.btnGetMex.Location = new System.Drawing.Point(443, 95);
            this.btnGetMex.Name = "btnGetMex";
            this.btnGetMex.Size = new System.Drawing.Size(95, 27);
            this.btnGetMex.TabIndex = 10;
            this.btnGetMex.Text = "GetMex";
            this.btnGetMex.UseVisualStyleBackColor = true;
            this.btnGetMex.Click += new System.EventHandler(this.btnGetMex_Click);
            // 
            // Chat
            // 
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 16;
            this.Chat.Location = new System.Drawing.Point(15, 153);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(762, 228);
            this.Chat.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.btnGetMex);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnGetPortOut);
            this.Controls.Add(this.cbOut);
            this.Controls.Add(this.cbIn);
            this.Controls.Add(this.txtMex);
            this.Controls.Add(this.btnGetPortsIn);
            this.Name = "Form1";
            this.Text = "Serial Port Interrupt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPortsIn;
        private System.Windows.Forms.TextBox txtMex;
        private System.Windows.Forms.ComboBox cbIn;
        private System.Windows.Forms.ComboBox cbOut;
        private System.Windows.Forms.Button btnGetPortOut;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnGetMex;
        private System.Windows.Forms.ListBox Chat;
    }
}

