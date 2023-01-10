
namespace Igrica
{
    partial class Form4
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
            this.labelGameOver = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.labelIgricaJeGotova = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGameOver
            // 
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.CausesValidation = false;
            this.labelGameOver.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.White;
            this.labelGameOver.Location = new System.Drawing.Point(-5, 97);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGameOver.Size = new System.Drawing.Size(345, 79);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Pobijedili ste";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonPlayAgain.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(40, 210);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(259, 84);
            this.buttonPlayAgain.TabIndex = 1;
            this.buttonPlayAgain.Text = "Zapocnite novu partiju";
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // labelIgricaJeGotova
            // 
            this.labelIgricaJeGotova.AutoSize = true;
            this.labelIgricaJeGotova.BackColor = System.Drawing.Color.Transparent;
            this.labelIgricaJeGotova.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIgricaJeGotova.ForeColor = System.Drawing.Color.Transparent;
            this.labelIgricaJeGotova.Location = new System.Drawing.Point(34, 36);
            this.labelIgricaJeGotova.Name = "labelIgricaJeGotova";
            this.labelIgricaJeGotova.Size = new System.Drawing.Size(272, 35);
            this.labelIgricaJeGotova.TabIndex = 2;
            this.labelIgricaJeGotova.Text = "Igrica je gotova:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igrica.Properties.Resources.backgroundPicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 337);
            this.Controls.Add(this.labelIgricaJeGotova);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.labelGameOver);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Label labelIgricaJeGotova;
    }
}