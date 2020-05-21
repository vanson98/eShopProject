using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.ProductImage;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.Application.Catalog.Products
{
    // Các service thuộc phần hệ thống của admin
    public interface IManageProductService
    {
        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<int> Create(ProductCreateRequest request);
        
        Task AddViewCount(int productId);
 
        Task<int> Update(ProductUpdateRequest request);
        
        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);
       
        Task<int> Delete(int productId);

        // image
        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage( int imageId);

        Task<int> UpdateImage( int imageId, ProductImageUpdateRequest request);

       
    }
}
