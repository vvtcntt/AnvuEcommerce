﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace AnvuEcommerce.Admin.ProductCategories
{
    public interface IProductCategoriesAppService:ICrudAppService<
        ProductCategoryDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductCategoryDto, 
        CreateUpdateProductCategoryDto>
    {
        Task<PagedResultDto<ProductCategoryInListDto>> GetListFilterAsync(BaseListFilterDto input);
        Task<List<ProductCategoryInListDto>> GetListAllAsync();
        Task DeleteMultipleAsync(IEnumerable<Guid> ids);
    }
}
