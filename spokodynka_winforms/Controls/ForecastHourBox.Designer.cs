namespace spokodynka_winforms
{
    partial class ForecastHourBox
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
            forecastHourLabel = new Label();
            forecastHourTempLabel = new Label();
            backgroundPanel.SuspendLayout();
            forecastHourLabel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            backgroundPanel.BackColor = Color.FromArgb(100, 255, 255, 255);
            backgroundPanel.Controls.Add(forecastHourLabel);
            backgroundPanel.Location = new Point(3, 3);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(114, 134);
            backgroundPanel.TabIndex = 0;
            // 
            // forecastHourLabel
            // 
            forecastHourLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            forecastHourLabel.BackColor = Color.Transparent;
            forecastHourLabel.Controls.Add(forecastHourTempLabel);
            forecastHourLabel.Font = new Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastHourLabel.ForeColor = Color.WhiteSmoke;
            forecastHourLabel.Location = new Point(0, 0);
            forecastHourLabel.Name = "forecastHourLabel";
            forecastHourLabel.Padding = new Padding(0, 0, 0, 10);
            forecastHourLabel.Size = new Size(114, 134);
            forecastHourLabel.TabIndex = 3;
            forecastHourLabel.Text = "00:00";
            forecastHourLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // forecastHourTempLabel
            // 
            forecastHourTempLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            forecastHourTempLabel.BackColor = Color.Transparent;
            forecastHourTempLabel.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastHourTempLabel.ForeColor = Color.WhiteSmoke;
            forecastHourTempLabel.Location = new Point(0, 0);
            forecastHourTempLabel.Name = "forecastHourTempLabel";
            forecastHourTempLabel.Padding = new Padding(0, 0, 0, 25);
            forecastHourTempLabel.Size = new Size(114, 134);
            forecastHourTempLabel.TabIndex = 2;
            forecastHourTempLabel.Text = "0°C";
            forecastHourTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            forecastHourTempLabel.MouseEnter += forecastHourTempLabel_MouseEnter;
            forecastHourTempLabel.MouseLeave += forecastHourTempLabel_MouseLeave;
            // 
            // ForecastHourBox
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Transparent;
            Controls.Add(backgroundPanel);
            Name = "ForecastHourBox";
            Size = new Size(120, 140);
            backgroundPanel.ResumeLayout(false);
            forecastHourLabel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel backgroundPanel;
        private Label forecastHourTempLabel;
        private Label forecastHourLabel;
    }
}
