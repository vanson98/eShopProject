using System.Collections.Generic;
using System.Threading.Tasks;
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
 
        // Update những thông tin mô tả chung
        Task<int> Update(ProductUpdateRequest request);
        
        // Update giá nên để riêng ra
        Task<bool> UpdatePrice(int productId, decimal newPrice);

        // Update stock 
        Task<bool> UpdateStock(int productId, int addedQuantity);
       
        Task<int> Delete(int productId);




        // Get All Ảnh của sản phẩm
        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        // Update thông tin ảnh chư không update file vật lý
        Task<int> UpdateImages(int imageId, string caption, bool isDefault);

       
    }
}
