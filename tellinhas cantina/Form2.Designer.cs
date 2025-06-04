namespace tellinhas_cantina
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
            listPreparando = new ListBox();
            listEntregue = new ListBox();
            btPronto = new Button();
            SuspendLayout();
            // 
            // listPreparando
            // 
            listPreparando.BackColor = SystemColors.InactiveCaptionText;
            listPreparando.ForeColor = Color.Yellow;
            listPreparando.FormattingEnabled = true;
            listPreparando.ItemHeight = 15;
            listPreparando.Location = new Point(12, 12);
            listPreparando.Name = "listPreparando";
            listPreparando.Size = new Size(830, 94);
            listPreparando.TabIndex = 0;
            listPreparando.SelectedIndexChanged += listPreparando_SelectedIndexChanged;
            // 
            // listEntregue
            // 
            listEntregue.BackColor = SystemColors.InactiveCaptionText;
            listEntregue.ForeColor = Color.Yellow;
            listEntregue.FormattingEnabled = true;
            listEntregue.ItemHeight = 15;
            listEntregue.Location = new Point(12, 140);
            listEntregue.Name = "listEntregue";
            listEntregue.Size = new Size(830, 94);
            listEntregue.TabIndex = 1;
            listEntregue.SelectedIndexChanged += listEntregue_SelectedIndexChanged;
            // 
            // btPronto
            // 
            btPronto.BackColor = Color.Black;
            btPronto.ForeColor = Color.Yellow;
            btPronto.Location = new Point(854, 109);
            btPronto.Name = "btPronto";
            btPronto.Size = new Size(199, 23);
            btPronto.TabIndex = 2;
            btPronto.Text = "pronto";
            btPronto.UseVisualStyleBackColor = false;
            btPronto.Click += btPronto_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1077, 430);
            Controls.Add(btPronto);
            Controls.Add(listEntregue);
            Controls.Add(listPreparando);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listPreparando;
        private ListBox listEntregue;
        private Button btPronto;
    }
}