using SXeption.Brokers.Localizations;
using SXeption.Sample.Brokers.Loggings;
using SXeption.Sample.Models.Students;
using SXeption.Services.Foundations.StandardModels;
using System;
using System.Threading.Tasks;

namespace SXeption.Sample.Services.Foundations.Students
{
    public class StudentService : StandardModelService<Student>, IStudentService
    {
        private delegate ValueTask<Student> ReturningStudentFunction();
        private readonly ILocalizationBroker localizationBroker;
        private readonly ILoggingBroker loggingBroker;

        public StudentService(
            ILocalizationBroker localizationBroker,
            ILoggingBroker loggingBroker)
            : base(localizationBroker, loggingBroker)
        {

        }

        private ValueTask<Student> TryCatch(ReturningStudentFunction returningStudentFunction)
        {
            try
            {
                return returningStudentFunction();
            }
            catch (Exception ex)
            {
                throw CreateAndLogServiceException(ex);
            }
        }
    }
}
