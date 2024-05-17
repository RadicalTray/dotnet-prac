using Backend.Database;
using Backend.Model;

namespace Backend.Service;

public static class SupplierService {

    public static List<Supplier> GetAll(string name) {
        using (var context = new StoreContext()) {
            return context.suppliers.Where<Supplier>(s => s.Name.Contains(name)).ToList<Supplier>();
        }
    }

    public static Supplier? Get(string id) {
        using (var context = new StoreContext()) {
            return context.suppliers.Find(id);
        }
    }
}