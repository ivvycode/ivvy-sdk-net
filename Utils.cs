using System.Security.Cryptography;
using System.Text;

namespace Ivvy
{
    /// <summary>
    /// This class contains some utility methods.
    /// </summary>
    public sealed class Utils
    {
        private Utils()
        {
        }

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
        public readonly static string DateTimeFormat = "yyyy-MM-dd HH:mm:ss 'UTC'";

        /// <summary>
        /// Returns the MD5 hash of a string.
        /// </summary>
        public static string GetMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BytesToString(data);
        }

        /// <summary>
        /// Converts an array of bytes to a string.
        /// </summary>
        public static string BytesToString(byte[] data)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++) {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }

        /// <summary>
        /// Returns a sha1 hash of a string.
        /// </summary>
        public static string SignString(string stringToSign, string secret)
        {
            Encoding encoding = Encoding.UTF8;
            byte[] secretBytes = encoding.GetBytes(secret);
            HMACSHA1 hmacsha1 = new HMACSHA1(secretBytes);
            byte[] data = hmacsha1.ComputeHash(encoding.GetBytes(stringToSign));
            return BytesToString(data);
        }

        /// <summary>
        /// Returns the string representation of filtering a property.
        /// </summary>
        public static string GetFilterCondition(string propertyName, FilterCondition filterCondition)
        {
            return $"{propertyName}__{filterCondition.ToString().ToUpperInvariant()}";
        }
    }
}