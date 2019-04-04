namespace TezControlSystem
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
            this.colorize = new System.Windows.Forms.Button();
            this.deleteedges = new System.Windows.Forms.Button();
            this.nextstep = new System.Windows.Forms.Button();
            this.socketadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorize
            // 
            this.colorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorize.Location = new System.Drawing.Point(289, 416);
            this.colorize.Margin = new System.Windows.Forms.Padding(2);
            this.colorize.Name = "colorize";
            this.colorize.Size = new System.Drawing.Size(91, 46);
            this.colorize.TabIndex = 14;
            this.colorize.Text = "Colorize";
            this.colorize.UseVisualStyleBackColor = true;
            this.colorize.Click += new System.EventHandler(this.colorize_Click);
            // 
            // deleteedges
            // 
            this.deleteedges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteedges.Location = new System.Drawing.Point(128, 416);
            this.deleteedges.Margin = new System.Windows.Forms.Padding(2);
            this.deleteedges.Name = "deleteedges";
            this.deleteedges.Size = new System.Drawing.Size(91, 46);
            this.deleteedges.TabIndex = 13;
            this.deleteedges.Text = "Delete Edges";
            this.deleteedges.UseVisualStyleBackColor = true;
            this.deleteedges.Click += new System.EventHandler(this.deleteedges_Click);
            // 
            // nextstep
            // 
            this.nextstep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nextstep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextstep.Location = new System.Drawing.Point(412, 416);
            this.nextstep.Margin = new System.Windows.Forms.Padding(2);
            this.nextstep.Name = "nextstep";
            this.nextstep.Size = new System.Drawing.Size(91, 46);
            this.nextstep.TabIndex = 10;
            this.nextstep.Text = "NextStep";
            this.nextstep.UseVisualStyleBackColor = false;
            this.nextstep.Click += new System.EventHandler(this.nextstep_Click);
            // 
            // socketadd
            // 
            this.socketadd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.socketadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.socketadd.Location = new System.Drawing.Point(33, 416);
            this.socketadd.Margin = new System.Windows.Forms.Padding(2);
            this.socketadd.Name = "socketadd";
            this.socketadd.Size = new System.Drawing.Size(91, 46);
            this.socketadd.TabIndex = 9;
            this.socketadd.Text = "Socket Add";
            this.socketadd.UseVisualStyleBackColor = false;
            this.socketadd.Click += new System.EventHandler(this.socketadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 492);
            this.Controls.Add(this.colorize);
            this.Controls.Add(this.deleteedges);
            this.Controls.Add(this.nextstep);
            this.Controls.Add(this.socketadd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button colorize;
        private System.Windows.Forms.Button deleteedges;
        private System.Windows.Forms.Button nextstep;
        private System.Windows.Forms.Button socketadd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

