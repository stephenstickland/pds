import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-fetch-business-item-details',
  templateUrl: './fetch-business-item-details.component.html'
})
export class FetchBusinessItemDetailsComponent {
  public item: BusinessItem;
  public id: string;

  constructor(route: ActivatedRoute, http: HttpClient, @Inject('API_URL') baseUrl: string) {

    this.id = route.snapshot.paramMap.get("id")

    http.get<BusinessItem>(baseUrl + 'api/business/period/2019-04-09/2019-04-16/' + this.id).subscribe(result => {
      this.item = result;
    }, error => console.error(error));
  }

  ngOnInit() {

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


