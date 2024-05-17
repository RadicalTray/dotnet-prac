TODO:
    /products?params
    /products/id
    /stores?params
    /stores/id
    /stores/id/stock
    /employees?params
    /employees/id
DONE:
    /suppliers
    /suppliers?name
    /suppliers/id


// Using Npgsql (NON ENTITYFRAMEWORK)
// public static async void GetAllNpgsql() {
//     string connStr = "Host=localhost;Port=5432;Database=test;Username=postgres;Password=1234";
//     await using var dataSource = Npgsql.NpgsqlDataSource.Create(connStr);
//
//     await using (var command = dataSource.CreateCommand("SELECT * FROM suppliers"))
//     await using (var reader = await command.ExecuteReaderAsync()) {
//         while (await reader.ReadAsync()) {
//             for (int i = 0; i < reader.FieldCount; i++) {
//                 Console.Write(reader.GetString(i) + ' ');
//             }
//             Console.WriteLine();
//         }
//     }
// }
