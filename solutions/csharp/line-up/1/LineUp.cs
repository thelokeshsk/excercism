public static class LineUp
{
    public static string OrdinalNumber(int number){
        if(number%10 == 1 && number%100 != 11){
            return "st";
        }
        else if(number%10 == 2 && number%100 != 12){
            return "nd";
        }
        else if(number%10 == 3 && number%100 != 13){
            return "rd";
        }
        else{
            return "th";
        }
    }
    
    public static string Format(string name, int number)
    {
        string ordinalNumber = OrdinalNumber(number);
        return $"{name}, you are the {number}{ordinalNumber} customer we serve today. Thank you!";
    }
}
