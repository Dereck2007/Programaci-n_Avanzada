using PAP.DataAccess;
namespace PAP.Generators { public class GenresGenerator:GeneratorBase { public override string EntityName => "Genres"; public override string[] Dependencies => new string[] {}; protected override object Build(BookStoreDBEntities db) => Make<Genre>("Name", "Aventura", "Description", "Género de ejemplo"); } }
