using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using PAP.Business;
namespace PAP.Mvc.Controllers
{
 public abstract class EntityCrudController<TEntity> : Controller where TEntity:class,new()
 {
  protected readonly EntityManager<TEntity> Manager = new EntityManager<TEntity>();
  private static bool IsScalar(Type t) { t=Nullable.GetUnderlyingType(t) ?? t; return t.IsPrimitive || t.IsEnum || t==typeof(string) || t==typeof(decimal) || t==typeof(DateTime) || t==typeof(Guid); }
  private List<PropertyInfo> Fields() => typeof(TEntity).GetProperties().Where(p=>p.CanRead && p.CanWrite && IsScalar(p.PropertyType) && !string.Equals(p.Name,"Id",StringComparison.OrdinalIgnoreCase)).ToList();
  private void Bind(TEntity entity, FormCollection form) { foreach(var p in Fields()) { var raw=form[p.Name]; if(raw==null) continue; var target=Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType; try { object val=String.IsNullOrWhiteSpace(raw) && Nullable.GetUnderlyingType(p.PropertyType)!=null ? null : TypeDescriptor.GetConverter(target).ConvertFromString(raw); p.SetValue(entity,val,null); } catch { ModelState.AddModelError(p.Name,"Valor no válido."); } } }
  private void Prepare(TEntity entity) { ViewBag.EntityName=typeof(TEntity).Name; ViewBag.Fields=Fields().Select(p=>p.Name).ToList(); ViewBag.Entity=entity; }
  public ActionResult Index() { ViewBag.EntityName=typeof(TEntity).Name; ViewBag.Fields=typeof(TEntity).GetProperties().Where(p=>p.CanRead && IsScalar(p.PropertyType)).Select(p=>p.Name).ToList(); return View("~/Views/Shared/EntityIndex.cshtml",Manager.GetAll().Cast<object>().ToList()); }
  public ActionResult Details(int id) { var item=Manager.GetById(id); if(item==null)return HttpNotFound(); Prepare(item); return View("~/Views/Shared/EntityDetails.cshtml",item); }
  [HttpGet] public ActionResult Create() { Prepare(new TEntity()); return View("~/Views/Shared/EntityForm.cshtml"); }
  [HttpPost,ValidateAntiForgeryToken] public ActionResult Create(FormCollection form) { var item=new TEntity(); Bind(item,form); if(!ModelState.IsValid){Prepare(item);return View("~/Views/Shared/EntityForm.cshtml");} Manager.Add(item); TempData["Mensaje"]="Registro agregado correctamente."; return RedirectToAction("Index"); }
  [HttpGet] public ActionResult Edit(int id) { var item=Manager.GetById(id); if(item==null)return HttpNotFound(); Prepare(item); return View("~/Views/Shared/EntityForm.cshtml"); }
  [HttpPost,ValidateAntiForgeryToken] public ActionResult Edit(int id,FormCollection form) { var item=Manager.GetById(id); if(item==null)return HttpNotFound(); Bind(item,form); if(!ModelState.IsValid){Prepare(item);return View("~/Views/Shared/EntityForm.cshtml");} Manager.Update(item); TempData["Mensaje"]="Registro actualizado."; return RedirectToAction("Index"); }
  [HttpPost,ValidateAntiForgeryToken] public ActionResult Delete(int id) { Manager.Delete(id); TempData["Mensaje"]="Registro eliminado."; return RedirectToAction("Index"); }
 }
}
