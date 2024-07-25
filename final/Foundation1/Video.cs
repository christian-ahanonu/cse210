using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length; 
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    } 

    public void AddComment(Comment userComments) // add comments to a list
    {
        _comments.Add(userComments);
    }

    public int GetCommentCount() // return total number of comment
    {
        return _comments.Count;
    }

    public List<Comment> GetComments() // returns a list containing user comments
    {
        return _comments;
    }
}