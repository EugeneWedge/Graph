
namespace Graph
{
    partial class InformationApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationApp));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_DataGridView = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TextInformation = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label_DataGridView);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label_TextInformation);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(747, 552);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Інформація о програме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 74);
            this.label2.TabIndex = 5;
            this.label2.Text = "На матриці суміжності число -1 означає, \r\nщо до цієї вершини не має ребра\r\nПознач" +
    "ка INF також означає, що до\r\nвершини немає ребра\r\n";
            // 
            // label_DataGridView
            // 
            this.label_DataGridView.Image = global::Graph.Properties.Resources.DataGridView;
            this.label_DataGridView.Location = new System.Drawing.Point(12, 294);
            this.label_DataGridView.Name = "label_DataGridView";
            this.label_DataGridView.Size = new System.Drawing.Size(200, 200);
            this.label_DataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 164);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label_TextInformation
            // 
            this.label_TextInformation.AutoSize = true;
            this.label_TextInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_TextInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TextInformation.Location = new System.Drawing.Point(12, 18);
            this.label_TextInformation.Name = "label_TextInformation";
            this.label_TextInformation.Size = new System.Drawing.Size(612, 92);
            this.label_TextInformation.TabIndex = 2;
            this.label_TextInformation.Text = "Програма виконана для порівняння алгоритмів пошуку найкоротших шляхів.\r\nА саме та" +
    "ких алгоритмів як:\r\n- Алгоритм Флойда-Воршелла\r\n- Алгоритм Форда-Беллмана\r\n- Алг" +
    "оритм Дейкстри\r\n";
            // 
            // InformationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 552);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 599);
            this.MinimumSize = new System.Drawing.Size(765, 599);
            this.Name = "InformationApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationApp";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TextInformation;
        private System.Windows.Forms.Label label_DataGridView;
        private System.Windows.Forms.Label label2;
    }
}