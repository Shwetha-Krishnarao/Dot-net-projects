private static String ConvertWholeNumber(String Number)  
{  
    string word = "";  
    try  
    {  
        bool beginsZero = false;//tests for 0XX    
        bool isDone = false;//test if already translated    
        double dblAmt = (Convert.ToDouble(Number));  
        //if ((dblAmt > 0) && number.StartsWith("0"))    
        if (dblAmt > 0)  
        {//test for zero or digit zero in a nuemric    
            beginsZero = Number.StartsWith("0");  
  
            int numDigits = Number.Length;  
            int pos = 0;//store digit grouping    
            String place = "";//digit grouping name:hundres,thousand,etc...    
            switch (numDigits)  
            {  
                case 1://ones' range    
  
                    word = ones(Number);  
                    isDone = true;  
                    break;  
                case 2://tens' range    
                    word = tens(Number);  
                    isDone = true;  
                    break;  
                case 3://hundreds' range    
                    pos = (numDigits % 3) + 1;  
                    place = " Hundred ";  
                    break;  
                case 4://thousands' range    
                case 5:  
                case 6:  
                    pos = (numDigits % 4) + 1;  
                    place = " Thousand ";  
                    break;  
                case 7://millions' range    
                case 8:  
                case 9:  
                    pos = (numDigits % 7) + 1;  
                    place = " Million ";  
                    break;  
                case 10://Billions's range    
                case 11:  
                case 12:  
  
                    pos = (numDigits % 10) + 1;  
                    place = " Billion ";  
                    break;  
                //add extra case options for anything above Billion...    
                default:  
                    isDone = true;  
                    break;  
            }  
            if (!isDone)  
            {//if transalation is not done, continue...(Recursion comes in now!!)    
                if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")  
                {  
                    try  
                    {  
                        word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));  
                    }  
                    catch { }  
                }  
                else  
                {  
                    word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));  
                }  
  
                //check for trailing zeros    
                //if (beginsZero) word = " and " + word.Trim();    
            }  
            //ignore digit grouping names    
            if (word.Trim().Equals(place.Trim())) word = "";  
        }  
    }  
    catch { }  
    return word.Trim();  
}


private static String ConvertWholeNumber(String Number)  
{  
    string word = "";  
    try  
    {  
        bool beginsZero = false;//tests for 0XX    
        bool isDone = false;//test if already translated    
        double dblAmt = (Convert.ToDouble(Number));  
        //if ((dblAmt > 0) && number.StartsWith("0"))    
        if (dblAmt > 0)  
        {//test for zero or digit zero in a nuemric    
            beginsZero = Number.StartsWith("0");  
  
            int numDigits = Number.Length;  
            int pos = 0;//store digit grouping    
            String place = "";//digit grouping name:hundres,thousand,etc...    
            switch (numDigits)  
            {  
                case 1://ones' range    
  
                    word = ones(Number);  
                    isDone = true;  
                    break;  
                case 2://tens' range    
                    word = tens(Number);  
                    isDone = true;  
                    break;  
                case 3://hundreds' range    
                    pos = (numDigits % 3) + 1;  
                    place = " Hundred ";  
                    break;  
                case 4://thousands' range    
                case 5:  
                case 6:  
                    pos = (numDigits % 4) + 1;  
                    place = " Thousand ";  
                    break;  
                case 7://millions' range    
                case 8:  
                case 9:  
                    pos = (numDigits % 7) + 1;  
                    place = " Million ";  
                    break;  
                case 10://Billions's range    
                case 11:  
                case 12:  
  
                    pos = (numDigits % 10) + 1;  
                    place = " Billion ";  
                    break;  
                //add extra case options for anything above Billion...    
                default:  
                    isDone = true;  
                    break;  
            }  
            if (!isDone)  
            {//if transalation is not done, continue...(Recursion comes in now!!)    
                if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")  
                {  
                    try  
                    {  
                        word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));  
                    }  
                    catch { }  
                }  
                else  
                {  
                    word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));  
                }  
  
                //check for trailing zeros    
                //if (beginsZero) word = " and " + word.Trim();    
            }  
            //ignore digit grouping names    
            if (word.Trim().Equals(place.Trim())) word = "";  
        }  
    }  
    catch { }  
    return word.Trim();  
}

private static String ConvertDecimals(String number)  
{  
    String cd = "", digit = "", engOne = "";  
    for (int i = 0; i < number.Length; i++)  
    {  
        digit = number[i].ToString();  
        if (digit.Equals("0"))  
        {  
            engOne = "Zero";  
        }  
        else  
        {  
            engOne = ones(digit);  
        }  
        cd += " " + engOne;  
    }  
    return cd;  
}
