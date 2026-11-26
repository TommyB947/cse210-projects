using System;
using System.Net.Http.Headers;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, title)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string text = $"{_title} by {_studentName}";
        return text;
    }
}