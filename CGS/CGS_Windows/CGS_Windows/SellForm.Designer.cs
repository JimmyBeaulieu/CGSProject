namespace CGS_Windows
{
    partial class SellForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.artPieceText = new System.Windows.Forms.TextBox();
            this.estimateText = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(368, 158);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(72, 162);
            this.displayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(226, 34);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display Artpiece Information";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artpiece ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estimate:";
            // 
            // artPieceText
            // 
            this.artPieceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artPieceText.Location = new System.Drawing.Point(177, 235);
            this.artPieceText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artPieceText.Multiline = true;
            this.artPieceText.Name = "artPieceText";
            this.artPieceText.Size = new System.Drawing.Size(122, 24);
            this.artPieceText.TabIndex = 1;
            // 
            // estimateText
            // 
            this.estimateText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estimateText.Location = new System.Drawing.Point(177, 288);
            this.estimateText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.estimateText.Multiline = true;
            this.estimateText.Name = "estimateText";
            this.estimateText.Size = new System.Drawing.Size(122, 24);
            this.estimateText.TabIndex = 2;
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(72, 353);
            this.sellButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(92, 28);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(206, 353);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 396);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.estimateText);
            this.Controls.Add(this.artPieceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox artPieceText;
        private System.Windows.Forms.TextBox estimateText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button sellButton;
    }
}