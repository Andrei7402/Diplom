import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { PlaceComponent } from './place/place.component';
import { MenuComponent } from './menu/menu.component';
import { BurgerComponent } from './menu/burger.component';
import { SushiComponent } from './menu/sushi.component';
import { DessertComponent } from './menu/dessert.component';
import { SaladComponent } from './menu/salad.component';
import { UsersComponent } from './users/users.component';
import { TenantsComponent } from './tenants/tenants.component';
import { RolesComponent } from 'app/roles/roles.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: AppComponent,
                children: [
                    { path: 'home', component: HomeComponent,  canActivate: [AppRouteGuard] },
                    { path: 'users', component: UsersComponent, data: { permission: 'Pages.Users' }, canActivate: [AppRouteGuard] },
                    { path: 'roles', component: RolesComponent, data: { permission: 'Pages.Roles' }, canActivate: [AppRouteGuard] },
                    { path: 'tenants', component: TenantsComponent, data: { permission: 'Pages.Tenants' }, canActivate: [AppRouteGuard] },
                    { path: 'about', component: AboutComponent, canActivate: [AppRouteGuard] },
                    { path: 'place', component: PlaceComponent, canActivate: [AppRouteGuard] },
                    { path: 'menu', component: MenuComponent, canActivate: [AppRouteGuard] },
                    { path: 'burger', component: BurgerComponent, canActivate: [AppRouteGuard] },
                    { path: 'sushi', component: SushiComponent, canActivate: [AppRouteGuard] },
                    { path: 'dessert', component: DessertComponent, canActivate: [AppRouteGuard] },
                    { path: 'salad', component: SaladComponent, canActivate: [AppRouteGuard] },
                    { path: 'update-password', component: ChangePasswordComponent, canActivate: [AppRouteGuard] }
                ]
            }
        ])
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }
