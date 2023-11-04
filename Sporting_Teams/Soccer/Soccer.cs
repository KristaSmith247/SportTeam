/* Soccer.cs
 * Author: Krista Smith
 * Date: 11/3/23
 * Description: The file will define a Soccer object, which inherits from 
 * the SportTeam class.
 */

namespace SportBaseClass
{
    public class Soccer : SportTeam
    {
        private string fieldLocation; // where team meets
        private string tournamentSeason; // dates for tournament season
        private decimal bonus = 100.00M; // bonus for budget
        private int members = 22; // number of players allowed for soccer

        public Soccer()
        {
        }

        public Soccer(string coach, string sport, int limit, string experience, decimal fee, string field, string season) : base(coach, sport, limit, experience, fee)
        {
            fieldLocation = field;
            tournamentSeason = season;
        }

        // redefine virtual methods
        public override decimal Budget(decimal fees)
        {
            // calculate budget by multiplying number of people by the fees
            // soccer will have 11 players per team, maximum of two teams (22 players),
            // with an added $100 for budget bonus
            return (members * fees) + bonus;
        }

        public override string BudgetInfo(string sportName)
        {
            return base.BudgetInfo(sportName) +" The fees from sign-up are $" + Fees +
                " with a maximum of " + members + " sign-ups." + " An additional $" + bonus + " from"
                + " donors is added.";
        }

        public override string ToString()
        {
            return "Soccer Information\n\n" + base.ToString() + "\nMember limit: " + MemberLimit +
                "\nExperience level: " + ExperienceLevel + "\nRegistration Fees: " + Fees.ToString("C")
                + "\nField location: " + fieldLocation + "\nTournament Season: " +
                tournamentSeason + "\n\nBudget: " + Budget(Fees).ToString("C");
        }
    }
}

