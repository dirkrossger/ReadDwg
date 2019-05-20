namespace AutoCADApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnDimension = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCaption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circle Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(12, 35);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(134, 33);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(121, 23);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Create Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(134, 62);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(121, 23);
            this.btnDimension.TabIndex = 6;
            this.btnDimension.Text = "Add Dimension";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCaption
            // 
            this.btnCaption.Location = new System.Drawing.Point(134, 91);
            this.btnCaption.Name = "btnCaption";
            this.btnCaption.Size = new System.Drawing.Size(121, 23);
            this.btnCaption.TabIndex = 8;
            this.btnCaption.Text = "Add Caption";
            this.btnCaption.UseVisualStyleBackColor = true;
            this.btnCaption.Click += new System.EventHandler(this.btnCaption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 187);
            this.Controls.Add(this.btnCaption);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDimension);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AutoCADApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnDimension;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCaption;
    }
}

