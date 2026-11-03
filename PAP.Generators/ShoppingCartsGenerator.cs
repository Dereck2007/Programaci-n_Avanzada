using PAP.DataAccess;
namespace PAP.Generators { public class ShoppingCartsGenerator:GeneratorBase { public override string EntityName => "ShoppingCarts"; public override string[] Dependencies => new string[] {"Customers"}; protected override object Build(BookStoreDBEntities db) => Make<ShoppingCart>("CustomerId", FirstId(db, "Customers")); } }
