using DotSpinners;
using EasyConsole;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
using System;
using System.Threading.Tasks;

namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample
{
    class BasePage : Page
    {
        public ILuisProgrammaticAPI Client { get; private set; }

        public BasePage(string title, BaseProgram program) : base(title, program)
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
            } else
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

        protected void WaitForGoBack()
        {
            Input.ReadString("Press any key to go back");
            Program.NavigateBack();
        }

        protected void WaitForNavigateTo<T>() where T : Page
        {
            Input.ReadString("Press any key to continue");
            Program.NavigateTo<T>();
        }

        protected void WaitForNavigateHome()
        {
            Input.ReadString("Press any key to go home");
            Program.NavigateHome();
        }

        protected T NavigateWithInitializer<T>(bool waitForNavigate, Action<T> initializer) where T : Page
        {
            if (waitForNavigate)
            {
                Input.ReadString("Press any key to continue");
            }

            var page = Program.SetPage<T>();
            initializer(page);

            Console.Clear();
            page.Display();

            return page;
        }
    }
}
