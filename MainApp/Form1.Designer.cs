namespace WindowsFormsApps
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTicTacToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "PizzaApp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTicTacToe
            // 
            this.btnTicTacToe.Location = new System.Drawing.Point(108, 162);
            this.btnTicTacToe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTicTacToe.Name = "btnTicTacToe";
            this.btnTicTacToe.Size = new System.Drawing.Size(215, 50);
            this.btnTicTacToe.TabIndex = 1;
            this.btnTicTacToe.Text = "TicTacToe";
            this.btnTicTacToe.UseVisualStyleBackColor = true;
            this.btnTicTacToe.Click += new System.EventHandler(this.btnTicTacToe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 630);
            this.Controls.Add(this.btnTicTacToe);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Peru;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTicTacToe;
    }
}

