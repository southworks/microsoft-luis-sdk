﻿namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.RetailApp
{
    using System;
    using System.Linq;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;

    class FlowerpotPage : BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public FlowerpotPage(BaseProgram program) : base("Flowerpot entity", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("We’ll create a new \"Flowerpot\" hierarchical entity.");
            Console.WriteLine("The Flowerpot entity will contain \"Cactus\" as the only child entity.");

            var flowerpotEntity = new HierarchicalModelCreateObject
            {
                Name = "Flowerpot",
                Children = new[] { "Cactus"}.ToList()
            };

            var entityId = AwaitTask(Client.Model.AddHierarchicalEntityAsync(this.AppId, this.VersionId, flowerpotEntity));

            Console.WriteLine($"{flowerpotEntity.Name} hierarchical Entity created with the id {entityId}");

            NavigateWithInitializer<AddFlowersPage>((page) => {
                page.AppId = this.AppId;
                page.VersionId = this.VersionId;
                page.EntityId = entityId;
            });
        }
    }
}