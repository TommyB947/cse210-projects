using System;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();



    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        //Console.WriteLine($"{_title}");
        //Console.WriteLine($"{_author}");
        //Console.WriteLine($"{_length}");
    }

    public Video(string title, string author)
    {
        _title = title;
        _author = author;

        //Console.WriteLine($"{_title}");
        //Console.WriteLine($"{_author}");
    }

    public Video(string title, int length)
    {
        _title = title;
        _length = length;

        //Console.WriteLine($"{_title}");
        //Console.WriteLine($"{_length}");
    }
    

    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        //Console.WriteLine($"{_comments.Count}"); 
    }

    public void SetAuthor(string authorName)
    {
        _author = authorName;
        //Console.WriteLine($"{_author}"); 
    }

    public void SetLength(int length)
    {
        _length = length;
        //Console.WriteLine($"{_length}"); 
    }

    public string GetVideoText()
    {
        string videoText = $"{_title} - {_author}: {_length} seconds ({_comments.Count} comments)";
        
        for (int i = 0; i < _comments.Count(); i++)
        {
            string commentText = _comments[i].GetCommentText();
            videoText += Environment.NewLine +$"Comment {i + 1}: {commentText}";
        }
        
        //Console.WriteLine($"{videoText}"); 
        return videoText;
    }

    public int GetCommentCount()
    {
        int count;
        count = _comments.Count();
        return count;
    }
}