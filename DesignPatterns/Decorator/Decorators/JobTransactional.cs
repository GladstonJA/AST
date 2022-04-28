using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public class JobTransactional : JobDecorator
    {
        public JobTransactional(Job job) : base(job) { }

        public override void Execute()
        {
            // Cria transacao

            Job.Execute();
        }
    }
}