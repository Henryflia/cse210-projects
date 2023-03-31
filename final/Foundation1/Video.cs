public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length;
    public List<Comments> comments = new List<Comments>();
    
    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;

    }
    public int NumberofComments(){
        return comments.Count;
    }
    public void DisplayInformation(){

    }

}
