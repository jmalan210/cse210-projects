public class Comment
{
    public string _userName;
    public string _text;

    public string DisplayCommentText()
    {
        string userName = _userName;
        string text = _text;
        string commentText = $"\n\nUser Name: {userName}\nComment: {text}";
        return commentText;
}

}

