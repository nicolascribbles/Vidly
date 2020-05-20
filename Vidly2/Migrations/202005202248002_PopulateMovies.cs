namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {

            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (1, 'Hangover', 3, 5)");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (2, 'Die Hard', 2, 10)");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (3, 'The Terminator', 2, 3)");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (4, 'Toy Story', 1, 2)");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (5, 'Titanic', 4, 20)");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (6, 'Shrek', 1, 0)");
            Sql("INSERT INTO Movies(Id, Name, GenreId, NumberAvailable) VALUES (7, 'Wall-E', 1, 5)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
