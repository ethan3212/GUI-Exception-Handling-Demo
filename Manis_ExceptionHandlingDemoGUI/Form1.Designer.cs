
namespace Manis_ExceptionHandlingDemoGUI
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
            this.intBox = new System.Windows.Forms.TextBox();
            this.IntegerLabel = new System.Windows.Forms.Label();
            this.IntButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intBox
            // 
            this.intBox.Location = new System.Drawing.Point(328, 133);
            this.intBox.Name = "intBox";
            this.intBox.Size = new System.Drawing.Size(121, 26);
            this.intBox.TabIndex = 0;
            // 
            // IntegerLabel
            // 
            this.IntegerLabel.AutoSize = true;
            this.IntegerLabel.Location = new System.Drawing.Point(324, 110);
            this.IntegerLabel.Name = "IntegerLabel";
            this.IntegerLabel.Size = new System.Drawing.Size(125, 20);
            this.IntegerLabel.TabIndex = 1;
            this.IntegerLabel.Text = "Enter an Integer";
            // 
            // IntButton
            // 
            this.IntButton.Location = new System.Drawing.Point(328, 193);
            this.IntButton.Name = "IntButton";
            this.IntButton.Size = new System.Drawing.Size(121, 65);
            this.IntButton.TabIndex = 2;
            this.IntButton.Text = "Check If Integer";
            this.IntButton.UseVisualStyleBackColor = true;
            this.IntButton.Click += new System.EventHandler(this.IntButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(152, 282);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(459, 26);
            this.outputBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.IntButton);
            this.Controls.Add(this.IntegerLabel);
            this.Controls.Add(this.intBox);
            this.Name = "Form1";
            this.Text = "Manis_ExceptionHandlingDemoGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intBox;
        private System.Windows.Forms.Label IntegerLabel;
        private System.Windows.Forms.Button IntButton;
        private System.Windows.Forms.TextBox outputBox;
    }
}

