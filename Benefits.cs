using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gregg_CourseProject_Part2
{
    [Serializable]
    public class Benefits
    {
        //  attributes 
        private string healthInsurance;
        private int lifeInsurance;
        private int vacation;

        public Benefits(string healthInsurance, int lifeInsurance, int vacation)
        {
            this.healthInsurance = healthInsurance;
            this.lifeInsurance = lifeInsurance;
            this.vacation = vacation;
        }

        // constructors
        public Benefits()
        {
            healthInsurance = "N/A";
            lifeInsurance = 0;
            vacation = 0;
        }
        // behaviors
        public override string ToString()
        {
            return "healthInsurance =" + healthInsurance
                + ", lifeInsurance = " + lifeInsurance
                + ", vacation= " + vacation;
        }
        public string HealthInsurance
        {
            get { return healthInsurance; }
            set { healthInsurance = value; }
        }

        public int LifeInsurance 
        {
            get { return lifeInsurance; }
            set {  lifeInsurance = value; }
        }

        public int Vacation
        {
            get { return vacation; }
            set { vacation = value; }
        }

    }
}
