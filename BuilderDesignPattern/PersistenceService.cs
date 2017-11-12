using SharedComponents;
using System;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    // The product - service to persist data to data storage.
    public class PersistenceService
    {
        public IPersistenceDriver PersistencyDriver { get; set; }

        public int MaxFileNameLength { get; set; }

        public HashSet<ValidationRule> ValidationRules { get; private set; }

        public void SetValidationRules(HashSet<ValidationRule> validationRules)
        {
            ValidationRules = validationRules;
        }

        internal void StartListen()
        {
            Console.WriteLine("Persistence Service is ready & listen to change in data");
        }
    }
}