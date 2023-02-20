namespace CreateQR
{
    partial class Form1
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
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            this.SuspendLayout();
            // 
            // imgQR
            // 
            this.imgQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgQR.Location = new System.Drawing.Point(65, 36);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(200, 200);
            this.imgQR.TabIndex = 0;
            this.imgQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(65, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(65, 429);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generar QR";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(190, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 498);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgQR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgQR;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.TextBox label2;
        private System.Windows.Forms.TextBox label3;
        private System.Windows.Forms.TextBox label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
    }
}

