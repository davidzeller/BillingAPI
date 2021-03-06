// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BillingAPI
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReservedInstancesV3.
    /// </summary>
    public static partial class ReservedInstancesV3Extensions
    {
            /// <summary>
            /// Gets the reservation charges for the provided start and endDate
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentNumber'>
            /// The enrollment number
            /// </param>
            /// <param name='startDate'>
            /// </param>
            /// <param name='endDate'>
            /// </param>
            public static IList<RIPurchaseHistoryV3Properties> Get(this IReservedInstancesV3 operations, string enrollmentNumber, System.DateTime startDate, System.DateTime endDate)
            {
                return operations.GetAsync(enrollmentNumber, startDate, endDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the reservation charges for the provided start and endDate
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentNumber'>
            /// The enrollment number
            /// </param>
            /// <param name='startDate'>
            /// </param>
            /// <param name='endDate'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RIPurchaseHistoryV3Properties>> GetAsync(this IReservedInstancesV3 operations, string enrollmentNumber, System.DateTime startDate, System.DateTime endDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(enrollmentNumber, startDate, endDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
