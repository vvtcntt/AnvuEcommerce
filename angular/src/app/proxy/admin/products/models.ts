import type { ProductType } from '../../products/product-type.enum';
import type { BaseListFilterDto } from '../models';

export interface CreateUpdateProductDto {
  name?: string;
  code?: string;
  slug?: string;
  sortOrder: number;
  coverPicture?: string;
  visibility: boolean;
  isActive: boolean;
  sellPrice: number;
  parentId?: string;
  seoMetaDescription?: string;
}

export interface ProductDto {
  manufacturerId?: string;
  name?: string;
  code?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  sellPrice: number;
  isActive: boolean;
  categoryId?: string;
  slug?: string;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPicture?: string;
  id?: string;
}

export interface ProductInListDto {
  manufacturerId?: string;
  name?: string;
  code?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visiblity: boolean;
  isActive: boolean;
  categoryId?: string;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPicture?: string;
}

export interface ProductListFilterDto extends BaseListFilterDto {
  categoryId?: string;
}
