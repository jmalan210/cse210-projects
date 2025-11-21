public class User
{
    private string _userName;
    private int _activityCount;

    public User(string userName)
    {
        _userName = userName;
        _activityCount = 0;

    }

    public string GetUserName()
    {
        return _userName;
    }

    public int GetActivityCount()
    {
        return _activityCount;
    }

    public void AddActivity()
    {
        _activityCount++;
    }



}

