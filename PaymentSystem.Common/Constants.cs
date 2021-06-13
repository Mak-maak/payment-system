using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace PaymentSystem.Common
{
    /// <summary>
    /// Application wide contant class to hold the constant variables
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Application wide date format
        /// </summary>
        public static readonly string JSON_DATE_TIME_FORMAT = "yyyy-MM-ssThh:mm:ss.fff";

        /// <summary>
        /// Collection of services that are up for dependency injection
        /// </summary>
#pragma warning disable CA2211 // Non-constant fields should not be visible
        public static List<ServiceDescriptor> ServiceDescriptors = new();
#pragma warning restore CA2211 // Non-constant fields should not be visible

        /// <summary>
        /// Default pagination size
        /// </summary>
        public const int DEFAULT_PAGE_COUNT = 2000;
    }
}