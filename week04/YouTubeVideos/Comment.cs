using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Transactions;

class Comment
{
    private string _commenter;
    private string _commentText;

    public void CreateComment(string commenter, string commentText)
    {
        _commenter = commenter;
        _commentText = commentText; 
        //Console.WriteLine($"{_commenter}"); 
        //Console.WriteLine($"{_commentText}");
    }

    public string GetCommentText()
    {
        string commentText = $"{_commenter}: {_commentText}";

        //Console.WriteLine(commentText);
        return commentText;
    }
}