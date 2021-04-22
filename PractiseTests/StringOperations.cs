using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTests
{
    public class StringOperations
    {
        /// <summary>

        /// <param name="firstname">James</param>

        /// <param name="lastname">Anderson</param>

        /// <returns>

        /// Anderson , James

        /// </returns>

        /// </summary>
        public string Concat(string firstname, string lastname)
        {
            if(string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentNullException(nameof(firstname));
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentNullException(nameof(lastname));
            }
            return $"{lastname} , {firstname}";
        }

   }
}
