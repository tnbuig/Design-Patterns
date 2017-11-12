using SharedComponents;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    public class FileSystemPersistenceServiceBuilder : PersistenceServiceBuilder
    {
        private PersistenceService persistencyService = new PersistenceService();

        public override void InitializeService(string address)
        {
            persistencyService.PersistencyDriver = new FileDriver(address);
            persistencyService.MaxFileNameLength = 255;
        }

        public override void LoadValidatoinRules()
        {
            var fileSystemValidationRules = new HashSet<ValidationRule> { new RuleA(), new RuleB(), new RuleC() };
            persistencyService.SetValidationRules(fileSystemValidationRules);
        }

        public override void StartListen()
        {
            persistencyService.StartListen();
        }

        public override PersistenceService GetService()
        {
            return persistencyService;
        }
    }
}