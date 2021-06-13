using Mapster;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace PaymentSystem.Common
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Convert any valid string to its json representative object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T Deserialize<T>(this string str)
        {
            return JsonSerializer.Deserialize<T>(str);
        }

        public static object Deserialize(this string str, Type type)
        {
            return JsonSerializer.Deserialize(str, type);
        }

        public static string Serialize(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        public static DateTime ToSystemDateTime(this DateTime dateTime)
        {
            return dateTime.ToUniversalTime();
        }

        public static string ParseToString(this object obj)
        {
            if (obj is DateTime dateTime)
            {
                return dateTime.ToString(Constants.JSON_DATE_TIME_FORMAT);
            }

            return obj.ToString();
        }

        public static T MapTo<T>(this object source) where T : new()
        {
            TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
            return source.Adapt<T>();
        }

        public static long GetDigits(this string str)
        {
            return Regex.Match(str, @"\d+").Value.ParseTo<long>();
        }
    }
}