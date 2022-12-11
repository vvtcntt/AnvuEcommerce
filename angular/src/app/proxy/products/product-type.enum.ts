import { mapEnumToOptions } from '@abp/ng.core';

export enum ProductType {
  Single = 0,
  Grouped = 1,
  Configurable = 2,
  Bundle = 3,
  Virtaul = 4,
  Downloadable = 5,
}

export const productTypeOptions = mapEnumToOptions(ProductType);
