using Backend.Model;
using Backend.Service;

using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class SuppliersController : ControllerBase {
    [HttpGet]
    public ActionResult<List<Supplier>> GetAll(string? name) {
        List<Supplier> suppliers = SupplierService.GetAll(name);

        if (suppliers.Count == 0) {
            return NoContent();
        }

        return suppliers;
    }

    [HttpGet("{id}")]
    public ActionResult<Supplier> Get(string id) {
        Supplier? supplier = SupplierService.Get(id);

        if (supplier == null) {
            return NoContent();
        }

        return supplier;
    }
}