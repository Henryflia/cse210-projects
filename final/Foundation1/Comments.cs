public class Comments
{
    public string _comment= "";
    public string _name= "";

    public Comments(string name, string comment){
        _comment = comment;
        _name = name;
    }
    public static void AddComment(Video video, string name, string comment)
    {
        Comments m = new Comments(name, comment);
        video.comments.Add(m);
    }
}