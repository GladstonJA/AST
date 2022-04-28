using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public abstract class JobDecorator : Job
    {
        protected Job Job { get; set; }

        public JobDecorator(Job job)
        {
            Job = job;
        }
    }
}
