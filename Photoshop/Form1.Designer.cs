namespace Photoshop
{
    partial class FormPhotoShop
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
            this.labelWidthHeader = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeightHeader = new System.Windows.Forms.Label();
            this.groupBoxFrame = new System.Windows.Forms.GroupBox();
            this.radioButtonFramed = new System.Windows.Forms.RadioButton();
            this.radioButtonMatted = new System.Windows.Forms.RadioButton();
            this.radioButtonUnframed = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonSteel = new System.Windows.Forms.RadioButton();
            this.radioButtonOak = new System.Windows.Forms.RadioButton();
            this.radioButtonPine = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonEclectic = new System.Windows.Forms.RadioButton();
            this.radioButtonVintage = new System.Windows.Forms.RadioButton();
            this.radioButtonAntique = new System.Windows.Forms.RadioButton();
            this.radioButtonModern = new System.Windows.Forms.RadioButton();
            this.radioButtonSimple = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelCostQuote = new System.Windows.Forms.Label();
            this.labelOrderDescription = new System.Windows.Forms.Label();
            this.groupBoxFrame.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWidthHeader
            // 
            this.labelWidthHeader.Location = new System.Drawing.Point(20, 28);
            this.labelWidthHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWidthHeader.Name = "labelWidthHeader";
            this.labelWidthHeader.Size = new System.Drawing.Size(128, 38);
            this.labelWidthHeader.TabIndex = 12;
            this.labelWidthHeader.Text = "Width (in)";
            this.labelWidthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(128, 40);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(386, 26);
            this.textBoxWidth.TabIndex = 0;
            // 
            // labelHeightHeader
            // 
            this.labelHeightHeader.Location = new System.Drawing.Point(20, 83);
            this.labelHeightHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHeightHeader.Name = "labelHeightHeader";
            this.labelHeightHeader.Size = new System.Drawing.Size(128, 38);
            this.labelHeightHeader.TabIndex = 11;
            this.labelHeightHeader.Text = "Height (in)";
            this.labelHeightHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxFrame
            // 
            this.groupBoxFrame.Controls.Add(this.radioButtonFramed);
            this.groupBoxFrame.Controls.Add(this.radioButtonMatted);
            this.groupBoxFrame.Controls.Add(this.radioButtonUnframed);
            this.groupBoxFrame.Location = new System.Drawing.Point(24, 180);
            this.groupBoxFrame.Name = "groupBoxFrame";
            this.groupBoxFrame.Size = new System.Drawing.Size(490, 125);
            this.groupBoxFrame.TabIndex = 2;
            this.groupBoxFrame.TabStop = false;
            this.groupBoxFrame.Text = "Frame";
            // 
            // radioButtonFramed
            // 
            this.radioButtonFramed.AutoSize = true;
            this.radioButtonFramed.Location = new System.Drawing.Point(3, 80);
            this.radioButtonFramed.Name = "radioButtonFramed";
            this.radioButtonFramed.Size = new System.Drawing.Size(85, 23);
            this.radioButtonFramed.TabIndex = 2;
            this.radioButtonFramed.TabStop = true;
            this.radioButtonFramed.Text = "Framed";
            this.radioButtonFramed.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatted
            // 
            this.radioButtonMatted.AutoSize = true;
            this.radioButtonMatted.Location = new System.Drawing.Point(3, 51);
            this.radioButtonMatted.Name = "radioButtonMatted";
            this.radioButtonMatted.Size = new System.Drawing.Size(78, 23);
            this.radioButtonMatted.TabIndex = 1;
            this.radioButtonMatted.TabStop = true;
            this.radioButtonMatted.Text = "Matted";
            this.radioButtonMatted.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnframed
            // 
            this.radioButtonUnframed.AutoSize = true;
            this.radioButtonUnframed.Location = new System.Drawing.Point(3, 22);
            this.radioButtonUnframed.Name = "radioButtonUnframed";
            this.radioButtonUnframed.Size = new System.Drawing.Size(102, 23);
            this.radioButtonUnframed.TabIndex = 0;
            this.radioButtonUnframed.TabStop = true;
            this.radioButtonUnframed.Text = "Unframed";
            this.radioButtonUnframed.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(24, 333);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(124, 177);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(3, 138);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(70, 23);
            this.radioButtonWhite.TabIndex = 4;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(3, 109);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(62, 23);
            this.radioButtonBlue.TabIndex = 3;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(3, 80);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(73, 23);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(3, 51);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(58, 23);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(3, 22);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(70, 23);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.radioButtonGold);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSilver);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSteel);
            this.groupBoxMaterial.Controls.Add(this.radioButtonOak);
            this.groupBoxMaterial.Controls.Add(this.radioButtonPine);
            this.groupBoxMaterial.Location = new System.Drawing.Point(208, 333);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(124, 177);
            this.groupBoxMaterial.TabIndex = 4;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(3, 138);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(63, 23);
            this.radioButtonGold.TabIndex = 4;
            this.radioButtonGold.TabStop = true;
            this.radioButtonGold.Text = "Gold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(3, 109);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(70, 23);
            this.radioButtonSilver.TabIndex = 3;
            this.radioButtonSilver.TabStop = true;
            this.radioButtonSilver.Text = "Silver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonSteel
            // 
            this.radioButtonSteel.AutoSize = true;
            this.radioButtonSteel.Location = new System.Drawing.Point(3, 80);
            this.radioButtonSteel.Name = "radioButtonSteel";
            this.radioButtonSteel.Size = new System.Drawing.Size(65, 23);
            this.radioButtonSteel.TabIndex = 2;
            this.radioButtonSteel.TabStop = true;
            this.radioButtonSteel.Text = "Steel";
            this.radioButtonSteel.UseVisualStyleBackColor = true;
            // 
            // radioButtonOak
            // 
            this.radioButtonOak.AutoSize = true;
            this.radioButtonOak.Location = new System.Drawing.Point(3, 51);
            this.radioButtonOak.Name = "radioButtonOak";
            this.radioButtonOak.Size = new System.Drawing.Size(57, 23);
            this.radioButtonOak.TabIndex = 1;
            this.radioButtonOak.TabStop = true;
            this.radioButtonOak.Text = "Oak";
            this.radioButtonOak.UseVisualStyleBackColor = true;
            // 
            // radioButtonPine
            // 
            this.radioButtonPine.AutoSize = true;
            this.radioButtonPine.Location = new System.Drawing.Point(3, 22);
            this.radioButtonPine.Name = "radioButtonPine";
            this.radioButtonPine.Size = new System.Drawing.Size(61, 23);
            this.radioButtonPine.TabIndex = 0;
            this.radioButtonPine.TabStop = true;
            this.radioButtonPine.Text = "Pine";
            this.radioButtonPine.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.radioButtonEclectic);
            this.groupBoxStyle.Controls.Add(this.radioButtonVintage);
            this.groupBoxStyle.Controls.Add(this.radioButtonAntique);
            this.groupBoxStyle.Controls.Add(this.radioButtonModern);
            this.groupBoxStyle.Controls.Add(this.radioButtonSimple);
            this.groupBoxStyle.Location = new System.Drawing.Point(390, 333);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(124, 177);
            this.groupBoxStyle.TabIndex = 5;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // radioButtonEclectic
            // 
            this.radioButtonEclectic.AutoSize = true;
            this.radioButtonEclectic.Location = new System.Drawing.Point(3, 138);
            this.radioButtonEclectic.Name = "radioButtonEclectic";
            this.radioButtonEclectic.Size = new System.Drawing.Size(87, 23);
            this.radioButtonEclectic.TabIndex = 4;
            this.radioButtonEclectic.TabStop = true;
            this.radioButtonEclectic.Text = "Eclectic";
            this.radioButtonEclectic.UseVisualStyleBackColor = true;
            // 
            // radioButtonVintage
            // 
            this.radioButtonVintage.AutoSize = true;
            this.radioButtonVintage.Location = new System.Drawing.Point(3, 109);
            this.radioButtonVintage.Name = "radioButtonVintage";
            this.radioButtonVintage.Size = new System.Drawing.Size(85, 23);
            this.radioButtonVintage.TabIndex = 3;
            this.radioButtonVintage.TabStop = true;
            this.radioButtonVintage.Text = "Vintage";
            this.radioButtonVintage.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntique
            // 
            this.radioButtonAntique.AutoSize = true;
            this.radioButtonAntique.Location = new System.Drawing.Point(3, 80);
            this.radioButtonAntique.Name = "radioButtonAntique";
            this.radioButtonAntique.Size = new System.Drawing.Size(86, 23);
            this.radioButtonAntique.TabIndex = 2;
            this.radioButtonAntique.TabStop = true;
            this.radioButtonAntique.Text = "Antique";
            this.radioButtonAntique.UseVisualStyleBackColor = true;
            // 
            // radioButtonModern
            // 
            this.radioButtonModern.AutoSize = true;
            this.radioButtonModern.Location = new System.Drawing.Point(3, 51);
            this.radioButtonModern.Name = "radioButtonModern";
            this.radioButtonModern.Size = new System.Drawing.Size(85, 23);
            this.radioButtonModern.TabIndex = 1;
            this.radioButtonModern.TabStop = true;
            this.radioButtonModern.Text = "Modern";
            this.radioButtonModern.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimple
            // 
            this.radioButtonSimple.AutoSize = true;
            this.radioButtonSimple.Location = new System.Drawing.Point(3, 22);
            this.radioButtonSimple.Name = "radioButtonSimple";
            this.radioButtonSimple.Size = new System.Drawing.Size(79, 23);
            this.radioButtonSimple.TabIndex = 0;
            this.radioButtonSimple.TabStop = true;
            this.radioButtonSimple.Text = "Simple";
            this.radioButtonSimple.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(31, 529);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(125, 34);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(208, 582);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 34);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(390, 582);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(128, 95);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(387, 26);
            this.textBoxHeight.TabIndex = 1;
            // 
            // labelCostQuote
            // 
            this.labelCostQuote.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostQuote.Location = new System.Drawing.Point(265, 525);
            this.labelCostQuote.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCostQuote.Name = "labelCostQuote";
            this.labelCostQuote.Size = new System.Drawing.Size(250, 38);
            this.labelCostQuote.TabIndex = 10;
            this.labelCostQuote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrderDescription
            // 
            this.labelOrderDescription.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDescription.Location = new System.Drawing.Point(18, 631);
            this.labelOrderDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOrderDescription.Name = "labelOrderDescription";
            this.labelOrderDescription.Size = new System.Drawing.Size(497, 38);
            this.labelOrderDescription.TabIndex = 9;
            this.labelOrderDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPhotoShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(542, 689);
            this.Controls.Add(this.labelOrderDescription);
            this.Controls.Add(this.labelCostQuote);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxFrame);
            this.Controls.Add(this.labelHeightHeader);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelWidthHeader);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormPhotoShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photoshop";
            this.groupBoxFrame.ResumeLayout(false);
            this.groupBoxFrame.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWidthHeader;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelHeightHeader;
        private System.Windows.Forms.GroupBox groupBoxFrame;
        private System.Windows.Forms.RadioButton radioButtonFramed;
        private System.Windows.Forms.RadioButton radioButtonMatted;
        private System.Windows.Forms.RadioButton radioButtonUnframed;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonSteel;
        private System.Windows.Forms.RadioButton radioButtonOak;
        private System.Windows.Forms.RadioButton radioButtonPine;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonEclectic;
        private System.Windows.Forms.RadioButton radioButtonVintage;
        private System.Windows.Forms.RadioButton radioButtonAntique;
        private System.Windows.Forms.RadioButton radioButtonModern;
        private System.Windows.Forms.RadioButton radioButtonSimple;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelCostQuote;
        private System.Windows.Forms.Label labelOrderDescription;
    }
}

