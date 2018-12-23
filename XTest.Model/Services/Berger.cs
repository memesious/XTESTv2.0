﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest.Model.Services
{
    public static class Berger
    {
        static Random rnd = new Random();

        public static string generateDecode()
        {
            return encode(generateEncode());
        }

        public static string generateEncode()
        {
            string result = "";
            for (int i = 0; i < rnd.Next(6, 150); i++)
            {
                result += rnd.Next(2);
            }
            return result;
        }

        public static bool isEncodedCorrectly(string task, string result)
        {
            return result.Equals(encode(task));
        }

        public static bool isDecodedCorrectly(string task, string result)
        {
            return result.Equals(decode(task));
        }

        public static string encode(string input)
        {
            int r = (int) Math.Ceiling(Math.Log(input.Length, 2));
            int count = ~input.Count(c => c == '1');
            string addition = Convert.ToString(count, 2);
            addition = addition.Substring(addition.Length - r);
            while (addition.Length < r)
            {
                addition = "1" + addition;
            }
            return input + addition;
        }

        public static string decode(string input)
        {
            return "";
        }
    }
}
