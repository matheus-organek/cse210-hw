public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Constructor to initialize the Video object with a title, author, and length.
    public Video(string title, string author, int length)
    {
        _title = title; 
        _author = author;
        _length = length;
        _comments = new List<Comment>();   
    }

    // Method to add a comment to the list of comments associated with the video.
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text); // Creating a new Comment object with the provided name and text.
        _comments.Add(comment); // Adding the newly created comment to the list of comments.
    }

    // Method to get the number of comments associated with the video.
    public int NumberOfComments()
    {
        return _comments.Count; // Returning the count of comments in the _comments list.
    }

    // Method to get a formatted list of comments associated with the video.
    public string ListOfComments()
    {
        List<string> commentStrings = new List<string>(); // Creating a new List<string> to store formatted comment strings.
        foreach (Comment comment in _comments) // Iterating through each comment in the _comments list.
        {
            commentStrings.Add($"Name: {comment.GetName()}, Text: {comment.GetText()}"); // Formatting and adding the comment information to the commentStrings list.
        }
        return string.Join(Environment.NewLine, commentStrings); // Joining the comment strings with newline characters and returning the result.
    }

    // Method to display information about the video including title, author, length, number of comments, and the list of comments.
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}"); // Displaying the title of the video.
        Console.WriteLine($"Author: {_author}"); // Displaying the author of the video.
        Console.WriteLine($"Length: {_length} seconds"); // Displaying the length of the video.
        Console.WriteLine($"Number of comments: {NumberOfComments()}"); // Displaying the number of comments associated with the video.
        Console.WriteLine("Comments:"); // Displaying a header for the comments section.
        Console.WriteLine(ListOfComments()); // Displaying the formatted list of comments associated with the video.
        Console.WriteLine(); // Outputting a blank line for better readability.
    }
}