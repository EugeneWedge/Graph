
namespace Graph
{
    partial class MethodTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodTests));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Vertex = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Test1 = new System.Windows.Forms.Button();
            this.button_Test2 = new System.Windows.Forms.Button();
            this.button_Test3 = new System.Windows.Forms.Button();
            this.richTextBox_Test = new System.Windows.Forms.RichTextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vertex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість вершин:\r\n";
            // 
            // numericUpDown_Vertex
            // 
            this.numericUpDown_Vertex.Location = new System.Drawing.Point(219, 19);
            this.numericUpDown_Vertex.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_Vertex.Name = "numericUpDown_Vertex";
            this.numericUpDown_Vertex.Size = new System.Drawing.Size(125, 22);
            this.numericUpDown_Vertex.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Test1
            // 
            this.button_Test1.Enabled = false;
            this.button_Test1.Location = new System.Drawing.Point(15, 54);
            this.button_Test1.Name = "button_Test1";
            this.button_Test1.Size = new System.Drawing.Size(72, 56);
            this.button_Test1.TabIndex = 3;
            this.button_Test1.Text = "Test 1";
            this.button_Test1.UseVisualStyleBackColor = true;
            this.button_Test1.Click += new System.EventHandler(this.button_Test1_Click);
            // 
            // button_Test2
            // 
            this.button_Test2.Enabled = false;
            this.button_Test2.Location = new System.Drawing.Point(110, 54);
            this.button_Test2.Name = "button_Test2";
            this.button_Test2.Size = new System.Drawing.Size(72, 56);
            this.button_Test2.TabIndex = 4;
            this.button_Test2.Text = "Test 2";
            this.button_Test2.UseVisualStyleBackColor = true;
            this.button_Test2.Click += new System.EventHandler(this.button_Test2_Click);
            // 
            // button_Test3
            // 
            this.button_Test3.Enabled = false;
            this.button_Test3.Location = new System.Drawing.Point(207, 54);
            this.button_Test3.Name = "button_Test3";
            this.button_Test3.Size = new System.Drawing.Size(72, 56);
            this.button_Test3.TabIndex = 5;
            this.button_Test3.Text = "Test 3";
            this.button_Test3.UseVisualStyleBackColor = true;
            this.button_Test3.Click += new System.EventHandler(this.button_Test3_Click);
            // 
            // richTextBox_Test
            // 
            this.richTextBox_Test.Location = new System.Drawing.Point(15, 129);
            this.richTextBox_Test.Name = "richTextBox_Test";
            this.richTextBox_Test.ReadOnly = true;
            this.richTextBox_Test.Size = new System.Drawing.Size(911, 326);
            this.richTextBox_Test.TabIndex = 6;
            this.richTextBox_Test.Text = "";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(297, 54);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(71, 56);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // MethodTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 467);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.richTextBox_Test);
            this.Controls.Add(this.button_Test3);
            this.Controls.Add(this.button_Test2);
            this.Controls.Add(this.button_Test1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_Vertex);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(956, 514);
            this.MinimumSize = new System.Drawing.Size(956, 514);
            this.Name = "MethodTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MethodTests";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vertex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Vertex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Test1;
        private System.Windows.Forms.Button button_Test2;
        private System.Windows.Forms.Button button_Test3;
        private System.Windows.Forms.RichTextBox richTextBox_Test;
        private System.Windows.Forms.Button button_Clear;
    }
}