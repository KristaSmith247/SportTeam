/* Football.cs
 * Author: Krista Smith
 * Date: 11/3/23
 * Description: The file will define a Football object, which inherits
 * from the SportTeam class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBaseClass
{
    public class Football : SportTeam
    {
        private string equipmentReplacementContact;
        private decimal uniformCost;
        private string leagueName;
        private int members = 44; // maximum players allowed
        private decimal bonus = 150M; // bonus for budget

        public Football()
        {
        }

        public Football(string coach, string sport, int limit, string experience, decimal fee, string equipmentReplacer, decimal uniform, string league) : base(coach, sport, limit, experience, fee)
        {
            equipmentReplacementContact = equipmentReplacer;
            uniformCost = uniform;
            leagueName = league;
        }

        public override decimal Budget(decimal fees)
        {
            // calculate budget by multiplying number of people by the fees and adding a bonus
            // max number of football players is 44
            // bonus is $150 for football
            return members * fees + bonus;
        }

        public override string BudgetInfo(string sportName)
        {
            return base.BudgetInfo(sportName) + " The fees for sign-up are $" + Fees + "." +
                " There is a maximum of " + members + " sign-ups." +
                " An additional $" + bonus + " from donors is added to the budget.";
        }

        public override string ToString()
        {
            return "Football Information\n\n" + base.ToString() + "\nMember limit: " + 
                MemberLimit + "\nExperience Level: " + ExperienceLevel + 
                "\nRegistration Fees: " + Fees.ToString("C") + "\nUniform cost: " +
                uniformCost.ToString("C") + "\nLeague name: " + leagueName
                + "\nReplacement contact: " + equipmentReplacementContact + 
                "\n\nBudget: " + Budget(Fees).ToString("C");
        }
    }
}
