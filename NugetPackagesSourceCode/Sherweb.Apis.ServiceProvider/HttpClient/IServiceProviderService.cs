// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IServiceProviderService : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// GetCustomers (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of all your customers.
        /// </remarks>
        /// <param name='includeDeleted'>
        /// Specify if you want to retrieve deleted customers. Default: False.
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Customer>>> GetCustomersWithHttpMessagesAsync(bool? includeDeleted = false, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetReceivableCharges (beta)
        /// </summary>
        /// <remarks>
        /// Get the amounts that one of your customers owe you for a specific
        /// billing period. There are three types of charges that are included
        /// in the data returned: recurring, usage, and setup.
        /// </remarks>
        /// <param name='customerId'>
        /// </param>
        /// <param name='date'>
        /// Specify a date within the desired billing period. Format:
        /// yyyy-MM-dd (UTC). Default: Today. For example, if the date is March
        /// 17th and your billing period is from the 1st to the 31st of the
        /// month, it will return data from March 1st to March 31st.
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReceivableCharges>> GetReceivableChargesWithHttpMessagesAsync(System.Guid customerId, System.DateTime? date = default(System.DateTime?), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
