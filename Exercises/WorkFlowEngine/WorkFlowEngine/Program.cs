using System;
using System.Collections.Generic;

namespace WorkFlowEngineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new CallWebService());
            workflow.Add(new SendMail());
            workflow.Add(new ChangeStatus());

            var engine = new WorkflowEngine();
            engine.Run(workflow);

            Console.ReadLine();
        }
    }

    public interface ITask
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }

    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }

    class SendMail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email...");
        }
    }

    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Statu changed.............");
        }
    }

    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach(ITask I in workflow.GetTasks())
            {
                try
                {
                    I.Execute();
                }
                catch (Exception ex)
                {
                    // Logging
                    // Terminate and persis the state of the workflow
                    throw;
                }
            }
        }
    }
}
