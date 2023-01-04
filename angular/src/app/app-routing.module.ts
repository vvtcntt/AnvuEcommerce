import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppLayoutComponent } from './layout/app.layout.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    loadChildren: () => import('./home/home.module').then(m => m.HomeModule),
    component:AppLayoutComponent
  } ,
  {
    path: 'auth',
     loadChildren: () => import('./auth/auth.module').then(m => m.AuthModule),
   }
   ,
  {
    path: 'product',
     loadChildren: () => import('./product/product.module').then(m => m.ProductModule),
     component:AppLayoutComponent
    },
    {
      path: 'attribute',
       loadChildren: () => import('./ProductAttribute/attribute.module').then(m => m.AttributeModule),
       component:AppLayoutComponent
      }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
