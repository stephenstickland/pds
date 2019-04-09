import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FetchBusinessItemsComponent } from './fetch-business-items/fetch-business-items.component';
import { FetchBusinessItemDetailsComponent } from './fetch-business-item-details/fetch-business-item-details.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'business', component: FetchBusinessItemsComponent },
  { path: 'business/:id', component: FetchBusinessItemDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
      scrollPositionRestoration: 'enabled',
      anchorScrolling: 'enabled'
  })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
