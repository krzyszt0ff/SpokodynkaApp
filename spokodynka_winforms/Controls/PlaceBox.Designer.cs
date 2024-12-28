namespace spokodynka_winforms
{
    partial class PlaceBox
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundPanel = new Panel();
            nameLabel = new Label();
            removeButton = new Label();
            backgroundPanel.SuspendLayout();
            nameLabel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            backgroundPanel.BackColor = Color.Transparent;
            backgroundPanel.Controls.Add(nameLabel);
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(250, 75);
            backgroundPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.BackColor = Color.FromArgb(100, 255, 255, 255);
            nameLabel.Controls.Add(removeButton);
            nameLabel.Font = new Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(5, 5);
            nameLabel.Margin = new Padding(5);
            nameLabel.Name = "nameLabel";
            nameLabel.Padding = new Padding(5);
            nameLabel.Size = new Size(240, 65);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "<miasto>";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            nameLabel.Click += nameLabel_Click;
            nameLabel.MouseDown += nameLabel_MouseDown;
            nameLabel.MouseEnter += nameLabel_MouseEnter;
            nameLabel.MouseLeave += nameLabel_MouseLeave;
            nameLabel.MouseUp += nameLabel_MouseEnter;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Transparent;
            removeButton.Dock = DockStyle.Right;
            removeButton.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeButton.Location = new Point(190, 0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(50, 65);
            removeButton.TabIndex = 1;
            removeButton.Text = "X";
            removeButton.TextAlign = ContentAlignment.MiddleCenter;
            removeButton.Click += removeButton_Click;
            // 
            // PlaceBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(backgroundPanel);
            Name = "PlaceBox";
            Size = new Size(250, 75);
            backgroundPanel.ResumeLayout(false);
            nameLabel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel backgroundPanel;
        private Label nameLabel;
        private Label removeButton;
    }
}
