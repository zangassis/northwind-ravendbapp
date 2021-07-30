using Raven.Client.Documents;
using System;

namespace Northwind.Raven
{
    public class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> LazyStore = new(() =>
        {
            IDocumentStore store = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "Northwind"
            };

            store.Initialize();

            return store;
        });

        public static IDocumentStore Store => LazyStore.Value;
    }
}
