import { NgModule } from '@angular/core';
 
import {PanelModule} from 'primeng/panel';
import {TableModule} from 'primeng/table';
import {PaginatorModule} from 'primeng/paginator';
import {BlockUIModule} from 'primeng/blockui';
import {ButtonModule} from 'primeng/button';
import {DropdownModule} from 'primeng/dropdown';
import {InputTextModule} from 'primeng/inputtext';
import {ProgressSpinnerModule} from 'primeng/progressspinner';
 import {InputNumberModule} from 'primeng/inputnumber';
import {CheckboxModule} from 'primeng/checkbox';
import {InputTextareaModule} from 'primeng/inputtextarea';
import {EditorModule} from 'primeng/editor';
 import {BadgeModule} from 'primeng/badge';
import {ImageModule} from 'primeng/image';
import {ConfirmDialogModule} from 'primeng/confirmdialog';
 import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {CalendarModule} from 'primeng/calendar';
import { ProductComponent } from './product/product.component';
import { ProductDetailComponent } from './product/product-detail.component';
import { ProductAttributeComponent } from './product/product-attribute.component';
import { SharedModule } from 'primeng/api';
 import { AnvuSharedModule } from '../shared/modules/anvu-shared.module';
import { AttributeComponent } from './ProductAttribute/attribute.component';
import { AttributeDetailComponent } from './ProductAttribute/attribute-detail.component';
import { CatalogRoutingModule } from './catalog-routing.module';


@NgModule({
  declarations: [ProductComponent,ProductDetailComponent,ProductAttributeComponent,
  AttributeComponent,AttributeDetailComponent],
  imports: [SharedModule, CatalogRoutingModule,PanelModule,
    TableModule,
    PaginatorModule,
    BlockUIModule,
    ButtonModule,
    DropdownModule,
    InputTextModule,
    ProgressSpinnerModule,
    InputNumberModule,
    CheckboxModule,
    InputTextareaModule,
    EditorModule,
    AnvuSharedModule,
    BadgeModule,
    ImageModule,
    ConfirmDialogModule ,
    FormsModule,
    ReactiveFormsModule,
    CalendarModule
  ],
    entryComponents:[
      ProductDetailComponent,
      ProductAttributeComponent,
      AttributeDetailComponent
    ]
})
export class CatalogModule {}
