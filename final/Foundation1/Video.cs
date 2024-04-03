using System;
using System.Collections.Generic;
using System.IO;
class Video
{
    public string Title{get;set; }
    
    public string Author{get; set;}
    public int LengthInSeconds{get; set;}
    private List<Comment> comments = new List<Comment>();

    
    public void AddComment(Comment comment)
    {
        
    }

    public int GetNumberOfComments()
    {
     return 0;   
    }

    
    public void DisplayInfo()
    {
        
        
    }
}