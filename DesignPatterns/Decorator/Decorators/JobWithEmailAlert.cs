using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public class JobWithEmailAlert : JobDecorator
    {
        public JobWithEmailAlert(Job job) : base(job) { }

        public override void Execute()
        {
            Job.Execute();

            // Envia email
        }
    }
}