﻿namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.RetailApp
{
    using System;
    using System.Linq;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;

    class StartPage : BasePage, IAppVersionPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public StartPage(BaseProgram program) : base("Retail App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("We’ll create a new \"Bouquet\" hierarchical entity.");
            Console.WriteLine("The Bouquet entity will contain \"Roses\" and \"Carnations\" as child entities.");

            var bouquetEntity = new HierarchicalModelCreateObject
            {
                Name = "Bouquet",
                Children = new[] { "Roses", "Carnations" }.ToList()
            };

            var entityId = AwaitTask(Client.Model.AddHierarchicalEntityAsync(AppId, VersionId, bouquetEntity));

            Console.WriteLine($"{bouquetEntity.Name} hierarchical Entity created with the id {entityId}");

            NavigateWithInitializer<FlowerpotPage>((page) =>
            {
                page.AppId = AppId;
                page.VersionId = VersionId;
            });
        }
    }
}