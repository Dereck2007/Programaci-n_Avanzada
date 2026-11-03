using PAP.DataAccess;
namespace PAP.Generators { public class PurchaseOrdersGenerator:GeneratorBase { public override string EntityName => "PurchaseOrders"; public override string[] Dependencies => new string[] {"Suppliers"}; protected override object Build(BookStoreDBEntities db) => Make<PurchaseOrder>("SupplierId", FirstId(db, "Suppliers"), "Status", "Pending", "TotalCost", 1000.0); } }
