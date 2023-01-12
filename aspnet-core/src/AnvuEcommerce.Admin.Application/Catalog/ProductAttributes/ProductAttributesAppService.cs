using AnvuEcommerce.Admin.Permissions;
using AnvuEcommerce.Admin.ProductCategories;
using AnvuEcommerce.ProductAttributes;
using AnvuEcommerce.ProductCategories;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AnvuEcommerce.Admin.ProductAttributes
{
    [Authorize(AnvuEcommercePermissions.Attribute.Default, Policy = "AdminOnly")]
    public class ProductAttributesAppService : CrudAppService<
        ProductAttribute,
        ProductAttributeDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductAttributeDto,
        CreateUpdateProductAttributeDto>,
        IProductAttributesAppService
    {
        private readonly IRepository<ProductAttribute, Guid> _repository;
        public ProductAttributesAppService(IRepository<ProductAttribute, Guid> repository)
            : base(repository)
        {
            _repository = repository;

            GetPolicyName = AnvuEcommercePermissions.Attribute.Default;
            GetListPolicyName = AnvuEcommercePermissions.Attribute.Default;
            CreatePolicyName = AnvuEcommercePermissions.Attribute.Create;
            UpdatePolicyName = AnvuEcommercePermissions.Attribute.Update;
            DeletePolicyName = AnvuEcommercePermissions.Attribute.Delete;
        }
        [Authorize(AnvuEcommercePermissions.Attribute.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }
        [Authorize(AnvuEcommercePermissions.Attribute.Default)]

        public async Task<List<ProductAttributeInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<ProductAttribute>, List<ProductAttributeInListDto>>(data);
              
                }
        [Authorize(AnvuEcommercePermissions.Attribute.Default)]

        public async Task<PagedResultDto<ProductAttributeInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await _repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Label.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ProductAttributeInListDto>(totalCount, ObjectMapper.Map<List<ProductAttribute>, List<ProductAttributeInListDto>>(data));

        }
    }

}
