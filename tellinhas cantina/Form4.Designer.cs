namespace tellinhas_cantina
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
            listchamada = new ListBox();
            SuspendLayout();
            // 
            // listchamada
            // 
            listchamada.BackColor = SystemColors.InfoText;
            listchamada.ForeColor = Color.Yellow;
            listchamada.FormattingEnabled = true;
            listchamada.ItemHeight = 15;
            listchamada.Location = new Point(24, 12);
            listchamada.Name = "listchamada";
            listchamada.Size = new Size(731, 199);
            listchamada.TabIndex = 0;
            listchamada.SelectedIndexChanged += listchamada_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(listchamada);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listchamada;
    }
}