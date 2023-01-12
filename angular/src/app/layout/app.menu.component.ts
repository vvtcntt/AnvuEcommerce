import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { LayoutService } from './service/app.layout.service';

@Component({
    selector: 'app-menu',
    templateUrl: './app.menu.component.html'
})
export class AppMenuComponent implements OnInit {

    model: any[] = [];

    constructor(public layoutService: LayoutService) { }

    ngOnInit() {
        this.model = [
            {
                label: 'Home',
                items: [
                    { label: 'Trang chủ', icon: 'pi pi-fw pi-home', routerLink: ['/'] }
                ]
            },
            {
                label: 'Sản phẩm',
                items: [
                    { label: 'Danh sách sản phẩm', 
                    icon: 'pi pi-fw pi-id-card', 
                    routerLink: ['/catalog/product'] ,
                    permission: 'AnvuEcomAdminCatalog.Product',
                },
                    { label: 'Danh sách thuộc tính', 
                    icon: 'pi pi-fw pi-id-card', 
                    routerLink: ['/catalog/attribute'],
                    permission: 'AnvuEcomAdminCatalog.Attribute',
                 },
                ]
            }
            ,
            {
                label: 'Hệ Thống',
                items: [
                    { label: 'Danh sách quyền', icon: 'pi pi-fw pi-id-card', routerLink: ['/system/role'],permission: 'AbpIdentity.Roles', },
                    { label: 'Danh sách người dùng', icon: 'pi pi-fw pi-id-card', routerLink: ['/system/user'],permission: 'AbpIdentity.Users' },
                ]
            }
             
        ];
    }
}
