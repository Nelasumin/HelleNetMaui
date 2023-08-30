

using SQLite;

namespace HelleNetMaui.Models;


public class Poetry
{
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }

    public string Name { get; set; }

    public int Content { get; set; }



}
