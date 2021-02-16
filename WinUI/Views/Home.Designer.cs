namespace ExamenSGS.WinUI.Views
{
    partial class HomeForm
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
            this.infoRequiredGroup = new System.Windows.Forms.GroupBox();
            this.resultYearLabel = new System.Windows.Forms.Label();
            this.birthdateText = new System.Windows.Forms.DateTimePicker();
            this.desireAgeLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.calculateYearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultAverageLabel = new System.Windows.Forms.Label();
            this.endNumberLabel = new System.Windows.Forms.Label();
            this.startNumberLabel = new System.Windows.Forms.Label();
            this.calculateAverageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.desireAgeText = new System.Windows.Forms.TextBox();
            this.startNumberText = new System.Windows.Forms.TextBox();
            this.endNumberText = new System.Windows.Forms.TextBox();
            this.errorMessageYearLabel = new System.Windows.Forms.Label();
            this.errorMessageEndLabel = new System.Windows.Forms.Label();
            this.errorMessageStartLabel = new System.Windows.Forms.Label();
            this.infoRequiredGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoRequiredGroup
            // 
            this.infoRequiredGroup.Controls.Add(this.errorMessageYearLabel);
            this.infoRequiredGroup.Controls.Add(this.desireAgeText);
            this.infoRequiredGroup.Controls.Add(this.resultYearLabel);
            this.infoRequiredGroup.Controls.Add(this.birthdateText);
            this.infoRequiredGroup.Controls.Add(this.desireAgeLabel);
            this.infoRequiredGroup.Controls.Add(this.birthdateLabel);
            this.infoRequiredGroup.Controls.Add(this.calculateYearButton);
            this.infoRequiredGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoRequiredGroup.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoRequiredGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoRequiredGroup.Location = new System.Drawing.Point(13, 14);
            this.infoRequiredGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoRequiredGroup.Name = "infoRequiredGroup";
            this.infoRequiredGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoRequiredGroup.Size = new System.Drawing.Size(361, 342);
            this.infoRequiredGroup.TabIndex = 2;
            this.infoRequiredGroup.TabStop = false;
            this.infoRequiredGroup.Text = "Calcular año de cumpleaños";
            // 
            // resultYearLabel
            // 
            this.resultYearLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultYearLabel.Location = new System.Drawing.Point(86, 185);
            this.resultYearLabel.Name = "resultYearLabel";
            this.resultYearLabel.Size = new System.Drawing.Size(231, 50);
            this.resultYearLabel.TabIndex = 16;
            this.resultYearLabel.Text = "[resultado]";
            this.resultYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthdateText
            // 
            this.birthdateText.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateText.Location = new System.Drawing.Point(160, 60);
            this.birthdateText.Name = "birthdateText";
            this.birthdateText.Size = new System.Drawing.Size(157, 25);
            this.birthdateText.TabIndex = 15;
            this.birthdateText.Value = new System.DateTime(1970, 1, 1, 11, 13, 0, 0);
            // 
            // desireAgeLabel
            // 
            this.desireAgeLabel.AutoSize = true;
            this.desireAgeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desireAgeLabel.Location = new System.Drawing.Point(49, 122);
            this.desireAgeLabel.Name = "desireAgeLabel";
            this.desireAgeLabel.Size = new System.Drawing.Size(102, 20);
            this.desireAgeLabel.TabIndex = 2;
            this.desireAgeLabel.Text = "Edad deseada:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(38, 65);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(113, 20);
            this.birthdateLabel.TabIndex = 0;
            this.birthdateLabel.Text = "F. de nacimiento:";
            // 
            // calculateYearButton
            // 
            this.calculateYearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(174)))), ((int)(((byte)(247)))));
            this.calculateYearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateYearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(174)))), ((int)(((byte)(247)))));
            this.calculateYearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.calculateYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateYearButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateYearButton.ForeColor = System.Drawing.Color.White;
            this.calculateYearButton.Location = new System.Drawing.Point(42, 265);
            this.calculateYearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calculateYearButton.Name = "calculateYearButton";
            this.calculateYearButton.Size = new System.Drawing.Size(275, 46);
            this.calculateYearButton.TabIndex = 12;
            this.calculateYearButton.Text = "Calcular";
            this.calculateYearButton.UseVisualStyleBackColor = false;
            this.calculateYearButton.Click += new System.EventHandler(this.calculateYearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorMessageStartLabel);
            this.groupBox1.Controls.Add(this.errorMessageEndLabel);
            this.groupBox1.Controls.Add(this.endNumberText);
            this.groupBox1.Controls.Add(this.startNumberText);
            this.groupBox1.Controls.Add(this.resultAverageLabel);
            this.groupBox1.Controls.Add(this.endNumberLabel);
            this.groupBox1.Controls.Add(this.startNumberLabel);
            this.groupBox1.Controls.Add(this.calculateAverageButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(442, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(353, 342);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promedio de números";
            // 
            // resultAverageLabel
            // 
            this.resultAverageLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultAverageLabel.Location = new System.Drawing.Point(64, 185);
            this.resultAverageLabel.Name = "resultAverageLabel";
            this.resultAverageLabel.Size = new System.Drawing.Size(220, 50);
            this.resultAverageLabel.TabIndex = 16;
            this.resultAverageLabel.Text = "[resultado]";
            this.resultAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endNumberLabel
            // 
            this.endNumberLabel.AutoSize = true;
            this.endNumberLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endNumberLabel.Location = new System.Drawing.Point(56, 121);
            this.endNumberLabel.Name = "endNumberLabel";
            this.endNumberLabel.Size = new System.Drawing.Size(41, 20);
            this.endNumberLabel.TabIndex = 2;
            this.endNumberLabel.Text = "Final:";
            // 
            // startNumberLabel
            // 
            this.startNumberLabel.AutoSize = true;
            this.startNumberLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNumberLabel.Location = new System.Drawing.Point(53, 66);
            this.startNumberLabel.Name = "startNumberLabel";
            this.startNumberLabel.Size = new System.Drawing.Size(44, 20);
            this.startNumberLabel.TabIndex = 0;
            this.startNumberLabel.Text = "Inicio:";
            // 
            // calculateAverageButton
            // 
            this.calculateAverageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateAverageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(174)))), ((int)(((byte)(247)))));
            this.calculateAverageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateAverageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(174)))), ((int)(((byte)(247)))));
            this.calculateAverageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.calculateAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateAverageButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateAverageButton.ForeColor = System.Drawing.Color.White;
            this.calculateAverageButton.Location = new System.Drawing.Point(57, 265);
            this.calculateAverageButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calculateAverageButton.Name = "calculateAverageButton";
            this.calculateAverageButton.Size = new System.Drawing.Size(227, 46);
            this.calculateAverageButton.TabIndex = 12;
            this.calculateAverageButton.Text = "Promediar";
            this.calculateAverageButton.UseVisualStyleBackColor = false;
            this.calculateAverageButton.Click += new System.EventHandler(this.calculateAverageButton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 342);
            this.label2.TabIndex = 17;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desireAgeText
            // 
            this.desireAgeText.Location = new System.Drawing.Point(160, 121);
            this.desireAgeText.Name = "desireAgeText";
            this.desireAgeText.Size = new System.Drawing.Size(157, 25);
            this.desireAgeText.TabIndex = 17;
            this.desireAgeText.Text = "1";
            // 
            // startNumberText
            // 
            this.startNumberText.Location = new System.Drawing.Point(112, 66);
            this.startNumberText.Name = "startNumberText";
            this.startNumberText.Size = new System.Drawing.Size(172, 25);
            this.startNumberText.TabIndex = 18;
            this.startNumberText.Text = "1";
            // 
            // endNumberText
            // 
            this.endNumberText.Location = new System.Drawing.Point(112, 121);
            this.endNumberText.Name = "endNumberText";
            this.endNumberText.Size = new System.Drawing.Size(172, 25);
            this.endNumberText.TabIndex = 19;
            this.endNumberText.Text = "1";
            // 
            // errorMessageYearLabel
            // 
            this.errorMessageYearLabel.AutoSize = true;
            this.errorMessageYearLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorMessageYearLabel.Location = new System.Drawing.Point(157, 149);
            this.errorMessageYearLabel.Name = "errorMessageYearLabel";
            this.errorMessageYearLabel.Size = new System.Drawing.Size(95, 20);
            this.errorMessageYearLabel.TabIndex = 18;
            this.errorMessageYearLabel.Text = "[error message]";
            // 
            // errorMessageEndLabel
            // 
            this.errorMessageEndLabel.AutoSize = true;
            this.errorMessageEndLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorMessageEndLabel.Location = new System.Drawing.Point(108, 149);
            this.errorMessageEndLabel.Name = "errorMessageEndLabel";
            this.errorMessageEndLabel.Size = new System.Drawing.Size(95, 20);
            this.errorMessageEndLabel.TabIndex = 19;
            this.errorMessageEndLabel.Text = "[error message]";
            // 
            // errorMessageStartLabel
            // 
            this.errorMessageStartLabel.AutoSize = true;
            this.errorMessageStartLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorMessageStartLabel.Location = new System.Drawing.Point(108, 94);
            this.errorMessageStartLabel.Name = "errorMessageStartLabel";
            this.errorMessageStartLabel.Size = new System.Drawing.Size(95, 20);
            this.errorMessageStartLabel.TabIndex = 20;
            this.errorMessageStartLabel.Text = "[error message]";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoRequiredGroup);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.infoRequiredGroup.ResumeLayout(false);
            this.infoRequiredGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox infoRequiredGroup;
        private System.Windows.Forms.DateTimePicker birthdateText;
        private System.Windows.Forms.Label desireAgeLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Button calculateYearButton;
        private System.Windows.Forms.Label resultYearLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultAverageLabel;
        private System.Windows.Forms.Label endNumberLabel;
        private System.Windows.Forms.Label startNumberLabel;
        private System.Windows.Forms.Button calculateAverageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desireAgeText;
        private System.Windows.Forms.TextBox endNumberText;
        private System.Windows.Forms.TextBox startNumberText;
        private System.Windows.Forms.Label errorMessageYearLabel;
        private System.Windows.Forms.Label errorMessageStartLabel;
        private System.Windows.Forms.Label errorMessageEndLabel;
    }
}