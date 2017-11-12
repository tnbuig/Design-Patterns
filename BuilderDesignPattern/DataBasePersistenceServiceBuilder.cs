using SharedComponents;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    public class DataBasePersistenceServiceBuilder : PersistenceServiceBuilder
    {
        private PersistenceService persistencyService = new PersistenceService();

        public override void InitializeService(string address)
        {
            persistencyService.PersistencyDriver = new SqlDriver(address);
            persistencyService.MaxFileNameLength = 255;
        }

        public override void StartListen()
        {
            persistencyService.StartListen();
        }

        public override PersistenceService GetService()
        {
            return persistencyService;
        }

        public override void LoadValidatoinRules()
        {
            var DataBaseValidationRules = new HashSet<ValidationRule> { new RuleC(), new RuleD() };
            persistencyService.SetValidationRules(DataBaseValidationRules);
        }
    }
}