namespace WindowsFormsApps
{
    partial class PizzaApp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbChilies = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbMashroom = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblToppingsText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblCrustTypeText = new System.Windows.Forms.Label();
            this.lblSizeText = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeAway = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrderPizze = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(44, 68);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(111, 148);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(7, 104);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(80, 24);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "15";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(7, 65);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(96, 24);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "11";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 25);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(78, 24);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "8";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(44, 243);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(142, 117);
            this.gbCrustType.TabIndex = 4;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(7, 74);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(124, 24);
            this.rbThickCrust.TabIndex = 6;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "2";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(7, 35);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(116, 24);
            this.rbThinCrust.TabIndex = 5;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbChilies);
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbMashroom);
            this.gbToppings.Controls.Add(this.chbTomatoes);
            this.gbToppings.Controls.Add(this.chbExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(248, 68);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(317, 148);
            this.gbToppings.TabIndex = 8;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbChilies
            // 
            this.chbChilies.AutoSize = true;
            this.chbChilies.Location = new System.Drawing.Point(184, 105);
            this.chbChilies.Name = "chbChilies";
            this.chbChilies.Size = new System.Drawing.Size(88, 24);
            this.chbChilies.TabIndex = 14;
            this.chbChilies.Tag = "1";
            this.chbChilies.Text = "Chilies";
            this.chbChilies.UseVisualStyleBackColor = true;
            this.chbChilies.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(184, 66);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(82, 24);
            this.chbOnion.TabIndex = 13;
            this.chbOnion.Tag = "1";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(184, 26);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(83, 24);
            this.chbOlives.TabIndex = 12;
            this.chbOlives.Tag = "1";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // chbMashroom
            // 
            this.chbMashroom.AutoSize = true;
            this.chbMashroom.Location = new System.Drawing.Point(7, 105);
            this.chbMashroom.Name = "chbMashroom";
            this.chbMashroom.Size = new System.Drawing.Size(118, 24);
            this.chbMashroom.TabIndex = 11;
            this.chbMashroom.Tag = "1";
            this.chbMashroom.Text = "Mashroom";
            this.chbMashroom.UseVisualStyleBackColor = true;
            this.chbMashroom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(7, 65);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(114, 24);
            this.chbTomatoes.TabIndex = 10;
            this.chbTomatoes.Tag = "1";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // chbExtraCheese
            // 
            this.chbExtraCheese.AutoSize = true;
            this.chbExtraCheese.Location = new System.Drawing.Point(7, 26);
            this.chbExtraCheese.Name = "chbExtraCheese";
            this.chbExtraCheese.Size = new System.Drawing.Size(138, 24);
            this.chbExtraCheese.TabIndex = 9;
            this.chbExtraCheese.Tag = "1";
            this.chbExtraCheese.Text = "ExtraCheese";
            this.chbExtraCheese.UseVisualStyleBackColor = true;
            this.chbExtraCheese.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lblToppingsText);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.lblWhereToEat);
            this.gbSummary.Controls.Add(this.lblCrustType);
            this.gbSummary.Controls.Add(this.lblCrustTypeText);
            this.gbSummary.Controls.Add(this.lblSizeText);
            this.gbSummary.Controls.Add(this.lblSize);
            this.gbSummary.Location = new System.Drawing.Point(608, 68);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(246, 297);
            this.gbSummary.TabIndex = 18;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary";
            // 
            // lblToppingsText
            // 
            this.lblToppingsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToppingsText.Location = new System.Drawing.Point(46, 198);
            this.lblToppingsText.Name = "lblToppingsText";
            this.lblToppingsText.Size = new System.Drawing.Size(170, 80);
            this.lblToppingsText.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Toppings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Where To Eat: ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(117, 128);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(0, 20);
            this.lblWhereToEat.TabIndex = 24;
            // 
            // lblCrustType
            // 
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Peru;
            this.lblCrustType.Location = new System.Drawing.Point(7, 69);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(103, 20);
            this.lblCrustType.TabIndex = 21;
            this.lblCrustType.Text = "Crust Type: ";
            // 
            // lblCrustTypeText
            // 
            this.lblCrustTypeText.AutoSize = true;
            this.lblCrustTypeText.Location = new System.Drawing.Point(117, 70);
            this.lblCrustTypeText.Name = "lblCrustTypeText";
            this.lblCrustTypeText.Size = new System.Drawing.Size(0, 20);
            this.lblCrustTypeText.TabIndex = 22;
            // 
            // lblSizeText
            // 
            this.lblSizeText.AutoSize = true;
            this.lblSizeText.Location = new System.Drawing.Point(117, 30);
            this.lblSizeText.Name = "lblSizeText";
            this.lblSizeText.Size = new System.Drawing.Size(0, 20);
            this.lblSizeText.TabIndex = 20;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Peru;
            this.lblSize.Location = new System.Drawing.Point(7, 29);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(73, 26);
            this.lblSize.TabIndex = 19;
            this.lblSize.Text = "Size: ";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeAway);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.label1);
            this.gbWhereToEat.Controls.Add(this.label2);
            this.gbWhereToEat.Location = new System.Drawing.Point(242, 243);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(317, 65);
            this.gbWhereToEat.TabIndex = 15;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeAway
            // 
            this.rbTakeAway.AutoSize = true;
            this.rbTakeAway.Location = new System.Drawing.Point(184, 35);
            this.rbTakeAway.Name = "rbTakeAway";
            this.rbTakeAway.Size = new System.Drawing.Size(118, 24);
            this.rbTakeAway.TabIndex = 18;
            this.rbTakeAway.TabStop = true;
            this.rbTakeAway.Tag = "0";
            this.rbTakeAway.Text = "Take away";
            this.rbTakeAway.UseVisualStyleBackColor = true;
            this.rbTakeAway.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(7, 35);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(83, 24);
            this.rbEatIn.TabIndex = 16;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "1";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Option_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // btnOrderPizze
            // 
            this.btnOrderPizze.Location = new System.Drawing.Point(242, 378);
            this.btnOrderPizze.Name = "btnOrderPizze";
            this.btnOrderPizze.Size = new System.Drawing.Size(136, 33);
            this.btnOrderPizze.TabIndex = 29;
            this.btnOrderPizze.Text = "OrderPizze";
            this.btnOrderPizze.UseVisualStyleBackColor = true;
            this.btnOrderPizze.Click += new System.EventHandler(this.btnOrderPizze_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(423, 379);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 33);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(603, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPrice.Location = new System.Drawing.Point(702, 404);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 37);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "$ 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(258, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 46);
            this.label5.TabIndex = 31;
            this.label5.Text = "Make Pizza Order!";
            // 
            // PizzaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrderPizze);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "PizzaApp";
            this.Text = "Pizza Order!";
            this.Load += new System.EventHandler(this.PizzaApp_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbChilies;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbMashroom;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbExtraCheese;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblCrustTypeText;
        private System.Windows.Forms.Label lblSizeText;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToppingsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderPizze;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton rbTakeAway;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label label5;
    }
}