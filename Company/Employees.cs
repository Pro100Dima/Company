using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public enum Vacancies { Manager, Boss, Clerk, Salesman }
    public struct Employees
    {
        private string FullName_ { get; set; }
        public string FullName {
            get
            { return FullName_; }
            set {
                FullName_ = value.Replace("<center><b><font size=7>", "")
                    .Replace("</font></b></center>", "")
                    .Replace("\n", ""); //replace - zamena 1 na 2
            }
        }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }
        public Vacancies Position { get; set; }
    }
}
