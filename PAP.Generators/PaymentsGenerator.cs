using PAP.DataAccess;
namespace PAP.Generators { public class PaymentsGenerator:GeneratorBase { public override string EntityName => "Payments"; public override string[] Dependencies => new string[] {"Orders"}; protected override object Build(BookStoreDBEntities db) => Make<Payment>("OrderId", FirstId(db, "Orders"), "PaymentMethod", "Cash", "Amount", 1130.0, "Status", "Completed"); } }
