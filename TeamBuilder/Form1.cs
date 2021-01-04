using System;
using System.Globalization;
using System.Windows.Forms;

namespace TeamBuilder
{
    public partial class TeamBulider : Form
    {

        //Declaring variables
        int LoginAttempts, EventDays, TotalBookings;
        const decimal MURDERMYSTERYWEEKENDREGISTRATIONFEE = 600.0m, CSIWEEKENDOUTDOORSREGISTRATIONFEE = 1000.0m, THEGREATOUTDOORSREGISTRATIONFEE = 1500.0m, THECHASEREGISTRATIONFEE = 1800.0m, DIGITALREFRESHREGISTRATIONFEE = 599.0m, CORKLODGINGFEE = 250.0m, DUBLINLODGINGFEE = 165.0m, GALWAYLODGINGFEE = 225.0m, BELMULLETLODGINGFEE = 305.0m, BELFASTLODGINGFEE = 95.0m, FULLBOARDMEAL = 49.50m, HALFBOARDMEAL = 37.50m, BREAKFASTONLYMEAL = 12.00m, CERTIFICATESELECTEDCHARGE = 9.95m;
        decimal MealPlanFee, CertificateCharge, TotalFees, TotalLodgingFees, SelectedLodgingFee, TotalMealPlanFees, TotalRegistrationFees, TotalCertificateCharges, TotalRevenue, SelectedEventRegistrationFee;
        string EventSelected, LocationSelected, MealPlan, UserSummaryData;





        private void LocationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserSummaryDataGroupBox.Visible = false;
            BookButton.Enabled = false;
            //Enable ClearButton
            ClearSummaryButton.Enabled = false;
        }

        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserSummaryDataGroupBox.Visible = false;
            BookButton.Enabled = false;
            //Enable ClearButton
            ClearSummaryButton.Enabled = false;
        }


        //Clearing existing selection 
        private void ClearSummaryButton_Click(object sender, EventArgs e)
        {
            //Reverting form to the initial state
            EventsListBox.SelectedIndex = -1;
            LocationListBox.SelectedIndex = -1;
            CertificateCheckBox.Checked = false;

            //Radiobutton unchecked
            NoneRadioButton.Checked = false;
            FullBoardMealRadioButton.Checked = false;
            HalfBoardMealRadioButton.Checked = false;
            BreakfastMealRadioButton.Checked = false;

            //Change visibilty
            UserSummaryDataGroupBox.Visible = false;
            CompanySummaryDataGroupBox.Visible = false;
            EventsListBox.Visible = true;
            LocationListBox.Visible = true;
            NoneRadioButton.Visible = true;
            FullBoardMealRadioButton.Visible = true;
            HalfBoardMealRadioButton.Visible = true;
            BreakfastMealRadioButton.Visible = true;
            CertificateCheckBox.Visible = true;
            EventTitleLabel.Visible = true;
            LocationsTitleLabel.Visible = true;
            MealPlanTitleLabel.Visible = true;

            //Enabling buttons
            DisplayButton.Enabled = true;
        }

        //Booking details
        private void BookButton_Click(object sender, EventArgs e)
        {
            //Booking claculations
            MessageBox.Show(UserSummaryData, "Thank You for your booking!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TotalBookings += 1;
            TotalLodgingFees += SelectedLodgingFee;
            TotalRegistrationFees += SelectedEventRegistrationFee;
            TotalMealPlanFees += MealPlanFee;
            TotalCertificateCharges += CertificateCharge;
            TotalRevenue = TotalRegistrationFees + TotalLodgingFees + TotalMealPlanFees + TotalCertificateCharges;

            //Reset form state
            EventsListBox.SelectedIndex = -1;
            LocationListBox.SelectedIndex = -1;
            CertificateCheckBox.Checked = false;

            //Radiobuttons unchecked
            NoneRadioButton.Checked = false;
            FullBoardMealRadioButton.Checked = false;
            HalfBoardMealRadioButton.Checked = false;
            BreakfastMealRadioButton.Checked = false;

            //Summary button enabled
            CompanySummaryDataButton.Enabled = true;

        }

        //Exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Company summary data display
        private void CompanySummaryDataButton_Click(object sender, EventArgs e)
        {
            //Display Summary Data
            TotalBookingsDisplay.Text = TotalBookings.ToString();
            TotalRegFeesDisplay.Text = TotalRegistrationFees.ToString("C", new CultureInfo("en-FR"));
            TotalLodgingFeesDisplay.Text = TotalLodgingFees.ToString("C", new CultureInfo("en-FR"));
            TotalMealPlansFeesDisplay.Text = TotalMealPlanFees.ToString("C", new CultureInfo("en-FR"));
            TotalCertificateFeesDisplay.Text = TotalCertificateCharges.ToString("C", new CultureInfo("en-FR"));
            AverageRevenueDisplay.Text = (TotalRevenue / TotalBookings).ToString("C", new CultureInfo("en-FR"));

            //Visibility
            UserSummaryDataGroupBox.Visible = false;
            CompanySummaryDataGroupBox.Visible = true;
            EventsListBox.Visible = false;
            LocationListBox.Visible = false;
            NoneRadioButton.Visible = false;
            FullBoardMealRadioButton.Visible = false;
            HalfBoardMealRadioButton.Visible = false;
            BreakfastMealRadioButton.Visible = false;
            CertificateCheckBox.Visible = false;
            EventTitleLabel.Visible = false;
            LocationsTitleLabel.Visible = false;
            MealPlanTitleLabel.Visible = false;

            //Enabling buttons
            ClearSummaryButton.Enabled = true;
            DisplayButton.Enabled = false;
        }
        //Password clear
        private void ClearButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = string.Empty;
        }
        public TeamBulider()
        {
            InitializeComponent();
        }
        //Login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "NUIGalway@07")
            {
                TeambuilderGroupBox.Visible = true;
                LoginGroupBox.Visible = false;
            }
            else
            {
                //Managing incorrect attempts
                PasswordRemainingAttempts.Text = "Remaining Attempts: " + (4 - LoginAttempts);
                MessageBox.Show("Password entered is incorrect.", "Invalid attempt!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginAttempts += 1;
                if (LoginAttempts == 4)
                {
                    MessageBox.Show("The form will now exit.", "Too many incorrect attempts!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }
        //Display button
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //BookButton Enabling
            BookButton.Enabled = true;
            //switch for Events
            int EventSelectedIndex = EventsListBox.SelectedIndex;
            if (EventSelectedIndex >= 0 & EventSelectedIndex <= 4)
            {
                UserSummaryDataGroupBox.Visible = true;
                switch (EventSelectedIndex)
                {
                    case 0:
                        EventSelected = "Murder Mystery Weekend";
                        SelectedEventRegistrationFee = MURDERMYSTERYWEEKENDREGISTRATIONFEE;
                        EventDays = 2;
                        break;
                    case 1:
                        EventSelected = "CSI Weekend";
                        SelectedEventRegistrationFee = CSIWEEKENDOUTDOORSREGISTRATIONFEE;
                        EventDays = 3;
                        break;
                    case 2:
                        EventSelected = "The Great Outdoors";
                        SelectedEventRegistrationFee = THEGREATOUTDOORSREGISTRATIONFEE;
                        EventDays = 4;
                        break;
                    case 3:
                        EventSelected = "The Chase";
                        SelectedEventRegistrationFee = THECHASEREGISTRATIONFEE;
                        EventDays = 6;
                        break;
                    case 4:
                        EventSelected = "Digital Refresh";
                        SelectedEventRegistrationFee = DIGITALREFRESHREGISTRATIONFEE;
                        EventDays = 2;
                        break;
                }
            }
            else
            {
                BookButton.Enabled = false;
                UserSummaryDataGroupBox.Visible = false;
                MessageBox.Show("Please select the desired event.", "Event not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //switchcase for locations
            int LocationSelectedIndex = LocationListBox.SelectedIndex;
            if (LocationSelectedIndex >= 0 & LocationSelectedIndex <= 4)
            {
                switch (LocationSelectedIndex)
                {
                    case 0:
                        LocationSelected = "Cork";
                        SelectedLodgingFee = CORKLODGINGFEE;
                        break;
                    case 1:
                        LocationSelected = "Dublin";
                        SelectedLodgingFee = DUBLINLODGINGFEE;
                        break;
                    case 2:
                        LocationSelected = "Galway";
                        SelectedLodgingFee = GALWAYLODGINGFEE;
                        break;
                    case 3:
                        LocationSelected = "Belmullet";
                        SelectedLodgingFee = BELMULLETLODGINGFEE;
                        break;
                    case 4:
                        LocationSelected = "Belfast";
                        SelectedLodgingFee = BELFASTLODGINGFEE;
                        break;
                }
            }
            else
            {
                BookButton.Enabled = false;
                UserSummaryDataGroupBox.Visible = false;
                MessageBox.Show("Please select the desired location.", "Location not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //meal plans radio buttons
            if (NoneRadioButton.Checked)
            {
                MealPlan = "None";
                MealPlanFee = 0.00m;
            }
            else if (FullBoardMealRadioButton.Checked)
            {
                MealPlan = "Full Board";
                MealPlanFee = FULLBOARDMEAL;
            }
            else if (HalfBoardMealRadioButton.Checked)
            {
                MealPlan = "Half Board";
                MealPlanFee = HALFBOARDMEAL;
            }
            else if (BreakfastMealRadioButton.Checked)
            {
                MealPlan = "Breakfast Only";
                MealPlanFee = BREAKFASTONLYMEAL;
            }
            else
            {
                BookButton.Enabled = false;
                UserSummaryDataGroupBox.Visible = false;
                MessageBox.Show("Please select the desired meal plan.","Meal plan not selected.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            //Certificate Charge
            if (CertificateCheckBox.Checked == true)
            {
                CertificateCharge = CERTIFICATESELECTEDCHARGE;
            }
            else
            {
                CertificateCharge = 0.00m;
            }
            //Enable ClearButton
            ClearSummaryButton.Enabled = true;
            //User summary for book button display
            UserSummaryData = string.Format("{0}: {1}\n{2}: {3}\n{4}: {5}\nCertificate Charge: {6}\nTotal: {7}", EventSelected, SelectedEventRegistrationFee.ToString("C", new CultureInfo("en-FR")), LocationSelected, SelectedLodgingFee.ToString("C", new CultureInfo("en-FR")), MealPlan, MealPlanFee.ToString("C", new CultureInfo("en-FR")), CertificateCharge.ToString("C", new CultureInfo("en-FR")), ((SelectedEventRegistrationFee + CertificateCharge + (EventDays * SelectedLodgingFee)).ToString("C", new CultureInfo("en-FR"))));

            //Display User Summary Data
            EventDisplayLabel.Text = EventSelected + ": " + SelectedEventRegistrationFee.ToString("C", new CultureInfo("en-FR"));
            LocationDisplayLabel.Text = LocationSelected + ": " + SelectedLodgingFee.ToString("C", new CultureInfo("en-FR"));
            MealPlanDisplayLabel.Text = MealPlan + ": " + MealPlanFee.ToString("C", new CultureInfo("en-FR"));
            PrintedCertificateDisplayLabel.Text = CertificateCharge.ToString("C", new CultureInfo("en-FR"));
            TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
            TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
        }
        //If radiobutton check changes after display
        private void NoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MealPlan = "None";
            MealPlanFee = 0.00m;
            MealPlanDisplayLabel.Text = MealPlan + ": " + MealPlanFee.ToString("C", new CultureInfo("en-FR"));
            TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
            TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
        }
        private void FullBoardMealRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MealPlan = "Full Board";
            MealPlanFee = FULLBOARDMEAL;
            MealPlanDisplayLabel.Text = MealPlan + ": " + MealPlanFee.ToString("C", new CultureInfo("en-FR"));
            TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
            TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
        }
        private void HalfBoardMealRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MealPlan = "Half Board";
            MealPlanFee = HALFBOARDMEAL;
            MealPlanDisplayLabel.Text = MealPlan + ": " + MealPlanFee.ToString("C", new CultureInfo("en-FR"));
            TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
            TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
        }
        private void BreakfastMealRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MealPlan = "Breakfast Only";
            MealPlanFee = BREAKFASTONLYMEAL;
            MealPlanDisplayLabel.Text = MealPlan + ": " + MealPlanFee.ToString("C", new CultureInfo("en-FR"));
            TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
            TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
        }
        //Certificate checkbox changed after display
        private void CertificateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CertificateCheckBox.Checked == true)
            {
                CertificateCharge = CERTIFICATESELECTEDCHARGE;
                PrintedCertificateDisplayLabel.Text = CertificateCharge.ToString("C", new CultureInfo("en-FR"));
                //Checkbox checked calculations
                TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
                TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
            }
            else
            {
                CertificateCharge = 0.00m;
                PrintedCertificateDisplayLabel.Text = CertificateCharge.ToString("C", new CultureInfo("en-FR"));
                //Checkbox unchecked calculations
                TotalFees = ((SelectedEventRegistrationFee + CertificateCharge + MealPlanFee + (EventDays * SelectedLodgingFee)));
                TotalCostDisplayLabel.Text = TotalFees.ToString("C", new CultureInfo("en-FR"));
            }
        }

    }
}
