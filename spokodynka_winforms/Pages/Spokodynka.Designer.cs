namespace spokodynka_winforms
{
    partial class Spokodynka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spokodynka));
            MainSidebarPanel = new Panel();
            PlaceBoxPanel = new Panel();
            SettingsPanel = new Panel();
            SettingsButton = new Button();
            PlaceAddPanel = new Panel();
            PlaceAddBtn = new Button();
            PlaceTextbox = new TextBox();
            SidebarLabel = new Label();
            mainContentPanel = new Panel();
            homePage1 = new HomePage();
            refreshButton = new Button();
            MainSidebarPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            PlaceAddPanel.SuspendLayout();
            mainContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainSidebarPanel
            // 
            MainSidebarPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainSidebarPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            MainSidebarPanel.Controls.Add(PlaceBoxPanel);
            MainSidebarPanel.Controls.Add(SettingsPanel);
            MainSidebarPanel.Controls.Add(PlaceAddPanel);
            MainSidebarPanel.Controls.Add(SidebarLabel);
            MainSidebarPanel.Dock = DockStyle.Left;
            MainSidebarPanel.Location = new Point(0, 0);
            MainSidebarPanel.Name = "MainSidebarPanel";
            MainSidebarPanel.Size = new Size(300, 544);
            MainSidebarPanel.TabIndex = 0;
            // 
            // PlaceBoxPanel
            // 
            PlaceBoxPanel.AutoScroll = true;
            PlaceBoxPanel.BackColor = Color.Transparent;
            PlaceBoxPanel.Dock = DockStyle.Fill;
            PlaceBoxPanel.Location = new Point(0, 102);
            PlaceBoxPanel.Name = "PlaceBoxPanel";
            PlaceBoxPanel.Size = new Size(300, 392);
            PlaceBoxPanel.TabIndex = 4;
            // 
            // SettingsPanel
            // 
            SettingsPanel.AutoScroll = true;
            SettingsPanel.BackColor = Color.FromArgb(100, 255, 255, 255);
            SettingsPanel.Controls.Add(refreshButton);
            SettingsPanel.Controls.Add(SettingsButton);
            SettingsPanel.Dock = DockStyle.Bottom;
            SettingsPanel.Location = new Point(0, 494);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(300, 50);
            SettingsPanel.TabIndex = 5;
            // 
            // SettingsButton
            // 
            SettingsButton.BackgroundImage = (Image)resources.GetObject("SettingsButton.BackgroundImage");
            SettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsButton.Dock = DockStyle.Left;
            SettingsButton.Location = new Point(0, 0);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(50, 50);
            SettingsButton.TabIndex = 0;
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // PlaceAddPanel
            // 
            PlaceAddPanel.Controls.Add(PlaceAddBtn);
            PlaceAddPanel.Controls.Add(PlaceTextbox);
            PlaceAddPanel.Dock = DockStyle.Top;
            PlaceAddPanel.Location = new Point(0, 52);
            PlaceAddPanel.Name = "PlaceAddPanel";
            PlaceAddPanel.Size = new Size(300, 50);
            PlaceAddPanel.TabIndex = 3;
            // 
            // PlaceAddBtn
            // 
            PlaceAddBtn.Anchor = AnchorStyles.Right;
            PlaceAddBtn.Location = new Point(260, 7);
            PlaceAddBtn.Name = "PlaceAddBtn";
            PlaceAddBtn.Size = new Size(37, 37);
            PlaceAddBtn.TabIndex = 2;
            PlaceAddBtn.Text = "+";
            PlaceAddBtn.UseVisualStyleBackColor = true;
            PlaceAddBtn.Click += PlaceAddBtn_Click;
            // 
            // PlaceTextbox
            // 
            PlaceTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PlaceTextbox.BackColor = Color.White;
            PlaceTextbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PlaceTextbox.Location = new Point(5, 7);
            PlaceTextbox.Name = "PlaceTextbox";
            PlaceTextbox.Size = new Size(249, 37);
            PlaceTextbox.TabIndex = 2;
            PlaceTextbox.Text = "Wyszukaj miasto...";
            PlaceTextbox.Enter += PlaceTextbox_Enter;
            PlaceTextbox.KeyDown += PlaceTextbox_KeyDown;
            // 
            // SidebarLabel
            // 
            SidebarLabel.BackColor = Color.Transparent;
            SidebarLabel.Dock = DockStyle.Top;
            SidebarLabel.Font = new Font("Lucida Sans", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SidebarLabel.ForeColor = Color.DimGray;
            SidebarLabel.Location = new Point(0, 0);
            SidebarLabel.Name = "SidebarLabel";
            SidebarLabel.Size = new Size(300, 52);
            SidebarLabel.TabIndex = 2;
            SidebarLabel.Text = "Spokodynka";
            SidebarLabel.TextAlign = ContentAlignment.MiddleCenter;
            SidebarLabel.Click += SidebarLabel_Click;
            // 
            // mainContentPanel
            // 
            mainContentPanel.BackColor = Color.Transparent;
            mainContentPanel.Controls.Add(homePage1);
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.Location = new Point(300, 0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(678, 544);
            mainContentPanel.TabIndex = 1;
            // 
            // homePage1
            // 
            homePage1.BackColor = Color.Transparent;
            homePage1.Dock = DockStyle.Fill;
            homePage1.Location = new Point(0, 0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(678, 544);
            homePage1.TabIndex = 0;
            // 
            // refreshButton
            // 
            refreshButton.BackgroundImage = (Image)resources.GetObject("refreshButton.BackgroundImage");
            refreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            refreshButton.Dock = DockStyle.Left;
            refreshButton.Location = new Point(50, 0);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(50, 50);
            refreshButton.TabIndex = 1;
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // Spokodynka
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = Spokodynka_gui.Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 544);
            Controls.Add(mainContentPanel);
            Controls.Add(MainSidebarPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Spokodynka";
            Text = "Spokodynka";
            MainSidebarPanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
            PlaceAddPanel.ResumeLayout(false);
            PlaceAddPanel.PerformLayout();
            mainContentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainSidebarPanel;
        private Label SidebarLabel;
        private Panel PlaceAddPanel;
        private Button PlaceAddBtn;
        private TextBox PlaceTextbox;
        private Panel PlaceBoxPanel;
        private Panel mainContentPanel;
        private HomePage homePage1;
        private Panel SettingsPanel;
        private Button SettingsButton;
        private Button refreshButton;
    }
}
