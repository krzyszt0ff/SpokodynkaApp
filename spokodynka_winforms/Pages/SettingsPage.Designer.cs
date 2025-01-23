using FileManagement;

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
            exportLabel = new Label();
            importBtn = new Button();
            importLabel = new Label();
            forecastDaySelect = new ComboBox();
            forecastDayLabel = new Label();
            label2 = new Label();
            konieCheckBox = new CheckBox();
            mainSettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // settingsPageHeader
            // 
            settingsPageHeader.Dock = DockStyle.Top;
            settingsPageHeader.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            settingsPageHeader.ForeColor = Color.WhiteSmoke;
            settingsPageHeader.Location = new Point(0, 0);
            settingsPageHeader.Margin = new Padding(2, 0, 2, 0);
            settingsPageHeader.Name = "settingsPageHeader";
            settingsPageHeader.Padding = new Padding(10, 20, 0, 0);
            settingsPageHeader.Size = new Size(802, 86);
            settingsPageHeader.TabIndex = 3;
            settingsPageHeader.Text = "Ustawienia";
            // 
            // mainSettingsPanel
            // 
            mainSettingsPanel.AutoScroll = true;
            mainSettingsPanel.Controls.Add(konieCheckBox);
            mainSettingsPanel.Controls.Add(label2);
            mainSettingsPanel.Controls.Add(exportBtn);
            mainSettingsPanel.Controls.Add(exportPlaceSelect);
            mainSettingsPanel.Controls.Add(exportLabel);
            mainSettingsPanel.Controls.Add(importBtn);
            mainSettingsPanel.Controls.Add(importLabel);
            mainSettingsPanel.Controls.Add(forecastDaySelect);
            mainSettingsPanel.Controls.Add(forecastDayLabel);
            mainSettingsPanel.Dock = DockStyle.Fill;
            mainSettingsPanel.Location = new Point(0, 86);
            mainSettingsPanel.Margin = new Padding(2);
            mainSettingsPanel.Name = "mainSettingsPanel";
            mainSettingsPanel.Padding = new Padding(20, 0, 0, 0);
            mainSettingsPanel.Size = new Size(802, 343);
            mainSettingsPanel.TabIndex = 5;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(542, 96);
            exportBtn.Margin = new Padding(2);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(112, 34);
            exportBtn.TabIndex = 8;
            exportBtn.Text = "Eksport";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // exportPlaceSelect
            // 
            exportPlaceSelect.FormatString = "N0";
            exportPlaceSelect.Location = new Point(408, 96);
            exportPlaceSelect.Margin = new Padding(2);
            exportPlaceSelect.Name = "exportPlaceSelect";
            exportPlaceSelect.Size = new Size(128, 33);
            exportPlaceSelect.TabIndex = 7;
            exportPlaceSelect.Text = "(miasto)";
            // 
            // exportLabel
            // 
            exportLabel.AutoSize = true;
            exportLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportLabel.ForeColor = Color.WhiteSmoke;
            exportLabel.Location = new Point(22, 88);
            exportLabel.Margin = new Padding(2, 0, 2, 0);
            exportLabel.Name = "exportLabel";
            exportLabel.Padding = new Padding(0, 10, 0, 0);
            exportLabel.Size = new Size(295, 42);
            exportLabel.TabIndex = 6;
            exportLabel.Text = "Wyeksportuj dane dla:";
            // 
            // importBtn
            // 
            importBtn.Location = new Point(330, 52);
            importBtn.Margin = new Padding(2);
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
            importLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importLabel.ForeColor = Color.WhiteSmoke;
            importLabel.Location = new Point(22, 45);
            importLabel.Margin = new Padding(2, 0, 2, 0);
            importLabel.Name = "importLabel";
            importLabel.Padding = new Padding(0, 10, 0, 0);
            importLabel.Size = new Size(268, 42);
            importLabel.TabIndex = 4;
            importLabel.Text = "Importuj bazę miast:";
            // 
            // forecastDaySelect
            // 
            forecastDaySelect.FormatString = "N0";
            forecastDaySelect.Location = new Point(304, 9);
            forecastDaySelect.Margin = new Padding(2);
            forecastDaySelect.Name = "forecastDaySelect";
            forecastDaySelect.Size = new Size(73, 33);
            forecastDaySelect.TabIndex = 3;
            forecastDaySelect.SelectedIndexChanged += forecastDaySelect_SelectedIndexChanged;
            // 
            // forecastDayLabel
            // 
            forecastDayLabel.AutoSize = true;
            forecastDayLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastDayLabel.ForeColor = Color.WhiteSmoke;
            forecastDayLabel.Location = new Point(22, 0);
            forecastDayLabel.Margin = new Padding(2, 0, 2, 0);
            forecastDayLabel.Name = "forecastDayLabel";
            forecastDayLabel.Padding = new Padding(0, 10, 0, 0);
            forecastDayLabel.Size = new Size(250, 42);
            forecastDayLabel.TabIndex = 2;
            forecastDayLabel.Text = "Ilość dni prognozy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(613, 75);
            label2.TabIndex = 9;
            label2.Text = "Uwaga!\r\nDla plików .csv oraz .xml eksportujesz dane geolokacyjne wybranego miasta\r\nJeżeli chcesz wyeksportować prognozę, wybierz eksport do pliku .txt";
            // 
            // konieCheckBox
            // 
            konieCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            konieCheckBox.AutoSize = true;
            konieCheckBox.ForeColor = Color.WhiteSmoke;
            konieCheckBox.Location = new Point(671, 309);
            konieCheckBox.Margin = new Padding(5);
            konieCheckBox.Name = "konieCheckBox";
            konieCheckBox.Size = new Size(126, 29);
            konieCheckBox.TabIndex = 10;
            konieCheckBox.Text = "tryb konski";
            konieCheckBox.UseVisualStyleBackColor = true;
            konieCheckBox.CheckedChanged += konieCheckBox_CheckedChanged;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(mainSettingsPanel);
            Controls.Add(settingsPageHeader);
            Margin = new Padding(10, 2, 2, 2);
            Name = "SettingsPage";
            Size = new Size(802, 429);
            mainSettingsPanel.ResumeLayout(false);
            mainSettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label settingsPageHeader;
        private Panel mainSettingsPanel;
        private Label forecastDayLabel;
        private ComboBox forecastDaySelect;
        private Label exportLabel;
        private Button importBtn;
        private Label importLabel;
        private Button exportBtn;
        private ComboBox exportPlaceSelect;
        private Label label2;
        private CheckBox konieCheckBox;
    }
}
