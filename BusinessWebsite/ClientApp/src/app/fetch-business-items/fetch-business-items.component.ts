import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from "@angular/router";
import * as moment from 'moment';

@Component({
  selector: 'app-fetch-business-items',
  templateUrl: './fetch-business-items.component.html'
})
export class FetchBusinessItemsComponent {
  public period: Period;

  public startDate: any;
  public endDate: any;
  public actualStartDate: any;
  public actualEndDate: any;
  public lastStartDate: any;
  public lastEndDate: any;
  public nextStartDate: any;
  public nextEndDate: any;

  constructor(route: ActivatedRoute, router: Router, http: HttpClient, @Inject('API_URL') baseUrl: string) {

    let startDateParam = route.snapshot.paramMap.get("startDate");

    route.params.subscribe((params = {}) => {
      if(startDateParam === null){
        this.initState();
        router.navigateByUrl(`/business/period/${this.startDate}/${this.endDate}`)
      } else {
        this.updateState(route, baseUrl, http);
      }
    });

    if(startDateParam === null){
      this.initState();
      router.navigateByUrl(`/business/period/${this.startDate}/${this.endDate}`)
    } else {
      this.updateState(route, baseUrl, http);
    }
  }

  setState(){
      this.lastStartDate = moment(this.startDate).add(-7, 'days').format("YYYY-MM-DD");
      this.lastEndDate = moment(this.startDate).add(-1, 'days').format("YYYY-MM-DD");
      this.nextStartDate = moment(this.endDate).add(1, 'days').format("YYYY-MM-DD");
      this.nextEndDate = moment(this.endDate).add(7, 'days').format("YYYY-MM-DD");
  }

  initState(){
      const today = moment();
      this.startDate = today.startOf('week').format("YYYY-MM-DD");
      this.endDate = today.endOf('week').format("YYYY-MM-DD");
      this.actualStartDate = today.startOf('week').format("YYYY-MM-DD");
      this.actualEndDate = today.endOf('week').format("YYYY-MM-DD");
      this.setState();
  }

  updateState(route, baseUrl, http){
      this.startDate = route.snapshot.paramMap.get("startDate");
      this.endDate = route.snapshot.paramMap.get("endDate");
      http.get<Period>(baseUrl + `api/business/period/${this.startDate}/${this.endDate}`).subscribe(result => {
        this.period = result;
      }, error => console.error(error));
      this.setState();
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


