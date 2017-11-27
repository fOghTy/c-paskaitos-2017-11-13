namespace _18_1_Pasibandymai
{
    partial class IvestiDuomenisForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.buttonAtsaukti = new System.Windows.Forms.Button();
            this.textBoxVardas = new System.Windows.Forms.TextBox();
            this.textBoxAmzius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amzius";
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(38, 109);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(75, 23);
            this.buttonGerai.TabIndex = 2;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.buttonGerai_Click);
            // 
            // buttonAtsaukti
            // 
            this.buttonAtsaukti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAtsaukti.Location = new System.Drawing.Point(159, 109);
            this.buttonAtsaukti.Name = "buttonAtsaukti";
            this.buttonAtsaukti.Size = new System.Drawing.Size(75, 23);
            this.buttonAtsaukti.TabIndex = 3;
            this.buttonAtsaukti.Text = "Atsaukti";
            this.buttonAtsaukti.UseVisualStyleBackColor = true;
            // 
            // textBoxVardas
            // 
            this.textBoxVardas.Location = new System.Drawing.Point(85, 32);
            this.textBoxVardas.Name = "textBoxVardas";
            this.textBoxVardas.Size = new System.Drawing.Size(149, 20);
            this.textBoxVardas.TabIndex = 4;
            // 
            // textBoxAmzius
            // 
            this.textBoxAmzius.Location = new System.Drawing.Point(85, 70);
            this.textBoxAmzius.Name = "textBoxAmzius";
            this.textBoxAmzius.Size = new System.Drawing.Size(149, 20);
            this.textBoxAmzius.TabIndex = 5;
            // 
            // IvestiDuomenisForma
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAtsaukti;
            this.ClientSize = new System.Drawing.Size(288, 175);
            this.Controls.Add(this.textBoxAmzius);
            this.Controls.Add(this.textBoxVardas);
            this.Controls.Add(this.buttonAtsaukti);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IvestiDuomenisForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IvestiDuomenisForma";
            this.Load += new System.EventHandler(this.IvestiDuomenisForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.Button buttonAtsaukti;
        private System.Windows.Forms.TextBox textBoxVardas;
        private System.Windows.Forms.TextBox textBoxAmzius;
    }
}