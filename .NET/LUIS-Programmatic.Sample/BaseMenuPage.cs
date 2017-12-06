namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample
{
    using DotSpinners;
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using System;
    using System.Threading.Tasks;

    class BaseMenuPage : MenuPage
    {
        public ILuisProgrammaticAPI Client { get; private set; }

        public BaseMenuPage(string title, MainProgram program, params Option[] options) : base(title, program, options)
        {
            Client = program.Client;
        }

        protected T AwaitTask<T>(Task<T> task, bool clearAfterRun = true)
        {
            var awaiter = new DotSpinner(SpinnerTypes.Ping, task).Center();
            awaiter.Start();
            if (clearAfterRun)
            {
                Console.Clear();
                base.Display();
            }
            else
            {
                Console.WriteLine();
            }
            return task.Result;
        }

        protected void AwaitTask(Task task, bool clearAfterRun = true)
        {
            var awaiter = new DotSpinner(SpinnerTypes.Ping, task).Center();
            awaiter.Start();
            if (clearAfterRun)
            {
                Console.Clear();
                base.Display();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
