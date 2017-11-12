using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public abstract class PersistenceServiceBuilder
    {
        // Initialize persistencyService object.
        public abstract void InitializeService(string address);

        public abstract void LoadValidatoinRules();

        // The service should start listen to data change and store on change.
        public abstract void StartListen();

        // Get the final product
        public abstract PersistenceService GetService();
    }
}
