using CACI_Lib.Interfaces;
using CACI_Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CACI_Lib.Converters
{
    public class BinaryToIntConvertor : IConvertor
    {
        public string Convert(string InputVal)
        {
            ConvertorClass convertorClass = new ConvertorClass();
            convertorClass.InputVal = InputVal;
            String num = InputVal;
           
            // Empty string validation
            if (string.IsNullOrEmpty(convertorClass.InputVal))
            {
                convertorClass.ErrorText = "Error: Invalid input: Entered string is empty, please enter valid binary string";
                return convertorClass.ErrorText;
            }
            int dec_value = 0;

            // Initializing base value to 1, 

            // i.e 2^0 

            int base1 = 1;



            int strLen = convertorClass.InputVal.Length;

            for (int i = strLen - 1; i >= 0; i--)
            {

                if (convertorClass.InputVal[i] == '1')
                {

                    dec_value += base1;
                }

                base1 = base1 * 2;

            }

            if (dec_value == 0)
            {
                convertorClass.ErrorText = "Error: Invalid input: Entered string is not a binary string, please enter valid binary string";
                return convertorClass.ErrorText;

            }
            convertorClass.OutputVal = dec_value;

            return "Integer: " + convertorClass.OutputVal;

        }
        
    }
}

