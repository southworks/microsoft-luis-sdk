﻿namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.RetailApp
{
    using System;
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;

    class AddFlowersPage:BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }
        public Guid EntityId { get; set; }

        public AddFlowersPage(BaseProgram program) : base("Add Flowers", program)
        { }

        public override void Display()
        {
            base.Display();

            var addNew = Input.ReadString("Do you want to add more flowers to the 'Flowerpot' entity? (y/n)");

            while (addNew.Trim().ToLowerInvariant().StartsWith("y"))
            {
                var childEntity = new HierarchicalChildModelCreateObject
                {
                    Name = Input.ReadString("Type the flower name (e.g. Ficus): ")
                };

                var result = AwaitTask(Client.Model.AddHierarchicalEntityChildAsync(this.AppId, this.VersionId, this.EntityId, childEntity));

                Console.WriteLine($"Child Entity \"{childEntity.Name}\" added to the Parent Entity {this.EntityId}\n");

                addNew = Input.ReadString("Do you want to add more flowers to the 'Flowerpot' entity? (y/n)");
            }

            NavigateWithInitializer<TrainAppPage>((page) => {
                page.AppId = AppId;
                page.VersionId = VersionId;
            });
        }
    }
}
