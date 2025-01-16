namespace spokodynka_winforms
{
    partial class PlacePage
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
            forecastDaysPanel = new Panel();
            placePageBackPanel = new Panel();
            weatherInfoLabel = new Label();
            hourlyForecastPanel = new Panel();
            currentWeatherPanel = new TableLayoutPanel();
            currentWeatherPicture = new PictureBox();
            currentTempLabel = new Label();
            placePageName = new Label();
            placePageBackPanel.SuspendLayout();
            currentWeatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentWeatherPicture).BeginInit();
            SuspendLayout();
            // 
            // forecastDaysPanel
            // 
            forecastDaysPanel.AutoScroll = true;
            forecastDaysPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            forecastDaysPanel.Dock = DockStyle.Right;
            forecastDaysPanel.Location = new Point(455, 0);
            forecastDaysPanel.Margin = new Padding(2);
            forecastDaysPanel.Name = "forecastDaysPanel";
            forecastDaysPanel.Size = new Size(191, 537);
            forecastDaysPanel.TabIndex = 0;
            // 
            // placePageBackPanel
            // 
            placePageBackPanel.AutoScroll = true;
            placePageBackPanel.Controls.Add(weatherInfoLabel);
            placePageBackPanel.Controls.Add(hourlyForecastPanel);
            placePageBackPanel.Controls.Add(currentWeatherPanel);
            placePageBackPanel.Controls.Add(placePageName);
            placePageBackPanel.Dock = DockStyle.Fill;
            placePageBackPanel.Location = new Point(0, 0);
            placePageBackPanel.Margin = new Padding(2);
            placePageBackPanel.Name = "placePageBackPanel";
            placePageBackPanel.Size = new Size(455, 537);
            placePageBackPanel.TabIndex = 2;
            // 
            // weatherInfoLabel
            // 
            weatherInfoLabel.AutoSize = true;
            weatherInfoLabel.Dock = DockStyle.Top;
            weatherInfoLabel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            weatherInfoLabel.ForeColor = Color.WhiteSmoke;
            weatherInfoLabel.Location = new Point(0, 326);
            weatherInfoLabel.Margin = new Padding(2, 0, 2, 0);
            weatherInfoLabel.Name = "weatherInfoLabel";
            weatherInfoLabel.Padding = new Padding(0, 16, 0, 0);
            weatherInfoLabel.Size = new Size(0, 40);
            weatherInfoLabel.TabIndex = 5;
            // 
            // hourlyForecastPanel
            // 
            hourlyForecastPanel.AutoScroll = true;
            hourlyForecastPanel.Dock = DockStyle.Top;
            hourlyForecastPanel.Location = new Point(0, 206);
            hourlyForecastPanel.Margin = new Padding(2);
            hourlyForecastPanel.Name = "hourlyForecastPanel";
            hourlyForecastPanel.Size = new Size(455, 120);
            hourlyForecastPanel.TabIndex = 4;
            // 
            // currentWeatherPanel
            // 
            currentWeatherPanel.ColumnCount = 2;
            currentWeatherPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            currentWeatherPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            currentWeatherPanel.Controls.Add(currentWeatherPicture, 0, 0);
            currentWeatherPanel.Controls.Add(currentTempLabel, 1, 0);
            currentWeatherPanel.Dock = DockStyle.Top;
            currentWeatherPanel.Location = new Point(0, 86);
            currentWeatherPanel.Margin = new Padding(2);
            currentWeatherPanel.Name = "currentWeatherPanel";
            currentWeatherPanel.RowCount = 1;
            currentWeatherPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            currentWeatherPanel.Size = new Size(455, 120);
            currentWeatherPanel.TabIndex = 3;
            // 
            // currentWeatherPicture
            // 
            currentWeatherPicture.BackgroundImage = Spokodynka_gui.Properties.Resources.sun;
            currentWeatherPicture.BackgroundImageLayout = ImageLayout.Stretch;
            currentWeatherPicture.Dock = DockStyle.Right;
            currentWeatherPicture.Location = new Point(105, 2);
            currentWeatherPicture.Margin = new Padding(2);
            currentWeatherPicture.Name = "currentWeatherPicture";
            currentWeatherPicture.Size = new Size(120, 116);
            currentWeatherPicture.TabIndex = 1;
            currentWeatherPicture.TabStop = false;
            // 
            // currentTempLabel
            // 
            currentTempLabel.Dock = DockStyle.Left;
            currentTempLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentTempLabel.ForeColor = Color.WhiteSmoke;
            currentTempLabel.Location = new Point(229, 0);
            currentTempLabel.Margin = new Padding(2, 0, 2, 0);
            currentTempLabel.Name = "currentTempLabel";
            currentTempLabel.Size = new Size(120, 120);
            currentTempLabel.TabIndex = 0;
            currentTempLabel.Text = "0,0°C";
            currentTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placePageName
            // 
            placePageName.Dock = DockStyle.Top;
            placePageName.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placePageName.ForeColor = Color.WhiteSmoke;
            placePageName.Location = new Point(0, 0);
            placePageName.Margin = new Padding(2, 0, 2, 0);
            placePageName.Name = "placePageName";
            placePageName.Padding = new Padding(0, 16, 0, 0);
            placePageName.Size = new Size(455, 86);
            placePageName.TabIndex = 2;
            placePageName.Text = "Miasto";
            placePageName.TextAlign = ContentAlignment.TopCenter;
            // 
            // PlacePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(placePageBackPanel);
            Controls.Add(forecastDaysPanel);
            Margin = new Padding(2);
            Name = "PlacePage";
            Size = new Size(646, 537);
            placePageBackPanel.ResumeLayout(false);
            placePageBackPanel.PerformLayout();
            currentWeatherPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)currentWeatherPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel forecastDaysPanel;
        private Panel placePageBackPanel;
        private Label placePageName;
        private ForecastDayBox forecastBox1;
        private PictureBox currentWeatherPicture;
        private Label currentTempLabel;
        private TableLayoutPanel currentWeatherPanel;
        private Panel hourlyForecastPanel;
        private Label weatherInfoLabel;
    }
}
