using Ivvy.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api : IApi
    {
        /// <summary>
        /// Subscribes to account notifications.
        /// </summary>
        public async Task<ResultOrError<NotificationsResult>> SubscribeToNotifications(
            string eventsEndpoint,
            string venuesEndpoint)
        {
            return await this.CallAsync<NotificationsResult>(
                "account", "subscribeToNotifications", new
                {
                    eventsEndpoint = eventsEndpoint,
                    venuesEndpoint = venuesEndpoint
                }
            );
        }

        /// <summary>
        /// Returns the list of custom field definitions in an account.
        /// </summary>
        public async Task<ResultOrError<List<CustomField>>> GetCustomFieldDefinition()
        {
            return await this.CallAsync<List<CustomField>>(
                "contact", "getCustomFieldDefinition", new { }
            );
        }

        /// <summary>
        /// Returns the list of subscription groups in an account.
        /// </summary>
        public async Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync()
        {
            return await this.CallAsync<List<SubscriptionGroup>>(
                "contact", "getSubscriptionGroupList", new { }
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
                    perPage = perPage,
                    start = start,
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

        /// <summary>
        /// Returns a collection of cost centers in an account.
        /// </summary>
        public async Task<ResultOrError<ResultList<CostCenter>>> GetCostCenterListAsync()
        {
            var result = await CallAsync<ResultList<CostCenter>>(
                "account", "getCostCenterList", null);

            return result;
        }
    }
}
