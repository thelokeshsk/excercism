public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = phoneNumber.StartsWith("212");
        bool isFake = phoneNumber.IndexOf("555") == 4;
        string LocalNumber = phoneNumber[8..];
        return (isNewYork,isFake,LocalNumber);
            
        
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)=> phoneNumberInfo.IsFake;

}
