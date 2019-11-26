namespace alizen.Models
{
    //public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
    public class StoreDatabaseSettings : IStoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; }
        public string AcademiesCollectionName {get;set;}
        public string ProductsCollectionName { get; set; }
        public string InstructorsCollectionName {get;set;}
        public string UsersCollectionName {get;set;}
        /*
        public string BlogsCollectionName {get;set}
        public string CataloguesCollectionName {get;set}
        public string InstructorsCollectionName {get;set}
        public string PostsCollecions {get;set}
        public string UsersCollectionsName {get;set}
         */


        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IStoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string ProductsCollectionName { get; set; }
        string InstructorsCollectionName {get;set;}
        string UsersCollectionName {get;set;}
        //string BlogsCollectionName { get;set; }
        string AcademiesCollectionName {get;set;}
        /*
        string BlogsCollectionName {get;set}
        string CataloguesCollectionName {get;set}
        string InstructorsCollectionName {get;set}
        string PostsCollecions {get;set}
        string UsersCollectionsName {get;set}
         */
        
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}