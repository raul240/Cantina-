namespace tellinhas_cantina
{
    partial class Form3
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
            listcozinha = new ListBox();
            SuspendLayout();
            // 
            // listcozinha
            // 
            listcozinha.BackColor = SystemColors.InfoText;
            listcozinha.ForeColor = Color.Yellow;
            listcozinha.FormattingEnabled = true;
            listcozinha.ItemHeight = 15;
            listcozinha.Location = new Point(0, 1);
            listcozinha.Name = "listcozinha";
            listcozinha.Size = new Size(547, 94);
            listcozinha.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(listcozinha);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listcozinha;
    }
}