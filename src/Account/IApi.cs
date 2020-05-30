using Ivvy.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Subscribes to account notifications.
        /// </summary>
        Task<ResultOrError<Account.NotificationsResult>> SubscribeToNotifications(
            string eventsEndpoint,
            string venuesEndpoint,
            string paymentsEndpoint,
            string crmEndpoint,
            string contactsEndpoint,
            string companiesEndpoint);

        /// <summary>
        /// Returns the list of custom field definitions in an account.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<List<CustomField>>> GetCustomFieldDefinition();

        /// <summary>
        /// Returns the list of subscription groups in an account.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync();

        /// <summary>
        /// Returns a collection of emails in an account.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<EmailLog>>> GetEmailLogList(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest);

        /// <summary>
        /// Adds an error report to an account.
        /// <param name="report">The error report details.</param>
        /// </summary>
        Task<ResultOrError<ResultObject>> AddErrorReport(ErrorReport report);

        /// <summary>
        /// Returns a collection of cost centers in an account.
        /// </summary>
        Task<ResultOrError<ResultList<CostCenter>>> GetCostCenterListAsync();
    }
}
