using HelleNetMaui.Models;
using SQLite;

namespace HelleNetMaui.Services;

public class PoetryStorage : IPoetryStorage
{

    public const string DbName = "poetrydb.sqlite3";

    public static readonly string PoetryDbPath =
        //软编码
        Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),DbName);
    
    private SQLiteAsyncConnection _connection;
        
    
    private SQLiteAsyncConnection Connection => _connection 
        ??= new SQLiteAsyncConnection(PoetryDbPath);

    /*    {
            get { 
                if(_connection == null)
                {
                    _connection = new SQLiteAsyncConnection(PoetryDbPath);
                }
                return _connection;
            }
        }*/


    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public async Task InitializeAsync() 
        =>await Connection.CreateTableAsync<Poetry>();


    public async Task SavePoetryAsync(Poetry poetry) =>
        await Connection.InsertAsync(poetry);

    public async Task<Poetry> GetPoetryAsync(int id) =>
        await Connection.Table<Poetry>()
            .FirstOrDefaultAsync(p => p.Id == id);

    public async Task<IEnumerable<Poetry>> SearchByNameAsync(string name) =>
        await Connection.Table<Poetry>()
            .Where(p => p.Name.Contains(name))
            .ToListAsync();

}