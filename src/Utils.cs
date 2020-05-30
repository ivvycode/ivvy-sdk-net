using System.Security.Cryptography;
using System.Text;

namespace Ivvy.API
{
    /// <summary>
    /// This class contains some utility methods.
    /// </summary>
    public static class Utils
    {
        public enum FilterCondition
        {
            Contains​, // Return the results that contain the value.
            Notcontains​, // Return the results that do not contain the value.
            Begins​, // Return the results that start with the value.
            Ends​, //Return the results that end with the value.
            Lessthan​, //Return the results that are less than or equal to the value.
            Greaterthan​, //Return the results that are greater than or equal to the
            Not​, //Return the results that are not equal to the value.
            Empty​ //Returns results that are empty
        }

        /// <summary>
        /// The format used for datetime values.
        /// </summary>
        public static readonly string DateTimeFormat = "yyyy-MM-dd HH:mm:ss 'UTC'";

        /// <summary>
        /// Returns the MD5 hash of a string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string GetMD5Hash(string input)
        {
            var md5 = MD5.Create();
            var data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BytesToString(data);
        }

        /// <summary>
        /// Converts an array of bytes to a string.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static string BytesToString(byte[] data)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }

        /// <summary>
        /// Returns a sha1 hash of a string.
        /// </summary>
        /// <param name="stringToSign">The string to sign.</param>
        /// <param name="secret">The secret.</param>
        /// <returns></returns>
        public static string SignString(string stringToSign, string secret)
        {
            var encoding = Encoding.UTF8;
            var secretBytes = encoding.GetBytes(secret);
            var hmacsha1 = new HMACSHA1(secretBytes);
            var data = hmacsha1.ComputeHash(encoding.GetBytes(stringToSign));
            return BytesToString(data);
        }

        /// <summary>
        /// Returns the string representation of filtering a property.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="filterCondition">The filter condition.</param>
        /// <returns></returns>
        public static string GetFilterCondition(string propertyName, FilterCondition filterCondition)
        {
            return $"{propertyName}__{filterCondition.ToString().ToUpperInvariant()}";
        }
    }
}