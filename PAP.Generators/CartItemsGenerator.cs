using PAP.DataAccess;
namespace PAP.Generators { public class CartItemsGenerator:GeneratorBase { public override string EntityName => "CartItems"; public override string[] Dependencies => new string[] {"ShoppingCarts", "Books"}; protected override object Build(BookStoreDBEntities db) => Make<CartItem>("CartId", FirstId(db, "ShoppingCarts"), "BookId", FirstId(db, "Books"), "Quantity", 1); } }
