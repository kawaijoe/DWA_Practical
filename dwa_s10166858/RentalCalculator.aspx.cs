using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class RentalCalculator : System.Web.UI.Page {

        // List that stores options
        private List<int> numLoanDays = new List<int> { 2, 5, 10, 20 };
        private List<double> rentalRates = new List<double> { 1.0, 1.50, 2.50, 5.00 };

        private int numDays = 2;

        protected void Page_Init(object sender, EventArgs e) {
            calendar.SelectedDate = DateTime.Today.Date;

            for (int i = 1; i <= 10; i++)
                ddlNumBooks.Items.Add(i.ToString());

            for (int i = 0; i < numLoanDays.Count(); i++)
                rdoNumDays.Items.Add(numLoanDays[i].ToString());
            rdoNumDays.SelectedIndex = 0;
            calendar.TodaysDate = DateTime.Now.Date;
            txtRentalRate.Text = rentalRates[rdoNumDays.SelectedIndex].ToString("#.##0.00");
        }

        protected void rdoNumDays_SelectedIndexChanged(object sender, EventArgs e) {
            // Get selected number of days
            numDays = Convert.ToInt32(rdoNumDays.SelectedValue);

            // Update due date
            lblDueDate.Text = computeLoanDueDate();

            // Set rental rate textbox
            txtRentalRate.Text = rentalRates[rdoNumDays.SelectedIndex].ToString("#.##0.00");
        }

        protected void btnComputeRental_Click(object sender, EventArgs e) {
            DateTime date = calendar.SelectedDate;

            //Calculate Rental Feet
            float totalRental = float.Parse(ddlNumBooks.Text) *
                float.Parse(rdoNumDays.Text) *
                float.Parse(txtRentalRate.Text);
            int discount = calculateDiscount(totalRental);

            //Display rental fee, discount percentage and amount payable
            lblRentalFee.Text = totalRental.ToString();
            lblDiscountPercent.Text = discount.ToString();
            lblAmtPayable.Text = (totalRental * (1 - (discount / 100))).ToString();
        }

        protected void calendar_SelectionChanged(object sender, EventArgs e) {
            lblDueDate.Text = computeLoanDueDate();
        }

        private String computeLoanDueDate() {
            DateTime dteDueDate = calendar.SelectedDate.AddDays(numDays);
            return dteDueDate.ToString("dd-MMM-yyyy");
        }

        private int calculateDiscount(float totalRental) {
            if (totalRental <= 10 && totalRental > 0)
                return 0;
            else if (totalRental <= 50 && totalRental > 10)
                return 5;
            else if (totalRental <= 100 && totalRental > 50)
                return 10;
            else // > 100
                return 20;
        }
    }
}