
namespace Igrica
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.Label();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(21, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(299, 42);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Unesite vase ime";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBoxName.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxName.Location = new System.Drawing.Point(29, 72);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(291, 43);
            this.richTextBoxName.TabIndex = 1;
            this.richTextBoxName.Text = "";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonPlay.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPlay.Location = new System.Drawing.Point(68, 158);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(205, 82);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Pokrenite igru ovdje";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igrica.Properties.Resources.backgroundPicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 276);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.Button buttonPlay;
    }
}