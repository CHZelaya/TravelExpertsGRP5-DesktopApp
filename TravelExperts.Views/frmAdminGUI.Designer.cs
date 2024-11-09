
namespace TravelExperts.Views
{
    partial class frmAdminGUI
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
            listBox_Test = new ListBox();
            SuspendLayout();
            // 
            // listBox_Test
            // 
            listBox_Test.FormattingEnabled = true;
            listBox_Test.Location = new Point(62, 48);
            listBox_Test.Name = "listBox_Test";
            listBox_Test.Size = new Size(664, 324);
            listBox_Test.TabIndex = 0;
            // 
            // frmAdminGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_Test);
            Name = "frmAdminGUI";
            Text = "Form1";
            Load += this.frmAdminGUI_Load;
            ResumeLayout(false);
        }



        #endregion

        private ListBox listBox_Test;
    }
}
