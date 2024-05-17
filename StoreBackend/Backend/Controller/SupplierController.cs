using Backend.Model;
using Backend.Service;

using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class SuppliersController : ControllerBase {
    [HttpGet]
    public List<Supplier>? GetAll() => SupplierService.GetAll();
}