namespace spokodynka_winforms
{
    partial class HomePage
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
            titleLabel = new Label();
            sloganLabel = new Label();
            spokoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)spokoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Lucida Sans", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.WhiteSmoke;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(0, 20, 0, 0);
            titleLabel.Size = new Size(810, 100);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Spokodynka";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sloganLabel
            // 
            sloganLabel.BackColor = Color.Transparent;
            sloganLabel.Dock = DockStyle.Top;
            sloganLabel.Font = new Font("Lucida Sans", 20F);
            sloganLabel.ForeColor = Color.WhiteSmoke;
            sloganLabel.Location = new Point(0, 100);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Padding = new Padding(0, 20, 0, 0);
            sloganLabel.Size = new Size(810, 88);
            sloganLabel.TabIndex = 6;
            sloganLabel.Text = "Twoja spoko pogodynka!";
            sloganLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // spokoPictureBox
            // 
            spokoPictureBox.BackgroundImage = Spokodynka_gui.Properties.Resources.spoko;
            spokoPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            spokoPictureBox.Dock = DockStyle.Fill;
            spokoPictureBox.Location = new Point(0, 188);
            spokoPictureBox.Margin = new Padding(10);
            spokoPictureBox.Name = "spokoPictureBox";
            spokoPictureBox.Padding = new Padding(10);
            spokoPictureBox.Size = new Size(810, 308);
            spokoPictureBox.TabIndex = 9;
            spokoPictureBox.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(spokoPictureBox);
            Controls.Add(sloganLabel);
            Controls.Add(titleLabel);
            Name = "HomePage";
            Size = new Size(810, 496);
            ((System.ComponentModel.ISupportInitialize)spokoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label sloganLabel;
        private PictureBox spokoPictureBox;
    }
}
