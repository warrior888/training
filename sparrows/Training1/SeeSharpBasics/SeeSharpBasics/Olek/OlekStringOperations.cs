﻿using System;

namespace SeeSharpBasics.Olek
{
    public class OlekStringOperations : StringOperations

    {
        public static string Substring(string candidate, int start, int length)
        {
            //throw new System.NotImplementedException();
            string result = "";

            //Substring("beatka", 1, 3); eat
            //Substring("bartek", 2, 4); rtek
            //Substring("aleksander", 5, 2);  an
            //for (int i = start; i < ((candidate.Length - length)+1); i++)
            //for (int i = start; i < (candidate.Length - (candidate.Length-length))+1; i++)
            //for (int i = start; i < length+1; i++)

            for (int i = start; i < start + length; i++)
            {
                result = candidate[i].ToString();
                Console.Write(result);
            }
            return result;
        }

        }

        public override string GetName()
        {
            throw new System.NotImplementedException();
        }

        public override string GlueBeginingEnd(string candidate)
        {
            throw new System.NotImplementedException();
        }

        public override int CountOccurences(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            throw new System.NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            throw new System.NotImplementedException();
        }
    }
}