namespace MyCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Num7Button = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.Num0Button = new System.Windows.Forms.Button();
            this.NumDotButton = new System.Windows.Forms.Button();
            this.OpePlusButton = new System.Windows.Forms.Button();
            this.OpeMinusButton = new System.Windows.Forms.Button();
            this.OpeMultiButton = new System.Windows.Forms.Button();
            this.OpeDivideButton = new System.Windows.Forms.Button();
            this.OpeEqualButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.HistoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 43);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(249, 31);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Num7Button
            // 
            this.Num7Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num7Button.Location = new System.Drawing.Point(12, 94);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(45, 37);
            this.Num7Button.TabIndex = 1;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            this.Num7Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num8Button
            // 
            this.Num8Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num8Button.Location = new System.Drawing.Point(63, 94);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(45, 37);
            this.Num8Button.TabIndex = 2;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            this.Num8Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num9Button
            // 
            this.Num9Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num9Button.Location = new System.Drawing.Point(114, 94);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(45, 37);
            this.Num9Button.TabIndex = 2;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num4Button
            // 
            this.Num4Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num4Button.Location = new System.Drawing.Point(12, 137);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(45, 37);
            this.Num4Button.TabIndex = 1;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            this.Num4Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num5Button
            // 
            this.Num5Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num5Button.Location = new System.Drawing.Point(63, 137);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(45, 37);
            this.Num5Button.TabIndex = 2;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            this.Num5Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num6Button
            // 
            this.Num6Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num6Button.Location = new System.Drawing.Point(114, 137);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(45, 37);
            this.Num6Button.TabIndex = 2;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            this.Num6Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num1Button
            // 
            this.Num1Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num1Button.Location = new System.Drawing.Point(12, 180);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(45, 37);
            this.Num1Button.TabIndex = 1;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            this.Num1Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num2Button
            // 
            this.Num2Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num2Button.Location = new System.Drawing.Point(63, 180);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(45, 37);
            this.Num2Button.TabIndex = 2;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            this.Num2Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num3Button
            // 
            this.Num3Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num3Button.Location = new System.Drawing.Point(114, 180);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(45, 37);
            this.Num3Button.TabIndex = 2;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            this.Num3Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num0Button
            // 
            this.Num0Button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num0Button.Location = new System.Drawing.Point(12, 223);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(96, 37);
            this.Num0Button.TabIndex = 1;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            this.Num0Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumDotButton
            // 
            this.NumDotButton.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumDotButton.Location = new System.Drawing.Point(114, 223);
            this.NumDotButton.Name = "NumDotButton";
            this.NumDotButton.Size = new System.Drawing.Size(45, 37);
            this.NumDotButton.TabIndex = 2;
            this.NumDotButton.Text = ".";
            this.NumDotButton.UseVisualStyleBackColor = true;
            this.NumDotButton.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // OpePlusButton
            // 
            this.OpePlusButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpePlusButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpePlusButton.Location = new System.Drawing.Point(165, 223);
            this.OpePlusButton.Name = "OpePlusButton";
            this.OpePlusButton.Size = new System.Drawing.Size(45, 37);
            this.OpePlusButton.TabIndex = 2;
            this.OpePlusButton.Text = "+";
            this.OpePlusButton.UseVisualStyleBackColor = false;
            this.OpePlusButton.Click += new System.EventHandler(this.OpeButton_Click);
            // 
            // OpeMinusButton
            // 
            this.OpeMinusButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpeMinusButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpeMinusButton.Location = new System.Drawing.Point(165, 180);
            this.OpeMinusButton.Name = "OpeMinusButton";
            this.OpeMinusButton.Size = new System.Drawing.Size(45, 37);
            this.OpeMinusButton.TabIndex = 2;
            this.OpeMinusButton.Text = "-";
            this.OpeMinusButton.UseVisualStyleBackColor = false;
            this.OpeMinusButton.Click += new System.EventHandler(this.OpeButton_Click);
            // 
            // OpeMultiButton
            // 
            this.OpeMultiButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpeMultiButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpeMultiButton.Location = new System.Drawing.Point(165, 137);
            this.OpeMultiButton.Name = "OpeMultiButton";
            this.OpeMultiButton.Size = new System.Drawing.Size(45, 37);
            this.OpeMultiButton.TabIndex = 2;
            this.OpeMultiButton.Text = "*";
            this.OpeMultiButton.UseVisualStyleBackColor = false;
            this.OpeMultiButton.Click += new System.EventHandler(this.OpeButton_Click);
            // 
            // OpeDivideButton
            // 
            this.OpeDivideButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpeDivideButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpeDivideButton.Location = new System.Drawing.Point(165, 94);
            this.OpeDivideButton.Name = "OpeDivideButton";
            this.OpeDivideButton.Size = new System.Drawing.Size(45, 37);
            this.OpeDivideButton.TabIndex = 2;
            this.OpeDivideButton.Text = "/";
            this.OpeDivideButton.UseVisualStyleBackColor = false;
            this.OpeDivideButton.Click += new System.EventHandler(this.OpeButton_Click);
            // 
            // OpeEqualButton
            // 
            this.OpeEqualButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.OpeEqualButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpeEqualButton.Location = new System.Drawing.Point(216, 180);
            this.OpeEqualButton.Name = "OpeEqualButton";
            this.OpeEqualButton.Size = new System.Drawing.Size(45, 80);
            this.OpeEqualButton.TabIndex = 2;
            this.OpeEqualButton.Text = "=";
            this.OpeEqualButton.UseVisualStyleBackColor = false;
            this.OpeEqualButton.Click += new System.EventHandler(this.OpeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClearButton.Location = new System.Drawing.Point(216, 94);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(45, 80);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // HistoryTextBox
            // 
            this.HistoryTextBox.Enabled = false;
            this.HistoryTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HistoryTextBox.Location = new System.Drawing.Point(14, 12);
            this.HistoryTextBox.Name = "HistoryTextBox";
            this.HistoryTextBox.Size = new System.Drawing.Size(249, 25);
            this.HistoryTextBox.TabIndex = 0;
            this.HistoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 274);
            this.Controls.Add(this.OpeDivideButton);
            this.Controls.Add(this.OpeMultiButton);
            this.Controls.Add(this.OpeMinusButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OpeEqualButton);
            this.Controls.Add(this.OpePlusButton);
            this.Controls.Add(this.NumDotButton);
            this.Controls.Add(this.Num3Button);
            this.Controls.Add(this.Num6Button);
            this.Controls.Add(this.Num9Button);
            this.Controls.Add(this.Num2Button);
            this.Controls.Add(this.Num5Button);
            this.Controls.Add(this.Num8Button);
            this.Controls.Add(this.Num0Button);
            this.Controls.Add(this.Num1Button);
            this.Controls.Add(this.Num4Button);
            this.Controls.Add(this.Num7Button);
            this.Controls.Add(this.HistoryTextBox);
            this.Controls.Add(this.ResultTextBox);
            this.Name = "CalculatorForm";
            this.Text = "計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button Num7Button;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Button NumDotButton;
        private System.Windows.Forms.Button OpePlusButton;
        private System.Windows.Forms.Button OpeMinusButton;
        private System.Windows.Forms.Button OpeMultiButton;
        private System.Windows.Forms.Button OpeDivideButton;
        private System.Windows.Forms.Button OpeEqualButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox HistoryTextBox;

    }
}

