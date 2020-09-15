namespace JH_In_Class_Assignment1
{
    partial class HelloWorldForm
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
            this.clickMeButton = new System.Windows.Forms.Button();
            this.clickMeButtonHint = new System.Windows.Forms.Label();
            this.helloThereLabel = new System.Windows.Forms.Label();
            this.appearOnButtonClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            this.clickMeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMeButton.Location = new System.Drawing.Point(189, 187);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(135, 53);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.Text = "Click Me!";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.clickMeButton_Click);
            // 
            // clickMeButtonHint
            // 
            this.clickMeButtonHint.AutoSize = true;
            this.clickMeButtonHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMeButtonHint.Location = new System.Drawing.Point(119, 255);
            this.clickMeButtonHint.Name = "clickMeButtonHint";
            this.clickMeButtonHint.Size = new System.Drawing.Size(275, 20);
            this.clickMeButtonHint.TabIndex = 1;
            this.clickMeButtonHint.Text = "(You should try clicking the button above)";
            this.clickMeButtonHint.Click += new System.EventHandler(this.label1_Click);
            // 
            // helloThereLabel
            // 
            this.helloThereLabel.AllowDrop = true;
            this.helloThereLabel.AutoSize = true;
            this.helloThereLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloThereLabel.Location = new System.Drawing.Point(84, 45);
            this.helloThereLabel.Name = "helloThereLabel";
            this.helloThereLabel.Size = new System.Drawing.Size(352, 37);
            this.helloThereLabel.TabIndex = 2;
            this.helloThereLabel.Text = "Hello there! How are you?";
            this.helloThereLabel.Visible = false;
            // 
            // appearOnButtonClick
            // 
            this.appearOnButtonClick.AutoSize = true;
            this.appearOnButtonClick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appearOnButtonClick.Location = new System.Drawing.Point(185, 143);
            this.appearOnButtonClick.Name = "appearOnButtonClick";
            this.appearOnButtonClick.Size = new System.Drawing.Size(0, 21);
            this.appearOnButtonClick.TabIndex = 3;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 352);
            this.Controls.Add(this.appearOnButtonClick);
            this.Controls.Add(this.helloThereLabel);
            this.Controls.Add(this.clickMeButtonHint);
            this.Controls.Add(this.clickMeButton);
            this.Name = "HelloWorldForm";
            this.Text = "Hello World Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.Label clickMeButtonHint;
        private System.Windows.Forms.Label helloThereLabel;
        private System.Windows.Forms.Label appearOnButtonClick;
    }
}

