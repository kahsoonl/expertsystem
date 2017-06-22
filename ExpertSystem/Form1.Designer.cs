namespace ExpertSystem
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
            this.inputTextArea = new System.Windows.Forms.RichTextBox();
            this.questionTextBox = new System.Windows.Forms.RichTextBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextArea
            // 
            this.inputTextArea.Location = new System.Drawing.Point(12, 340);
            this.inputTextArea.Name = "inputTextArea";
            this.inputTextArea.Size = new System.Drawing.Size(441, 135);
            this.inputTextArea.TabIndex = 0;
            this.inputTextArea.Text = "";
            this.inputTextArea.TextChanged += new System.EventHandler(this.inputTextArea_TextChanged);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 72);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(595, 249);
            this.questionTextBox.TabIndex = 1;
            this.questionTextBox.Text = "";
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(12, 56);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(49, 13);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.Text = "Question";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 324);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Input";
            this.inputLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(459, 382);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(148, 48);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 487);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.inputTextArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextArea;
        private System.Windows.Forms.RichTextBox questionTextBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button submitButton;
    }
}

