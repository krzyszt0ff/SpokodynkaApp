namespace spokodynka_winforms
{
    partial class ForecastDayBox
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
            selectBackgroundPanel = new Panel();
            backgroundPanel = new Panel();
            forecastBoxDateLabel = new Label();
            forecastBoxTempLabel = new Label();
            selectBackgroundPanel.SuspendLayout();
            backgroundPanel.SuspendLayout();
            forecastBoxDateLabel.SuspendLayout();
            SuspendLayout();
            // 
            // selectBackgroundPanel
            // 
            selectBackgroundPanel.Controls.Add(backgroundPanel);
            selectBackgroundPanel.Dock = DockStyle.Fill;
            selectBackgroundPanel.Location = new Point(0, 0);
            selectBackgroundPanel.Margin = new Padding(0);
            selectBackgroundPanel.Name = "selectBackgroundPanel";
            selectBackgroundPanel.Size = new Size(240, 70);
            selectBackgroundPanel.TabIndex = 0;
            // 
            // backgroundPanel
            // 
            backgroundPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            backgroundPanel.BackColor = Color.FromArgb(100, 255, 255, 255);
            backgroundPanel.Controls.Add(forecastBoxDateLabel);
            backgroundPanel.Location = new Point(3, 3);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(234, 64);
            backgroundPanel.TabIndex = 1;
            // 
            // forecastBoxDateLabel
            // 
            forecastBoxDateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            forecastBoxDateLabel.BackColor = Color.Transparent;
            forecastBoxDateLabel.Controls.Add(forecastBoxTempLabel);
            forecastBoxDateLabel.Font = new Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastBoxDateLabel.Location = new Point(0, 0);
            forecastBoxDateLabel.Name = "forecastBoxDateLabel";
            forecastBoxDateLabel.Size = new Size(234, 64);
            forecastBoxDateLabel.TabIndex = 0;
            forecastBoxDateLabel.Text = "Dziś";
            forecastBoxDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // forecastBoxTempLabel
            // 
            forecastBoxTempLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            forecastBoxTempLabel.BackColor = Color.Transparent;
            forecastBoxTempLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastBoxTempLabel.Location = new Point(0, 0);
            forecastBoxTempLabel.Name = "forecastBoxTempLabel";
            forecastBoxTempLabel.Size = new Size(234, 64);
            forecastBoxTempLabel.TabIndex = 1;
            forecastBoxTempLabel.Text = "0° | 0°";
            forecastBoxTempLabel.TextAlign = ContentAlignment.MiddleRight;
            forecastBoxTempLabel.Click += forecastBoxTempLabel_Click;
            forecastBoxTempLabel.MouseDown += forecastBoxTempLabel_MouseDown;
            forecastBoxTempLabel.MouseEnter += forecastBoxTempLabel_MouseEnter;
            forecastBoxTempLabel.MouseLeave += forecastBoxTempLabel_MouseLeave;
            // 
            // ForecastDayBox
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Transparent;
            Controls.Add(selectBackgroundPanel);
            Name = "ForecastDayBox";
            Size = new Size(240, 70);
            selectBackgroundPanel.ResumeLayout(false);
            backgroundPanel.ResumeLayout(false);
            forecastBoxDateLabel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel selectBackgroundPanel;
        private Panel backgroundPanel;
        private Label forecastBoxTempLabel;
        private Label forecastBoxDateLabel;
    }
}
