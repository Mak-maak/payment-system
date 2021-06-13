using System;
using System.Globalization;

namespace PaymentSystem.Common
{
    public static class Parse
    {
        public static T ParseTo<T>(this object obj) where T : IConvertible
        {
            if (obj != null)
            {
                string str = obj.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (typeof(T) == typeof(string))
                    {
                        return (T)Convert.ChangeType(str, typeof(T));
                    }

                    if (typeof(T) == typeof(int))
                    {
                        _ = int.TryParse(str, out int t);
                        return (T)Convert.ChangeType(t, typeof(T));
                    }

                    if (typeof(T) == typeof(long))
                    {
                        _ = long.TryParse(str, out long t);
                        return (T)Convert.ChangeType(t, typeof(T));
                    }

                    if (typeof(T) == typeof(double))
                    {
                        _ = double.TryParse(str, out double t);
                        return (T)Convert.ChangeType(t, typeof(T));
                    }

                    if (typeof(T) == typeof(bool))
                    {
                        bool t = str == "1" || str.ToLower() == "true";
                        return (T)Convert.ChangeType(t, typeof(T));
                    }

                    if (typeof(T) == typeof(DateTime))
                    {
                        DateTime.TryParseExact(str, Constants.JSON_DATE_TIME_FORMAT, null, DateTimeStyles.None,
                            out DateTime t);
                        return (T)Convert.ChangeType(t, typeof(T));
                    }

                    if (typeof(T) == typeof(Enum))
                    {
                        T value = (T)Enum.ToObject(typeof(T), obj.ParseTo<int>());
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                }
            }

            return default;
        }
    }
}