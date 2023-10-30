using System.ComponentModel;

namespace _30_10_23_classwork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            FlowLayoutPanel2 = new FlowLayoutPanel();
            selectImagesButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // FlowLayoutPanel2
            // 
            FlowLayoutPanel2.Dock = DockStyle.Fill;
            FlowLayoutPanel2.Location = new Point(0, 0);
            FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            FlowLayoutPanel2.Size = new Size(800, 450);
            FlowLayoutPanel2.TabIndex = 1;
            
            // 
            // selectImagesButton
            // 
            selectImagesButton.Location = new Point(260, 291);
            selectImagesButton.Name = "selectImagesButton";
            selectImagesButton.Size = new Size(94, 29);
            selectImagesButton.TabIndex = 2;
            selectImagesButton.Text = "Выбрать изображение";
            selectImagesButton.UseVisualStyleBackColor = true;
            selectImagesButton.Click += selectImagesButton_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectImagesButton);
            Controls.Add(FlowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel FlowLayoutPanel2;
        private Button selectImagesButton;
        private OpenFileDialog openFileDialog1;
    }
}