class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) 
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastweeek = {0,2,5,3,7,8,4};
        return lastweeek;
    }

    public int Today() => birdsPerDay[birdsPerDay.Length-1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length-1]+=1;

    public bool HasDayWithoutBirds()
    {
        foreach(int birdCount in birdsPerDay)
        {
            if(birdCount==0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int result=0;
        for(int i=0; i<numberOfDays; i++)
        {
            result+=birdsPerDay[i];
        }
        return result;
    }

    public int BusyDays()
    {
        int count=0;
        foreach(int birdCount in birdsPerDay){
            if(birdCount>=5){
                count++;
            }
        }
        return count;
    }
}
