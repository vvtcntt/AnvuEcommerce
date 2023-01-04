import type { ProductType } from '../../products/product-type.enum';
import type { BaseListFilterDto } from '../models';

export interface CreateUpdateProductDto {
  manufacturerId?: string;
  name?: string;
  code?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  sellPrice: number;
  categoryId?: string;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPictureName?: string;
  thumbnailPictureContent?: string;
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
  categoryName?: string;
  categorySlug?: string;
}

export interface ProductInListDto {
  manufacturerId?: string;
  name?: string;
  code?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  categoryId?: string;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPicture?: string;
  id?: string;
  categoryName?: string;
  categorySlug?: string;
}

export interface ProductListFilterDto extends BaseListFilterDto {
  categoryId?: string;
}
