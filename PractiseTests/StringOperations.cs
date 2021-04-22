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

        ///

        /// </summary>

        /// <param name="firstname">James</param>

        /// <param name="lastname">Anderson</param>

        /// <returns>

        /// Anderson , James

        /// </returns>

        public string Concat(string firstname, string lastname)

        {

            if(firstname == null)

            {

                throw new ArgumentNullException(nameof(firstname));

            }

 

            if (lastname == null)

            {

                throw new ArgumentNullException(nameof(lastname));

            }


            return $"{lastname} , {firstname}";
        }

   }
}
