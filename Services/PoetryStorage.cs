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

    public async Task InitializeAsync() =>await Connection.CreateTableAsync<Poetry>();
  

    public async Task SavePeotryAsync(Poetry postry)
    {
        throw new NotImplementedException();
    }

    public async Task<Poetry> GetPoetryAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Poetry>> SearchByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

}