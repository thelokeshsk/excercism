static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {    
        double percentage = 0;
        if(speed >= 1 && speed <= 4){
            percentage = 100;
        } 
        else if(speed >= 5 && speed <= 8){
            percentage = 90;
        }
        else if(speed == 9){
            percentage = 80;
        }
        else if(speed == 10){
            percentage = 77;
        }
        else {
            percentage = 0;
        }
        return percentage / 100;
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);


    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) /60;

}
