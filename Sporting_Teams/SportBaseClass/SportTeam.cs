/* SportTeam.cs
 * Author: Krista Smith
 * Date: 11/3/23
 * Description: The file will define an abstract class named SportTeam 
 */

namespace SportBaseClass
{
    public abstract class SportTeam
    {
        // variables to be used in all sports
        private string coachName;
        private string sportName;
        private string experienceLevel;
        private int memberLimit;
        private decimal fees;

        public SportTeam()
        {
            experienceLevel = "";
            coachName = string.Empty;
            sportName = string.Empty;
        }

        public SportTeam(string coach, string sport, int limit, string experience, decimal fee)
        {
            coachName = coach;
            sportName = sport;
            memberLimit = limit;
            experienceLevel = experience;
            fees = fee;
        }

        // properties
        public string CoachName
        {
            set { coachName = value; }
            get { return coachName; }
        }
        public string SportName
        {
            set { sportName = value; }
            get { return sportName; }
        }

        public string ExperienceLevel
        {
            set { experienceLevel = value; }
            get { return experienceLevel; }
        }
        public int MemberLimit
        {
            // max number of people allowed in a team
            set { memberLimit = value; }
            get { return memberLimit; }
        }
        public decimal Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        public virtual decimal Budget(decimal fees)
        {
            // calculate budget by multiplying number of people by the fees
            int members = 0;
            return members * fees;
        }

        public virtual string BudgetInfo(string sportName)
        {
            return "Budget Information for " + sportName + ":\n\n" + "Budget is created with the registration fees"
                + " from every sign-up.";
        }

        // override ToString()
        public override string ToString()
        {
            return "\nCoach Name: " + CoachName + "\nSport Name: " + SportName;
        }
    }
}
