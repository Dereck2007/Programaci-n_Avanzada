using PAP.DataAccess;
namespace PAP.Generators { public class CategoriesGenerator:GeneratorBase { public override string EntityName => "Categories"; public override string[] Dependencies => new string[] {}; protected override object Build(BookStoreDBEntities db) => Make<Category>("Name", "Ficción", "Description", "Categoría de ejemplo"); } }
