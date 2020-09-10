namespace Udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Walley', 'Comedy', '2014-11-01 00:00:00', '2014-11-01 00:00:004', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Die Hard', 'Action', '1995-1-11 00:00:00', '1995-11-01 00:00:004', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Titanic', 'Romance', '2000-1-09 00:00:00', '2000-11-01 00:00:004', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
