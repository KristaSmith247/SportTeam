/* SportingTeams.cs
 * Author: Krista Smith
 * Date: 11/3/23
 * Description: The file will define events that occur when the user interacts with the GUI.
 */

using SportBaseClass;
using System;
using System.Windows.Forms;

namespace Sporting_Teams
{
    public partial class SportingTeamsForm : Form
    {
        // initialize objects for the form
        private Soccer aSoccerTeam;
        private Football aFootballTeam;
        
        public SportingTeamsForm()
        {
            InitializeComponent();
        }

        private void SportingTeamsForm_Load(object sender, EventArgs e)
        {
            // define objects
            aSoccerTeam = new Soccer("Daniel Wilson", "Soccer", 22, "Beginners", 15.00M, "Marigold Field", "Feb - Oct");
            aFootballTeam = new Football("Maria Hugh", "Football", 44, "Experienced", 30.00M, "John Doe", 12.00M, "Organized Football");
        }

        private void rbSoccer_CheckedChanged(object sender, EventArgs e)
        {
            // when user selects the soccer button:
            // show information, including budget details
            txtBxInfo.Text = aSoccerTeam.ToString();
            txtBxBudgetInfo.Text = aSoccerTeam.BudgetInfo("Soccer");
        }

        private void rbFootball_CheckedChanged(object sender, EventArgs e)
        {
            // when user selects football button: 
            // show information, including budget details
            txtBxInfo.Text = aFootballTeam.ToString();
            txtBxBudgetInfo.Text = aFootballTeam.BudgetInfo("Football");
        }
    }
}
