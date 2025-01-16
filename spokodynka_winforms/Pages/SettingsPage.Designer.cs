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
            settingsPageHeader.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            settingsPageHeader.ForeColor = Color.WhiteSmoke;
            settingsPageHeader.Location = new Point(0, 0);
            settingsPageHeader.Margin = new Padding(2, 0, 2, 0);
            settingsPageHeader.Name = "settingsPageHeader";
            settingsPageHeader.Padding = new Padding(8, 16, 0, 0);
            settingsPageHeader.Size = new Size(642, 69);
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
            mainSettingsPanel.Location = new Point(0, 69);
            mainSettingsPanel.Margin = new Padding(2, 2, 2, 2);
            mainSettingsPanel.Name = "mainSettingsPanel";
            mainSettingsPanel.Padding = new Padding(16, 0, 0, 0);
            mainSettingsPanel.Size = new Size(642, 274);
            mainSettingsPanel.TabIndex = 5;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(434, 77);
            exportBtn.Margin = new Padding(2, 2, 2, 2);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(90, 27);
            exportBtn.TabIndex = 8;
            exportBtn.Text = "Eksport";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // exportPlaceSelect
            // 
            exportPlaceSelect.FormatString = "N0";
            exportPlaceSelect.Location = new Point(326, 77);
            exportPlaceSelect.Margin = new Padding(2, 2, 2, 2);
            exportPlaceSelect.Name = "exportPlaceSelect";
            exportPlaceSelect.Size = new Size(103, 28);
            exportPlaceSelect.TabIndex = 7;
            exportPlaceSelect.Text = "(miasto)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(18, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(298, 37);
            label1.TabIndex = 6;
            label1.Text = "Wyeksportuj prognozę dla:";
            // 
            // importBtn
            // 
            importBtn.Location = new Point(264, 42);
            importBtn.Margin = new Padding(2, 2, 2, 2);
            importBtn.Name = "importBtn";
            importBtn.Size = new Size(90, 27);
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
            importLabel.Location = new Point(18, 36);
            importLabel.Margin = new Padding(2, 0, 2, 0);
            importLabel.Name = "importLabel";
            importLabel.Padding = new Padding(0, 8, 0, 0);
            importLabel.Size = new Size(227, 37);
            importLabel.TabIndex = 4;
            importLabel.Text = "Importuj bazę miast:";
            // 
            // forecastDaySelect
            // 
            forecastDaySelect.FormatString = "N0";
            forecastDaySelect.Location = new Point(243, 7);
            forecastDaySelect.Margin = new Padding(2, 2, 2, 2);
            forecastDaySelect.Name = "forecastDaySelect";
            forecastDaySelect.Size = new Size(59, 28);
            forecastDaySelect.TabIndex = 3;
            forecastDaySelect.SelectedIndexChanged += forecastDaySelect_SelectedIndexChanged;
            // 
            // forecastDayLabel
            // 
            forecastDayLabel.AutoSize = true;
            forecastDayLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forecastDayLabel.ForeColor = Color.WhiteSmoke;
            forecastDayLabel.Location = new Point(18, 0);
            forecastDayLabel.Margin = new Padding(2, 0, 2, 0);
            forecastDayLabel.Name = "forecastDayLabel";
            forecastDayLabel.Padding = new Padding(0, 8, 0, 0);
            forecastDayLabel.Size = new Size(213, 37);
            forecastDayLabel.TabIndex = 2;
            forecastDayLabel.Text = "Ilość dni prognozy:";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(mainSettingsPanel);
            Controls.Add(settingsPageHeader);
            Margin = new Padding(8, 2, 2, 2);
            Name = "SettingsPage";
            Size = new Size(642, 343);
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
