using System.Collections.Generic;
using System.Threading.Tasks;
using Ivvy.API.Account;

namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <summary>
        /// Subscribes to account notifications.
        /// </summary>
        public async Task<ResultOrError<NotificationsResult>> SubscribeToNotifications(
            string eventsEndpoint,
            string venuesEndpoint,
            string paymentsEndpoint,
            string crmEndpoint,
            string contactsEndpoint,
            string companiesEndpoint)
        {
            return await CallAsync<NotificationsResult>(
                "account", "subscribeToNotifications", new
                {
                    eventsEndpoint,
                    venuesEndpoint,
                    paymentsEndpoint,
                    crmEndpoint,
                    contactsEndpoint,
                    companiesEndpoint
                }
            );
        }

        /// <summary>
        /// Returns the list of custom field definitions in an account.
        /// </summary>
        public async Task<ResultOrError<List<CustomField>>> GetCustomFieldDefinition()
        {
            return await CallAsync<List<CustomField>>(
                "contact", "getCustomFieldDefinition", new
                {
                }
            );
        }

        /// <summary>
        /// Returns the list of subscription groups in an account.
        /// </summary>
        public async Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync()
        {
            return await CallAsync<List<SubscriptionGroup>>(
                "contact", "getSubscriptionGroupList", new
                {
                }
            );
        }

        /// <summary>
        /// Returns a collection of emails in an account.
        /// </summary>
        public async Task<ResultOrError<ResultList<EmailLog>>> GetEmailLogList(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<EmailLog>>(
                "account", "getEmailLogList", new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddErrorReport(ErrorReport report)
        {
            return await CallAsync<ResultObject>(
                "account", "addErrorReport", report
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<CostCenter>>> GetCostCenterListAsync()
        {
            return await CallAsync<ResultList<CostCenter>>(
                "account", "getCostCenterList", null);
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<User>>> GetUserListAsync(
            int perPage,
            int start,
            int? venueId)
        {
            return await CallAsync<ResultList<User>>(
                "account", "getUserList", new
                {
                    venueId,
                    perPage,
                    start,
                }
            );
        }
    }
}