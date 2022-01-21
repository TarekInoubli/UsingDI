using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        ILogger _logger;
        IEmailer _emailer;

        public Chore(ILogger logger, IEmailer emailer)
        {
            _logger = logger;
            _emailer = emailer;
        }

        public string ChoreName { get; set; }

        public IPerson Owner { get; set; }

        public double HoursWorked { get; set; }

        public bool IsComplete { get; set; }

        public void PerformeWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed {ChoreName}");
            _emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}
