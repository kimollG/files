namespace Semestr2Att3
{
    partial class FormGraphDraw
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
            this.pictureBoxGrafh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGrafh
            // 
            this.pictureBoxGrafh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxGrafh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGrafh.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGrafh.Name = "pictureBoxGrafh";
            this.pictureBoxGrafh.Size = new System.Drawing.Size(886, 459);
            this.pictureBoxGrafh.TabIndex = 0;
            this.pictureBoxGrafh.TabStop = false;
            this.pictureBoxGrafh.SizeChanged += new System.EventHandler(this.pictureBoxGrafh_SizeChanged);
            this.pictureBoxGrafh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGrafh_MouseDown);
            this.pictureBoxGrafh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGrafh_MouseMove);
            this.pictureBoxGrafh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGrafh_MouseUp);
            // 
            // FormGrapfhDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 459);
            this.Controls.Add(this.pictureBoxGrafh);
            this.Name = "FormGrapfhDraw";
            this.Text = "Граф";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGrafh;
    }
}
