using Decorator.Decorators;
using Decorator.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class JobDispatcher
    {
        public void RunOnSchedule()
        {
            var jobs = GetJobsToRun();
            foreach (var job in jobs)
                job.Execute();
        }

        protected virtual List<Job> GetJobsToRun()
        {
            var result = new List<Job>();

            // Comportamentos vindo de um XML de configuracao ou banco de dados por exemplo.
            var jobGerarRelatorioDeVendas = new GerarRelatorioDeVendasJob();
            var decoratorGerarRelatorioDeVendas = new JobWithEmailAlert(jobGerarRelatorioDeVendas);
            result.Add(decoratorGerarRelatorioDeVendas);

            var jobConciliacao = new ExecutarConciliacaoDeBoletosJob();
            var decoratorTransacaoDaConciliacao = new JobWithEmailAlert(jobConciliacao);
            var decoratorLogging = new JobWIthLogging(decoratorTransacaoDaConciliacao);
            result.Add(decoratorLogging);

            return result;
        }

    }
}
