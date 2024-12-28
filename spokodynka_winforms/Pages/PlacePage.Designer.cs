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
            label1 = new Label();
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
            forecastDaysPanel.Location = new Point(569, 0);
            forecastDaysPanel.Name = "forecastDaysPanel";
            forecastDaysPanel.Size = new Size(239, 671);
            forecastDaysPanel.TabIndex = 0;
            // 
            // placePageBackPanel
            // 
            placePageBackPanel.AutoScroll = true;
            placePageBackPanel.Controls.Add(label1);
            placePageBackPanel.Controls.Add(hourlyForecastPanel);
            placePageBackPanel.Controls.Add(currentWeatherPanel);
            placePageBackPanel.Controls.Add(placePageName);
            placePageBackPanel.Dock = DockStyle.Fill;
            placePageBackPanel.Location = new Point(0, 0);
            placePageBackPanel.Name = "placePageBackPanel";
            placePageBackPanel.Size = new Size(569, 671);
            placePageBackPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 408);
            label1.Name = "label1";
            label1.Size = new Size(284, 252);
            label1.TabIndex = 5;
            label1.Text = "\r\nPrędkość wiatru:\r\n\r\nOpady:\r\n\r\nWilgotność:\r\n\r\nCiśnienie:\r\n\r\n";
            // 
            // hourlyForecastPanel
            // 
            hourlyForecastPanel.AutoScroll = true;
            hourlyForecastPanel.Dock = DockStyle.Top;
            hourlyForecastPanel.Location = new Point(0, 258);
            hourlyForecastPanel.Name = "hourlyForecastPanel";
            hourlyForecastPanel.Size = new Size(569, 150);
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
            currentWeatherPanel.Location = new Point(0, 108);
            currentWeatherPanel.Name = "currentWeatherPanel";
            currentWeatherPanel.RowCount = 1;
            currentWeatherPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            currentWeatherPanel.Size = new Size(569, 150);
            currentWeatherPanel.TabIndex = 3;
            // 
            // currentWeatherPicture
            // 
            currentWeatherPicture.BackgroundImage = Spokodynka_gui.Properties.Resources.sun;
            currentWeatherPicture.BackgroundImageLayout = ImageLayout.Stretch;
            currentWeatherPicture.Dock = DockStyle.Right;
            currentWeatherPicture.Location = new Point(131, 3);
            currentWeatherPicture.Name = "currentWeatherPicture";
            currentWeatherPicture.Size = new Size(150, 144);
            currentWeatherPicture.TabIndex = 1;
            currentWeatherPicture.TabStop = false;
            // 
            // currentTempLabel
            // 
            currentTempLabel.Dock = DockStyle.Left;
            currentTempLabel.Font = new Font("Lucida Sans", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentTempLabel.ForeColor = Color.WhiteSmoke;
            currentTempLabel.Location = new Point(287, 0);
            currentTempLabel.Name = "currentTempLabel";
            currentTempLabel.Size = new Size(150, 150);
            currentTempLabel.TabIndex = 0;
            currentTempLabel.Text = "0,0°C";
            currentTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placePageName
            // 
            placePageName.Dock = DockStyle.Top;
            placePageName.Font = new Font("Lucida Sans", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placePageName.ForeColor = Color.WhiteSmoke;
            placePageName.Location = new Point(0, 0);
            placePageName.Name = "placePageName";
            placePageName.Padding = new Padding(0, 20, 0, 0);
            placePageName.Size = new Size(569, 108);
            placePageName.TabIndex = 2;
            placePageName.Text = "Miasto";
            placePageName.TextAlign = ContentAlignment.TopCenter;
            // 
            // PlacePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(placePageBackPanel);
            Controls.Add(forecastDaysPanel);
            Name = "PlacePage";
            Size = new Size(808, 671);
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
        private Label label1;
    }
}
