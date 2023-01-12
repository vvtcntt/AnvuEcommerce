import { PermissionGuard } from '@abp/ng.core';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { AttributeComponent } from './ProductAttribute/attribute.component';
 
const routes: Routes = [
  { path: 'product', component: ProductComponent,
  canActivate: [PermissionGuard],
  data: {
    requiredPolicy: 'AnvuEcomAdminCatalog.Product',
  } },
  { path: 'attribute', component: AttributeComponent,

  canActivate: [PermissionGuard],
  data: {
    requiredPolicy: 'AnvuEcomAdminCatalog.Attribute',
  }}
]
;

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CatalogRoutingModule {}
