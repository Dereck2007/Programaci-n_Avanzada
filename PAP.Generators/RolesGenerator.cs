using PAP.DataAccess;
namespace PAP.Generators { public class RolesGenerator:GeneratorBase { public override string EntityName => "Roles"; public override string[] Dependencies => new string[] {}; protected override object Build(BookStoreDBEntities db) => Make<Role>("Name", "Admin"); } }
