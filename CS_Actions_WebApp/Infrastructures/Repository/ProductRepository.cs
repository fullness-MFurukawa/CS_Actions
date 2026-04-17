using Microsoft.EntityFrameworkCore;
using CS_Actions_WebApp.Infrastructures.Entity;
using CS_Actions_WebApp.Infrastructures.Context;
namespace CS_Actions_WebApp.Infrastructures.Repository;
/// <summary>
/// 商品情報のデータアクセスを担うリポジトリクラス
/// </summary>
public class ProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// 全ての商品をID順に取得する
    /// </summary>
    public async Task<List<Product>> SelectAllAsync()
    {
        return await _context.Products.OrderBy(p => p.Id).ToListAsync();
    }
}