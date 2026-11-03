using PAP.DataAccess;
namespace PAP.Generators { public class InventoryGenerator:GeneratorBase { public override string EntityName => "Inventory"; public override string[] Dependencies => new string[] {"Books"}; protected override object Build(BookStoreDBEntities db) => Make<Inventory>("BookId", FirstId(db, "Books"), "QuantityInStock", 15, "ReorderLevel", 5); } }
