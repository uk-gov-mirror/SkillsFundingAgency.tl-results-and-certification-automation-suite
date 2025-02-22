﻿using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using System;
using System.Collections.Generic;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class UlnHelper
    {
        public static long GenerateUln()
        {
            // Step 1: Get all Ulns
            List<long> existingUlns = GetExistingUlns();
            Random random = new Random();
            // Step 2: Random number Genera
            bool sameUln = true;
            long result = 0;
            while (sameUln)
            {
                result = 9800000000 + random.Next(10000000, 98999999);
                sameUln = existingUlns.Contains(result);
            }
            //Console.WriteLine("Random number is: " + result);
            return result;
        }

        private static List<long> GetExistingUlns()
        {
            return SqlQueries.UlnListFromDb();
        }
    }
}
