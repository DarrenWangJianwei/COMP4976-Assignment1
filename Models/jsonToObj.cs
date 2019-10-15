namespace Books.Models
{
    public class jsonToObj
    {
        public AllofItems[] items {get;set;}
    }

    public class AllofItems
    {
        public string id {get;set;}
        public EachItem volumeInfo{get;set;}
    }
    public class EachItem
    {
        public string title {get;set;}
        public string[] authors {get;set;}
        public string publisher {get;set;}
        public string description {get;set;}
        public string publishedDate {get;set;}
        public IndustryIdentifiers[] industryIdentifiers {get;set;}
        public ImageLinks imageLinks {get;set;}
    }
    public class IndustryIdentifiers
    {
        public string type {get;set;}
        public string identifier {get;set;}
    }
    public class ImageLinks
    {
        public string smallThumbnail{get;set;}
    }
}