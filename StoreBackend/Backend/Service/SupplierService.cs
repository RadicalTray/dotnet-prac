using Backend.Model;
using Backend.Database;

namespace Backend.Service;

public static class SupplierService {

    // Using Npgsql.EntityFrameworkCore.PostgreSQL
    // See also class SupplierContext
    public static List<Supplier>? GetAll() {
        using (var context = new SupplierContext()) {
            Console.WriteLine(context.Model.ToDebugString());

            List<Supplier>? result = context.suppliers?.ToList<Supplier>();

            if (result == null) return null;

            foreach (var supplier in result) {
                Console.WriteLine(supplier.Id + ' ' + supplier.Name + ' ' + supplier.Address);
            }

            return result;
        }
    }

    // Using Npgsql
    public static async void GetAllNpgsql() {
        string connStr = "Host=localhost;Port=5432;Database=test;Username=postgres;Password=1234";
        await using var dataSource = Npgsql.NpgsqlDataSource.Create(connStr);

        await using (var command = dataSource.CreateCommand("SELECT * FROM suppliers"))
        await using (var reader = await command.ExecuteReaderAsync()) {
            while (await reader.ReadAsync()) {
                for (int i = 0; i < reader.FieldCount; i++) {
                    Console.Write(reader.GetString(i) + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}