using System.Security.Cryptography.X509Certificates;

namespace SpecFlowTAF.StepDefinitions
{
    internal class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public Calculator()
        {
            
        }

        public int add ()
        {
            return Number1 + Number2;
        }
    }
}