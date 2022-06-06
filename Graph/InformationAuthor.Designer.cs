
namespace Graph
{
    partial class InformationAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationAuthor));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label_TextInformation = new System.Windows.Forms.Label();
            this.label_ImageInformation = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label_ImageInformation);
            this.groupBox.Controls.Add(this.label_TextInformation);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(731, 285);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Інформація про автора";
            // 
            // label_TextInformation
            // 
            this.label_TextInformation.AutoSize = true;
            this.label_TextInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_TextInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TextInformation.Location = new System.Drawing.Point(236, 32);
            this.label_TextInformation.Name = "label_TextInformation";
            this.label_TextInformation.Size = new System.Drawing.Size(422, 92);
            this.label_TextInformation.TabIndex = 1;
            this.label_TextInformation.Text = "Програму розробив: Комарницький Євген Олегович\r\nСтудент групи: 525Б\r\nП\'ятий факул" +
    "ьет РЕКСІ\r\nМобільний телефон: +380506215403\r\nПошта: y.komarnytskyi@student.csn.k" +
    "hai.edu";
            // 
            // label_ImageInformation
            // 
            this.label_ImageInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ImageInformation.Image = global::Graph.Properties.Resources.Komarnitskiy;
            this.label_ImageInformation.Location = new System.Drawing.Point(12, 32);
            this.label_ImageInformation.Name = "label_ImageInformation";
            this.label_ImageInformation.Size = new System.Drawing.Size(204, 239);
            this.label_ImageInformation.TabIndex = 2;
            // 
            // InformationAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 285);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(749, 332);
            this.MinimumSize = new System.Drawing.Size(749, 332);
            this.Name = "InformationAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інформація";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label_ImageInformation;
        private System.Windows.Forms.Label label_TextInformation;
    }
}