using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dwa_s10166858 {
    public partial class FineCalculator : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            lblFineRate.Text = "0.50";
        }

        protected void Page_Load(object sender, EventArgs e) {
            // Do nothing
        }

        protected void CalDueDate_SelectionChanged(object sender, EventArgs e) {
            // Display due date
            lblDueDate.Text = calDueDate.SelectedDate.ToString("dd-MMM-yyyy");

            // Compute and display number of days overdue
            lblDayOverdue.Text = (DateTime.Now - calDueDate.SelectedDate).Days.ToString();

            // Clear displays
            lblFine.Text = "";
            lblFineBreakdown.Text = "";
        }

        protected void btnCompute_Click(object sender, EventArgs e) {
            Page.Validate();
            if (Page.IsValid) {
                lblFineBreakdown.Text = "";
                int noOverdueBook = Int32.Parse(txtNumOverdueBK.Text);
                int DaysOverdue = Int32.Parse(lblDayOverdue.Text);
                float FineRate = float.Parse(lblFineRate.Text);

                double totalFine = 0.0;
                for (int i = 1; i <= noOverdueBook; i++) {
                    double eachBookFine = i * FineRate * DaysOverdue;
                    totalFine += eachBookFine;
                    lblFineBreakdown.Text += "Overdue cost for Book "
                        + i + " = $" + eachBookFine.ToString("#,##0.00") + "<br>";
                }

                lblFine.Text = "$" + totalFine.ToString();

            }

        }
    }
}