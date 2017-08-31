namespace ZXingNetBarCodeApp
{
    partial class BarCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblBaiCodeValue = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInputBarCode = new System.Windows.Forms.TextBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Image to Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblBaiCodeValue
            // 
            this.lblBaiCodeValue.AutoSize = true;
            this.lblBaiCodeValue.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiCodeValue.Location = new System.Drawing.Point(279, 44);
            this.lblBaiCodeValue.Name = "lblBaiCodeValue";
            this.lblBaiCodeValue.Size = new System.Drawing.Size(222, 25);
            this.lblBaiCodeValue.TabIndex = 2;
            this.lblBaiCodeValue.Text = "Can\'t Read Bar Code";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate QRCode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInputBarCode
            // 
            this.txtInputBarCode.Location = new System.Drawing.Point(107, 91);
            this.txtInputBarCode.Name = "txtInputBarCode";
            this.txtInputBarCode.Size = new System.Drawing.Size(136, 20);
            this.txtInputBarCode.TabIndex = 4;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(298, 109);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(200, 200);
            this.pbQRCode.TabIndex = 5;
            this.pbQRCode.TabStop = false;
            // 
            // BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 464);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.txtInputBarCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblBaiCodeValue);
            this.Controls.Add(this.button1);
            this.Name = "BarCode";
            this.Text = "Bar Code Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblBaiCodeValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInputBarCode;
        private System.Windows.Forms.PictureBox pbQRCode;
    }
}

