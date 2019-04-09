import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-business-items',
  templateUrl: './fetch-business-items.component.html'
})
export class FetchBusinessItemsComponent {
  public period: Period;

  constructor(http: HttpClient, @Inject('API_URL') baseUrl: string) {
    http.get<Period>(baseUrl + 'api/business/period/2019-04-09/2019-04-16').subscribe(result => {
      this.period = result;
    }, error => console.error(error));
  }
}

interface BusinessItem
{
    Description: string;
    Category: string;
    StartDate:Date;
    EndDate:Date;
    StartTime: string;
    EndTime: string;
    ApplicableMembers: Member[]
}

interface Member
{
    Party: string;
    MemberFrom: string;
    FullTitle:string;
}

interface Period
{
    PeriodStart: Date;
    PeriodEnd: Date;
    BusinessItems: BusinessItem[]
}


