using PAP.DataAccess;
namespace PAP.Generators { public class AuthorsGenerator:GeneratorBase { public override string EntityName => "Authors"; public override string[] Dependencies => new string[] {}; protected override object Build(BookStoreDBEntities db) => Make<Author>("FirstName", "Ana", "LastName", "Mora", "Biography", "Autora de ejemplo", "BirthDate", null, "Country", "Costa Rica"); } }
