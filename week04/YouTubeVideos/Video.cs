using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
   
    public List<Comment> _comments = new List<Comment>();
    public string _title;
    public string _author;
    public int _lengthInSec;
    public int _numOfComments;

    
    public string ConvertTime() {
        TimeSpan time = TimeSpan.FromSeconds(_lengthInSec);
        return time.ToString(@"hh\:mm\:ss");

    }
    public int GetNumComments()
    {
        _numOfComments = _comments.Count;
        return _numOfComments;
    }

    public string DisplayVideoInfoAndComments()
    {
        string length = ConvertTime();
        int numOfComments = GetNumComments();




        string videoInfo = $"Title: {_title}\nAuthor: {_author}\nLength: {length}\nNumber of Comments: {numOfComments}";

        foreach (var c in _comments)
        {
            videoInfo += c.DisplayCommentText();
        }

        return videoInfo;

    }
    
    
    




}