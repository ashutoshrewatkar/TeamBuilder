namespace TeamBuilder
{
    partial class TeamBulider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamBulider));
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ClearPasswordButton = new System.Windows.Forms.Button();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.TeambuilderGroupBox = new System.Windows.Forms.GroupBox();
            this.CompanySummaryDataButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.ClearSummaryButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.CertificateCheckBox = new System.Windows.Forms.CheckBox();
            this.MealPlanTitleLabel = new System.Windows.Forms.Label();
            this.BreakfastMealRadioButton = new System.Windows.Forms.RadioButton();
            this.HalfBoardMealRadioButton = new System.Windows.Forms.RadioButton();
            this.FullBoardMealRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.LocationsTitleLabel = new System.Windows.Forms.Label();
            this.EventTitleLabel = new System.Windows.Forms.Label();
            this.LocationListBox = new System.Windows.Forms.ListBox();
            this.UserSummaryDataGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalCostDisplayLabel = new System.Windows.Forms.Label();
            this.PrintedCertificateDisplayLabel = new System.Windows.Forms.Label();
            this.MealPlanDisplayLabel = new System.Windows.Forms.Label();
            this.LocationDisplayLabel = new System.Windows.Forms.Label();
            this.EventDisplayLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.PrintedCertificateLabel = new System.Windows.Forms.Label();
            this.MealPlanLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.CompanySummaryDataGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageRevenueDisplay = new System.Windows.Forms.Label();
            this.AverageRevenueLabel = new System.Windows.Forms.Label();
            this.TotalCertificateFeesDisplay = new System.Windows.Forms.Label();
            this.TotalMealPlansFeesDisplay = new System.Windows.Forms.Label();
            this.TotalLodgingFeesDisplay = new System.Windows.Forms.Label();
            this.TotalRegFeesDisplay = new System.Windows.Forms.Label();
            this.TotalBookingsDisplay = new System.Windows.Forms.Label();
            this.TotalCertificateFeesLabel = new System.Windows.Forms.Label();
            this.TotalMealPlansFeesLabel = new System.Windows.Forms.Label();
            this.TotalLodgingFeesLabel = new System.Windows.Forms.Label();
            this.TotalRegFeesLabel = new System.Windows.Forms.Label();
            this.TotalBookingsLabel = new System.Windows.Forms.Label();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordRemainingAttempts = new System.Windows.Forms.Label();
            this.SummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TeambuilderGroupBox.SuspendLayout();
            this.UserSummaryDataGroupBox.SuspendLayout();
            this.CompanySummaryDataGroupBox.SuspendLayout();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Location = new System.Drawing.Point(311, 139);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(146, 20);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(218, 139);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(87, 15);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Enter Password";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Location = new System.Drawing.Point(397, 163);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(60, 26);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearPasswordButton
            // 
            this.ClearPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClearPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearPasswordButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearPasswordButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearPasswordButton.Location = new System.Drawing.Point(331, 163);
            this.ClearPasswordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearPasswordButton.Name = "ClearPasswordButton";
            this.ClearPasswordButton.Size = new System.Drawing.Size(60, 26);
            this.ClearPasswordButton.TabIndex = 3;
            this.ClearPasswordButton.Text = "Clear";
            this.ClearPasswordButton.UseVisualStyleBackColor = false;
            this.ClearPasswordButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.BackColor = System.Drawing.Color.White;
            this.EventsListBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EventsListBox.HorizontalExtent = 1;
            this.EventsListBox.ItemHeight = 16;
            this.EventsListBox.Items.AddRange(new object[] {
            "Murder Mystery Weekend (2 Days, €600)",
            "CSI Weekend (3 Days, €1000)",
            "Great Outdoors (4 Days, €1500)",
            "The Chase (6 Days, €1800)",
            "Digital Refresh (2 Days, €599)"});
            this.EventsListBox.Location = new System.Drawing.Point(21, 46);
            this.EventsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(221, 84);
            this.EventsListBox.TabIndex = 1;
            this.EventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventsListBox_SelectedIndexChanged);
            // 
            // TeambuilderGroupBox
            // 
            this.TeambuilderGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TeambuilderGroupBox.Controls.Add(this.CompanySummaryDataButton);
            this.TeambuilderGroupBox.Controls.Add(this.ExitButton);
            this.TeambuilderGroupBox.Controls.Add(this.BookButton);
            this.TeambuilderGroupBox.Controls.Add(this.ClearSummaryButton);
            this.TeambuilderGroupBox.Controls.Add(this.DisplayButton);
            this.TeambuilderGroupBox.Controls.Add(this.CertificateCheckBox);
            this.TeambuilderGroupBox.Controls.Add(this.MealPlanTitleLabel);
            this.TeambuilderGroupBox.Controls.Add(this.BreakfastMealRadioButton);
            this.TeambuilderGroupBox.Controls.Add(this.HalfBoardMealRadioButton);
            this.TeambuilderGroupBox.Controls.Add(this.FullBoardMealRadioButton);
            this.TeambuilderGroupBox.Controls.Add(this.NoneRadioButton);
            this.TeambuilderGroupBox.Controls.Add(this.LocationsTitleLabel);
            this.TeambuilderGroupBox.Controls.Add(this.EventTitleLabel);
            this.TeambuilderGroupBox.Controls.Add(this.LocationListBox);
            this.TeambuilderGroupBox.Controls.Add(this.EventsListBox);
            this.TeambuilderGroupBox.Controls.Add(this.UserSummaryDataGroupBox);
            this.TeambuilderGroupBox.Controls.Add(this.CompanySummaryDataGroupBox);
            this.TeambuilderGroupBox.Location = new System.Drawing.Point(86, 87);
            this.TeambuilderGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeambuilderGroupBox.Name = "TeambuilderGroupBox";
            this.TeambuilderGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeambuilderGroupBox.Size = new System.Drawing.Size(698, 330);
            this.TeambuilderGroupBox.TabIndex = 5;
            this.TeambuilderGroupBox.TabStop = false;
            this.TeambuilderGroupBox.Visible = false;
            // 
            // CompanySummaryDataButton
            // 
            this.CompanySummaryDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CompanySummaryDataButton.Enabled = false;
            this.CompanySummaryDataButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompanySummaryDataButton.Location = new System.Drawing.Point(592, 195);
            this.CompanySummaryDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompanySummaryDataButton.Name = "CompanySummaryDataButton";
            this.CompanySummaryDataButton.Size = new System.Drawing.Size(63, 33);
            this.CompanySummaryDataButton.TabIndex = 12;
            this.CompanySummaryDataButton.Text = "&Summary";
            this.SummaryToolTip.SetToolTip(this.CompanySummaryDataButton, "Press for the company summary!");
            this.CompanySummaryDataButton.UseVisualStyleBackColor = false;
            this.CompanySummaryDataButton.Click += new System.EventHandler(this.CompanySummaryDataButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(592, 281);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 33);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookButton.Enabled = false;
            this.BookButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookButton.Location = new System.Drawing.Point(592, 152);
            this.BookButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(63, 33);
            this.BookButton.TabIndex = 11;
            this.BookButton.Text = "&Book";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // ClearSummaryButton
            // 
            this.ClearSummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearSummaryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearSummaryButton.Location = new System.Drawing.Point(592, 238);
            this.ClearSummaryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearSummaryButton.Name = "ClearSummaryButton";
            this.ClearSummaryButton.Size = new System.Drawing.Size(63, 33);
            this.ClearSummaryButton.TabIndex = 13;
            this.ClearSummaryButton.Text = "&Clear";
            this.ClearSummaryButton.UseVisualStyleBackColor = false;
            this.ClearSummaryButton.Click += new System.EventHandler(this.ClearSummaryButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DisplayButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayButton.Location = new System.Drawing.Point(592, 109);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(63, 33);
            this.DisplayButton.TabIndex = 10;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // CertificateCheckBox
            // 
            this.CertificateCheckBox.AutoSize = true;
            this.CertificateCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CertificateCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CertificateCheckBox.Location = new System.Drawing.Point(531, 71);
            this.CertificateCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CertificateCheckBox.Name = "CertificateCheckBox";
            this.CertificateCheckBox.Size = new System.Drawing.Size(145, 17);
            this.CertificateCheckBox.TabIndex = 9;
            this.CertificateCheckBox.Text = "Printed Certificate (€9.95)";
            this.CertificateCheckBox.UseVisualStyleBackColor = false;
            this.CertificateCheckBox.CheckedChanged += new System.EventHandler(this.CertificateCheckBox_CheckedChanged);
            // 
            // MealPlanTitleLabel
            // 
            this.MealPlanTitleLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.MealPlanTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MealPlanTitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealPlanTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MealPlanTitleLabel.Location = new System.Drawing.Point(381, 23);
            this.MealPlanTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MealPlanTitleLabel.Name = "MealPlanTitleLabel";
            this.MealPlanTitleLabel.Size = new System.Drawing.Size(116, 21);
            this.MealPlanTitleLabel.TabIndex = 4;
            this.MealPlanTitleLabel.Text = "MEAL PLANS";
            this.MealPlanTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BreakfastMealRadioButton
            // 
            this.BreakfastMealRadioButton.AutoSize = true;
            this.BreakfastMealRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BreakfastMealRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BreakfastMealRadioButton.Location = new System.Drawing.Point(381, 109);
            this.BreakfastMealRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreakfastMealRadioButton.Name = "BreakfastMealRadioButton";
            this.BreakfastMealRadioButton.Size = new System.Drawing.Size(136, 17);
            this.BreakfastMealRadioButton.TabIndex = 8;
            this.BreakfastMealRadioButton.Text = "Breakfast Only (€12.00)";
            this.BreakfastMealRadioButton.UseVisualStyleBackColor = false;
            this.BreakfastMealRadioButton.CheckedChanged += new System.EventHandler(this.BreakfastMealRadioButton_CheckedChanged);
            // 
            // HalfBoardMealRadioButton
            // 
            this.HalfBoardMealRadioButton.AutoSize = true;
            this.HalfBoardMealRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HalfBoardMealRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HalfBoardMealRadioButton.Location = new System.Drawing.Point(381, 89);
            this.HalfBoardMealRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HalfBoardMealRadioButton.Name = "HalfBoardMealRadioButton";
            this.HalfBoardMealRadioButton.Size = new System.Drawing.Size(117, 17);
            this.HalfBoardMealRadioButton.TabIndex = 7;
            this.HalfBoardMealRadioButton.Text = "Half Board (€37.50)";
            this.HalfBoardMealRadioButton.UseVisualStyleBackColor = false;
            this.HalfBoardMealRadioButton.CheckedChanged += new System.EventHandler(this.HalfBoardMealRadioButton_CheckedChanged);
            // 
            // FullBoardMealRadioButton
            // 
            this.FullBoardMealRadioButton.AutoSize = true;
            this.FullBoardMealRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullBoardMealRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FullBoardMealRadioButton.Location = new System.Drawing.Point(381, 70);
            this.FullBoardMealRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullBoardMealRadioButton.Name = "FullBoardMealRadioButton";
            this.FullBoardMealRadioButton.Size = new System.Drawing.Size(114, 17);
            this.FullBoardMealRadioButton.TabIndex = 6;
            this.FullBoardMealRadioButton.Text = "Full Board (€49.50)";
            this.FullBoardMealRadioButton.UseVisualStyleBackColor = false;
            this.FullBoardMealRadioButton.CheckedChanged += new System.EventHandler(this.FullBoardMealRadioButton_CheckedChanged);
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoneRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoneRadioButton.Location = new System.Drawing.Point(381, 50);
            this.NoneRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneRadioButton.TabIndex = 5;
            this.NoneRadioButton.Text = "None";
            this.NoneRadioButton.UseVisualStyleBackColor = false;
            this.NoneRadioButton.CheckedChanged += new System.EventHandler(this.NoneRadioButton_CheckedChanged);
            // 
            // LocationsTitleLabel
            // 
            this.LocationsTitleLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.LocationsTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LocationsTitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationsTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationsTitleLabel.Location = new System.Drawing.Point(257, 22);
            this.LocationsTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationsTitleLabel.Name = "LocationsTitleLabel";
            this.LocationsTitleLabel.Size = new System.Drawing.Size(110, 21);
            this.LocationsTitleLabel.TabIndex = 2;
            this.LocationsTitleLabel.Text = "LOCATIONS";
            this.LocationsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EventTitleLabel
            // 
            this.EventTitleLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.EventTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EventTitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EventTitleLabel.Location = new System.Drawing.Point(21, 22);
            this.EventTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventTitleLabel.Name = "EventTitleLabel";
            this.EventTitleLabel.Size = new System.Drawing.Size(220, 21);
            this.EventTitleLabel.TabIndex = 0;
            this.EventTitleLabel.Text = "EVENT";
            this.EventTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocationListBox
            // 
            this.LocationListBox.BackColor = System.Drawing.Color.White;
            this.LocationListBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 16;
            this.LocationListBox.Items.AddRange(new object[] {
            "Cork (€250)",
            "Dublin (€165)",
            "Galway (€225)",
            "Belmullet (€305)",
            "Belfast (€95)"});
            this.LocationListBox.Location = new System.Drawing.Point(257, 46);
            this.LocationListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(111, 84);
            this.LocationListBox.TabIndex = 3;
            this.LocationListBox.SelectedIndexChanged += new System.EventHandler(this.LocationListBox_SelectedIndexChanged);
            // 
            // UserSummaryDataGroupBox
            // 
            this.UserSummaryDataGroupBox.Controls.Add(this.TotalCostDisplayLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.PrintedCertificateDisplayLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.MealPlanDisplayLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.LocationDisplayLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.EventDisplayLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.TotalCostLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.PrintedCertificateLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.MealPlanLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.LocationLabel);
            this.UserSummaryDataGroupBox.Controls.Add(this.EventLabel);
            this.UserSummaryDataGroupBox.Location = new System.Drawing.Point(141, 176);
            this.UserSummaryDataGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserSummaryDataGroupBox.Name = "UserSummaryDataGroupBox";
            this.UserSummaryDataGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserSummaryDataGroupBox.Size = new System.Drawing.Size(367, 138);
            this.UserSummaryDataGroupBox.TabIndex = 20;
            this.UserSummaryDataGroupBox.TabStop = false;
            this.UserSummaryDataGroupBox.Visible = false;
            // 
            // TotalCostDisplayLabel
            // 
            this.TotalCostDisplayLabel.BackColor = System.Drawing.Color.White;
            this.TotalCostDisplayLabel.Location = new System.Drawing.Point(122, 106);
            this.TotalCostDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCostDisplayLabel.Name = "TotalCostDisplayLabel";
            this.TotalCostDisplayLabel.Size = new System.Drawing.Size(214, 15);
            this.TotalCostDisplayLabel.TabIndex = 10;
            this.TotalCostDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintedCertificateDisplayLabel
            // 
            this.PrintedCertificateDisplayLabel.BackColor = System.Drawing.Color.White;
            this.PrintedCertificateDisplayLabel.Location = new System.Drawing.Point(122, 85);
            this.PrintedCertificateDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrintedCertificateDisplayLabel.Name = "PrintedCertificateDisplayLabel";
            this.PrintedCertificateDisplayLabel.Size = new System.Drawing.Size(214, 15);
            this.PrintedCertificateDisplayLabel.TabIndex = 9;
            this.PrintedCertificateDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MealPlanDisplayLabel
            // 
            this.MealPlanDisplayLabel.BackColor = System.Drawing.Color.White;
            this.MealPlanDisplayLabel.Location = new System.Drawing.Point(122, 64);
            this.MealPlanDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MealPlanDisplayLabel.Name = "MealPlanDisplayLabel";
            this.MealPlanDisplayLabel.Size = new System.Drawing.Size(214, 15);
            this.MealPlanDisplayLabel.TabIndex = 8;
            this.MealPlanDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationDisplayLabel
            // 
            this.LocationDisplayLabel.BackColor = System.Drawing.Color.White;
            this.LocationDisplayLabel.Location = new System.Drawing.Point(122, 43);
            this.LocationDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationDisplayLabel.Name = "LocationDisplayLabel";
            this.LocationDisplayLabel.Size = new System.Drawing.Size(214, 15);
            this.LocationDisplayLabel.TabIndex = 7;
            this.LocationDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventDisplayLabel
            // 
            this.EventDisplayLabel.BackColor = System.Drawing.Color.White;
            this.EventDisplayLabel.Location = new System.Drawing.Point(122, 22);
            this.EventDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventDisplayLabel.Name = "EventDisplayLabel";
            this.EventDisplayLabel.Size = new System.Drawing.Size(214, 15);
            this.EventDisplayLabel.TabIndex = 5;
            this.EventDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalCostLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalCostLabel.Location = new System.Drawing.Point(14, 106);
            this.TotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(55, 13);
            this.TotalCostLabel.TabIndex = 4;
            this.TotalCostLabel.Text = "Total Cost";
            // 
            // PrintedCertificateLabel
            // 
            this.PrintedCertificateLabel.AutoSize = true;
            this.PrintedCertificateLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrintedCertificateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintedCertificateLabel.Location = new System.Drawing.Point(14, 85);
            this.PrintedCertificateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrintedCertificateLabel.Name = "PrintedCertificateLabel";
            this.PrintedCertificateLabel.Size = new System.Drawing.Size(90, 13);
            this.PrintedCertificateLabel.TabIndex = 3;
            this.PrintedCertificateLabel.Text = "Printed Certificate";
            // 
            // MealPlanLabel
            // 
            this.MealPlanLabel.AutoSize = true;
            this.MealPlanLabel.BackColor = System.Drawing.Color.Transparent;
            this.MealPlanLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MealPlanLabel.Location = new System.Drawing.Point(14, 64);
            this.MealPlanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MealPlanLabel.Name = "MealPlanLabel";
            this.MealPlanLabel.Size = new System.Drawing.Size(54, 13);
            this.MealPlanLabel.TabIndex = 2;
            this.MealPlanLabel.Text = "Meal Plan";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LocationLabel.Location = new System.Drawing.Point(14, 43);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location";
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.BackColor = System.Drawing.Color.Transparent;
            this.EventLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventLabel.Location = new System.Drawing.Point(14, 22);
            this.EventLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(35, 13);
            this.EventLabel.TabIndex = 0;
            this.EventLabel.Text = "Event";
            // 
            // CompanySummaryDataGroupBox
            // 
            this.CompanySummaryDataGroupBox.Controls.Add(this.AverageRevenueDisplay);
            this.CompanySummaryDataGroupBox.Controls.Add(this.AverageRevenueLabel);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalCertificateFeesDisplay);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalMealPlansFeesDisplay);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalLodgingFeesDisplay);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalRegFeesDisplay);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalBookingsDisplay);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalCertificateFeesLabel);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalMealPlansFeesLabel);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalLodgingFeesLabel);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalRegFeesLabel);
            this.CompanySummaryDataGroupBox.Controls.Add(this.TotalBookingsLabel);
            this.CompanySummaryDataGroupBox.Location = new System.Drawing.Point(142, 176);
            this.CompanySummaryDataGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompanySummaryDataGroupBox.Name = "CompanySummaryDataGroupBox";
            this.CompanySummaryDataGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompanySummaryDataGroupBox.Size = new System.Drawing.Size(365, 138);
            this.CompanySummaryDataGroupBox.TabIndex = 21;
            this.CompanySummaryDataGroupBox.TabStop = false;
            this.CompanySummaryDataGroupBox.Visible = false;
            // 
            // AverageRevenueDisplay
            // 
            this.AverageRevenueDisplay.BackColor = System.Drawing.Color.White;
            this.AverageRevenueDisplay.Location = new System.Drawing.Point(190, 112);
            this.AverageRevenueDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AverageRevenueDisplay.Name = "AverageRevenueDisplay";
            this.AverageRevenueDisplay.Size = new System.Drawing.Size(128, 14);
            this.AverageRevenueDisplay.TabIndex = 12;
            this.AverageRevenueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageRevenueLabel
            // 
            this.AverageRevenueLabel.AutoSize = true;
            this.AverageRevenueLabel.BackColor = System.Drawing.Color.Transparent;
            this.AverageRevenueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AverageRevenueLabel.Location = new System.Drawing.Point(10, 112);
            this.AverageRevenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AverageRevenueLabel.Name = "AverageRevenueLabel";
            this.AverageRevenueLabel.Size = new System.Drawing.Size(137, 13);
            this.AverageRevenueLabel.TabIndex = 11;
            this.AverageRevenueLabel.Text = "Avg. Revenue Per Booking";
            this.AverageRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCertificateFeesDisplay
            // 
            this.TotalCertificateFeesDisplay.BackColor = System.Drawing.Color.White;
            this.TotalCertificateFeesDisplay.Location = new System.Drawing.Point(190, 93);
            this.TotalCertificateFeesDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCertificateFeesDisplay.Name = "TotalCertificateFeesDisplay";
            this.TotalCertificateFeesDisplay.Size = new System.Drawing.Size(128, 14);
            this.TotalCertificateFeesDisplay.TabIndex = 10;
            this.TotalCertificateFeesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalMealPlansFeesDisplay
            // 
            this.TotalMealPlansFeesDisplay.BackColor = System.Drawing.Color.White;
            this.TotalMealPlansFeesDisplay.Location = new System.Drawing.Point(190, 75);
            this.TotalMealPlansFeesDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalMealPlansFeesDisplay.Name = "TotalMealPlansFeesDisplay";
            this.TotalMealPlansFeesDisplay.Size = new System.Drawing.Size(128, 14);
            this.TotalMealPlansFeesDisplay.TabIndex = 9;
            this.TotalMealPlansFeesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLodgingFeesDisplay
            // 
            this.TotalLodgingFeesDisplay.BackColor = System.Drawing.Color.White;
            this.TotalLodgingFeesDisplay.Location = new System.Drawing.Point(190, 56);
            this.TotalLodgingFeesDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLodgingFeesDisplay.Name = "TotalLodgingFeesDisplay";
            this.TotalLodgingFeesDisplay.Size = new System.Drawing.Size(128, 14);
            this.TotalLodgingFeesDisplay.TabIndex = 8;
            this.TotalLodgingFeesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalRegFeesDisplay
            // 
            this.TotalRegFeesDisplay.BackColor = System.Drawing.Color.White;
            this.TotalRegFeesDisplay.Location = new System.Drawing.Point(190, 37);
            this.TotalRegFeesDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalRegFeesDisplay.Name = "TotalRegFeesDisplay";
            this.TotalRegFeesDisplay.Size = new System.Drawing.Size(128, 14);
            this.TotalRegFeesDisplay.TabIndex = 7;
            this.TotalRegFeesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBookingsDisplay
            // 
            this.TotalBookingsDisplay.BackColor = System.Drawing.Color.White;
            this.TotalBookingsDisplay.Location = new System.Drawing.Point(190, 19);
            this.TotalBookingsDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalBookingsDisplay.Name = "TotalBookingsDisplay";
            this.TotalBookingsDisplay.Size = new System.Drawing.Size(128, 14);
            this.TotalBookingsDisplay.TabIndex = 5;
            this.TotalBookingsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCertificateFeesLabel
            // 
            this.TotalCertificateFeesLabel.AutoSize = true;
            this.TotalCertificateFeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalCertificateFeesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalCertificateFeesLabel.Location = new System.Drawing.Point(10, 93);
            this.TotalCertificateFeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCertificateFeesLabel.Name = "TotalCertificateFeesLabel";
            this.TotalCertificateFeesLabel.Size = new System.Drawing.Size(107, 13);
            this.TotalCertificateFeesLabel.TabIndex = 4;
            this.TotalCertificateFeesLabel.Text = "Total Certificate Fees";
            // 
            // TotalMealPlansFeesLabel
            // 
            this.TotalMealPlansFeesLabel.AutoSize = true;
            this.TotalMealPlansFeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalMealPlansFeesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalMealPlansFeesLabel.Location = new System.Drawing.Point(10, 75);
            this.TotalMealPlansFeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalMealPlansFeesLabel.Name = "TotalMealPlansFeesLabel";
            this.TotalMealPlansFeesLabel.Size = new System.Drawing.Size(112, 13);
            this.TotalMealPlansFeesLabel.TabIndex = 3;
            this.TotalMealPlansFeesLabel.Text = "Total Meal Plans Fees";
            // 
            // TotalLodgingFeesLabel
            // 
            this.TotalLodgingFeesLabel.AutoSize = true;
            this.TotalLodgingFeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLodgingFeesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalLodgingFeesLabel.Location = new System.Drawing.Point(10, 56);
            this.TotalLodgingFeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLodgingFeesLabel.Name = "TotalLodgingFeesLabel";
            this.TotalLodgingFeesLabel.Size = new System.Drawing.Size(98, 13);
            this.TotalLodgingFeesLabel.TabIndex = 2;
            this.TotalLodgingFeesLabel.Text = "Total Lodging Fees";
            // 
            // TotalRegFeesLabel
            // 
            this.TotalRegFeesLabel.AutoSize = true;
            this.TotalRegFeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalRegFeesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalRegFeesLabel.Location = new System.Drawing.Point(10, 37);
            this.TotalRegFeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalRegFeesLabel.Name = "TotalRegFeesLabel";
            this.TotalRegFeesLabel.Size = new System.Drawing.Size(116, 13);
            this.TotalRegFeesLabel.TabIndex = 1;
            this.TotalRegFeesLabel.Text = "Total Registration Fees";
            // 
            // TotalBookingsLabel
            // 
            this.TotalBookingsLabel.AutoSize = true;
            this.TotalBookingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalBookingsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalBookingsLabel.Location = new System.Drawing.Point(10, 19);
            this.TotalBookingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalBookingsLabel.Name = "TotalBookingsLabel";
            this.TotalBookingsLabel.Size = new System.Drawing.Size(78, 13);
            this.TotalBookingsLabel.TabIndex = 0;
            this.TotalBookingsLabel.Text = "Total Bookings";
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginGroupBox.Controls.Add(this.PasswordRemainingAttempts);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.ClearPasswordButton);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Location = new System.Drawing.Point(86, 89);
            this.LoginGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginGroupBox.Size = new System.Drawing.Size(698, 328);
            this.LoginGroupBox.TabIndex = 6;
            this.LoginGroupBox.TabStop = false;
            // 
            // PasswordRemainingAttempts
            // 
            this.PasswordRemainingAttempts.ForeColor = System.Drawing.Color.White;
            this.PasswordRemainingAttempts.Location = new System.Drawing.Point(311, 111);
            this.PasswordRemainingAttempts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordRemainingAttempts.Name = "PasswordRemainingAttempts";
            this.PasswordRemainingAttempts.Size = new System.Drawing.Size(146, 19);
            this.PasswordRemainingAttempts.TabIndex = 4;
            this.PasswordRemainingAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryToolTip
            // 
            this.SummaryToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SummaryToolTip.ToolTipTitle = "Company summary";
            // 
            // TeamBulider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 582);
            this.Controls.Add(this.TeambuilderGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeamBulider";
            this.Text = "Team Builder";
            this.TeambuilderGroupBox.ResumeLayout(false);
            this.TeambuilderGroupBox.PerformLayout();
            this.UserSummaryDataGroupBox.ResumeLayout(false);
            this.UserSummaryDataGroupBox.PerformLayout();
            this.CompanySummaryDataGroupBox.ResumeLayout(false);
            this.CompanySummaryDataGroupBox.PerformLayout();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ClearPasswordButton;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.GroupBox TeambuilderGroupBox;
        private System.Windows.Forms.ListBox LocationListBox;
        private System.Windows.Forms.Label EventTitleLabel;
        private System.Windows.Forms.Label LocationsTitleLabel;
        private System.Windows.Forms.CheckBox CertificateCheckBox;
        private System.Windows.Forms.Label MealPlanTitleLabel;
        private System.Windows.Forms.RadioButton BreakfastMealRadioButton;
        private System.Windows.Forms.RadioButton HalfBoardMealRadioButton;
        private System.Windows.Forms.RadioButton FullBoardMealRadioButton;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Label PasswordRemainingAttempts;
        private System.Windows.Forms.Button ClearSummaryButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CompanySummaryDataButton;
        private System.Windows.Forms.GroupBox UserSummaryDataGroupBox;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label PrintedCertificateLabel;
        private System.Windows.Forms.Label MealPlanLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Label TotalCostDisplayLabel;
        private System.Windows.Forms.Label PrintedCertificateDisplayLabel;
        private System.Windows.Forms.Label MealPlanDisplayLabel;
        private System.Windows.Forms.Label LocationDisplayLabel;
        private System.Windows.Forms.Label EventDisplayLabel;
        private System.Windows.Forms.GroupBox CompanySummaryDataGroupBox;
        private System.Windows.Forms.Label TotalCertificateFeesDisplay;
        private System.Windows.Forms.Label TotalMealPlansFeesDisplay;
        private System.Windows.Forms.Label TotalLodgingFeesDisplay;
        private System.Windows.Forms.Label TotalRegFeesDisplay;
        private System.Windows.Forms.Label TotalBookingsDisplay;
        private System.Windows.Forms.Label TotalCertificateFeesLabel;
        private System.Windows.Forms.Label TotalMealPlansFeesLabel;
        private System.Windows.Forms.Label TotalLodgingFeesLabel;
        private System.Windows.Forms.Label TotalRegFeesLabel;
        private System.Windows.Forms.Label TotalBookingsLabel;
        private System.Windows.Forms.Label AverageRevenueDisplay;
        private System.Windows.Forms.Label AverageRevenueLabel;
        private System.Windows.Forms.ToolTip SummaryToolTip;
    }
}

