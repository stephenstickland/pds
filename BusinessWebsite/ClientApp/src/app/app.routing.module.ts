import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FetchBusinessItemsComponent } from './fetch-business-items/fetch-business-items.component';
import { FetchBusinessItemDetailsComponent } from './fetch-business-item-details/fetch-business-item-details.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'business/period', component: FetchBusinessItemsComponent, runGuardsAndResolvers: 'always' },
  { path: 'business/period/:startDate/:endDate', component: FetchBusinessItemsComponent, runGuardsAndResolvers: 'always' },
  { path: 'business/item/:startDate/:endDate/:id', component: FetchBusinessItemDetailsComponent, runGuardsAndResolvers: 'always' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
      scrollPositionRestoration: 'enabled',
      anchorScrolling: 'enabled',
      onSameUrlNavigation: 'reload'
  })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
