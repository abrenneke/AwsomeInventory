﻿#if UnitTest
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace RPG_Inventory_Remake_Common.UnitTest
{
    public abstract class RPGIUnitTest
    {
        string FullName;
        public List<RPGIUnitTest> Tests = new List<RPGIUnitTest>();
        public Dictionary<string, bool> TestResults = new Dictionary<string, bool>();

        public RPGIUnitTest()
        {
            FullName = GetType().FullName;
        }

        public virtual void Setup() { }
        public virtual void Cleanup() { }

        public virtual void Run(out bool result)
        {
            if (Tests.Any())
            {
                foreach (RPGIUnitTest test in Tests)
                {
                    result = test.Start();
                    TestResults.Add(test.GetType().FullName, result);
                }
            }
            if (TestResults.Any() && TestResults.Values.All(b => b == true))
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        public virtual bool Start()
        {
            try
            {
                Setup();
                Run(out bool result);
                Cleanup();

                return result;
            }
            catch (Exception e)
            {
                Log.Error(e.Message + e.StackTrace);
            }
            return false;
        }

        public static void Report(RPGIUnitTest tests, ref StringBuilder sb, string indent = "")
        {
            if (tests == null || !tests.Tests.Any())
            {
                return;
            }

            sb.Append(indent);
            sb.AppendLine(string.Format(StringResource.TestCountSum, tests.FullName, tests.Tests.Count));
            foreach (RPGIUnitTest test in tests.Tests)
            {
                sb.Append(indent);
                sb.Append(StringResource.Indent);
                sb.AppendLine(string.Format(StringResource.KeyValuePair, test.FullName, tests.TestResults[test.FullName]));
                Report(test, ref sb, string.Concat(indent, StringResource.Indent));
            }
        }
    }
}
#endif