

using HelleNetMaui.Models;

namespace HelleNetMaui.Services;

public interface IPoetryStorage
{
    //初始化数据库 异步业务
    Task InitializeAsync();

    Task SavePoetryAsync(Poetry poetry);
    Task<Poetry> GetPoetryAsync(int id);

    Task<IEnumerable<Poetry>> SearchByNameAsync(string name);





}