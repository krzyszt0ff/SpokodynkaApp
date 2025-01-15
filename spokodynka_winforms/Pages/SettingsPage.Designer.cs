namespace Spokodynka_gui.Pages
{
    partial class SettingsPage
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
            settingsPageHeader = new Label();
            mainSettingsPanel = new Panel();
            exportBtn = new Button();
            exportPlaceSelect = new ComboBox();
            label1 = new Label();
            importBtn = new Button();
            importLabel = new Label();
            forecastDaySelect = new ComboBox();
            forecastDayLabel = new Label();
            mainSettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // settingsPageHeader
            // 
            settingsPageHeader.Dock = DockStyle.Top;
            settingsPageHeader.Font = new Font("Lucida Sans", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            settingsPageHeader.ForeColor = Color.WhiteSmoke;
            settingsPageHeader.Location = new Point(0, 0);
            settingsPageHeader.Name = "settingsPageHeader";
            settingsPageHeader.Padding = new Padding(10, 20, 0, 0);
            settingsPageHeader.Size = new Size(803, 86);
            settingsPageHeader.TabIndex = 3;
            settingsPageHeader.Text = "Ustawienia";
            // 
            // mainSettingsPanel
            // 
            mainSettingsPanel.AutoScroll = true;
            mainSettingsPanel.Controls.Add(exportBtn);
            mainSettingsPanel.Controls.Add(exportPlaceSelect);
            mainSettingsPanel.Controls.Add(label1);
            mainSettingsPanel.Controls.Add(importBtn);
            mainSettingsPanel.Controls.Add(importLabel);
            mainSettingsPanel.Controls.Add(forecastDaySelect);
            mainSettingsPanel.Controls.Add(forecastDayLabel);
            mainSettingsPanel.Dock = DockStyle.Fill;
            mainSettingsPanel.Location = new Point(0, 86);
            mainSettingsPanel.Name = "mainSettingsPanel";
            mainSettingsPanel.Padding = new Padding(20, 0, 0, 0);
            mainSettingsPanel.Size = new Size(803, 343);
            mainSettingsPanel.TabIndex = 5;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(542, 96);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(112, 34);
            exportBtn.TabIndex = 8;
            exportBtn.Text = "Eksport";
            exportBtn.UseVisualStyleBackColor = true;
            // 
            // exportPlaceSelect
            // 
            exportPlaceSelect.FormatString = "N0";
            exportPlaceSelect.Location = new Point(408, 96);
            exportPlaceSelect.Name = "exportPlaceSelect";
            exportPlaceSelect.Size = new Size(128, 33);
            exportPlaceSelect.TabIndex = 7;
            exportPlaceSelect.Text = "(miasto)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(23, 87);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(379, 42);
            label1.TabIndex = 6;
            label1.Text = "Wyeksportuj prognozę dla:";
            // 
            // importBtn
            // 
            importBtn.Location = new Point(330, 53);
            importBtn.Name = "importBtn";
            importBtn.Size = new Size(112, 34);
            importBtn.TabIndex = 5;
            importBtn.Text = "Import";
            importBtn.UseVisualStyleBackColor = true;
            importBtn.Click += importBtn_Click;
            // 
            // importLabel
            // 
            importLabel.AutoSize = true;
            importLabel.Font = new Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importLabel.ForeColor = Color.WhiteSmoke;
            importLabel.Location = new Point(23, 45);
            importLabel.Name = "importLabel";
            importLabel.Padding = new Padding(0, 10, 0, 0);
            importLabel.Size = new Size(301, 42);
            importLabel.TabIndex = 4;
            importLabel.Text = "Importuj bazę miast:";
            // 
            // forecastDaySelect
            // 
            forecastDaySelect.FormatString = "N0";
            forecastDaySelect.Location = new Point(304, 9);
            forecastDaySelect.Name = "forecastDaySelect";
            forecastDaySelect.Size = new Size(73, 33);
            forecastDaySelect.TabIndex = 3;
            forecastDaySelect.SelectedIndexChanged += forecastDaySelect_SelectedIndexChanged;
            // 
            // forecastDayLabel
            // 
            forecastDayLabel.AutoSize = true;
            forecastDayLabel.Font = new Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastDayLabel.ForeColor = Color.WhiteSmoke;
            forecastDayLabel.Location = new Point(23, 0);
            forecastDayLabel.Name = "forecastDayLabel";
            forecastDayLabel.Padding = new Padding(0, 10, 0, 0);
            forecastDayLabel.Size = new Size(275, 42);
            forecastDayLabel.TabIndex = 2;
            forecastDayLabel.Text = "Ilość dni prognozy:";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(mainSettingsPanel);
            Controls.Add(settingsPageHeader);
            Margin = new Padding(10, 3, 3, 3);
            Name = "SettingsPage";
            Size = new Size(803, 429);
            mainSettingsPanel.ResumeLayout(false);
            mainSettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label settingsPageHeader;
        private Panel mainSettingsPanel;
        private Label forecastDayLabel;
        private ComboBox forecastDaySelect;
        private Label label1;
        private Button importBtn;
        private Label importLabel;
        private Button exportBtn;
        private ComboBox exportPlaceSelect;
    }
}
