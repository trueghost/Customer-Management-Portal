import { Component, OnInit , NgModule, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { CmpServiceService } from 'src/app/services/cmp-service.service';
import { SearchdataService } from 'src/app/services/searchdata.service';
import {HttpClient} from '@angular/common/http'; 

@Component({
  selector: 'app-show-customers',
  templateUrl: './show-customers.component.html',
  styleUrls: ['./show-customers.component.scss']
})

export class ShowCustomersComponent implements OnInit {
  countryDetails$!:Observable<any[]>;
  stateDetails$!:Observable<any[]>;
  customerDetails$!:Observable<any[]>;
  customerDetails:any=[];
  countryDetails:any=[];
  stateDetails:any=[];
  dtOptions: any = {};
  model : any={}; 
  
  
  // Mapping
  customerDetailsMap:Map<number, string> = new Map()
  countryDetailsMap:Map<number, string> = new Map()
  stateDetailsMap:Map<number, string> = new Map()
  CmpServiceService: any;

  

  constructor(private service:CmpServiceService, private searchdataService:SearchdataService) {}

  @Input()
  customerId: number=0;

  ngOnInit(): void {
    // this.customerDetails$ = this.service.getCustomerDetails();
    this.countryDetails$ = this.service.getCountryDetails();
    this.stateDetails$ = this.service.getStateDetails();
    // this.customerId = this.customer.customerId;
    this.refreshcountryDetailsMap();
    this.refreshstateDetailsMap();
    this.showdata();
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5,
      lengthMenu : [5, 10, 25],
      processing: true
    };
   //Checkbox click function
    $('#example').on('click', 'tbody td .disableRow', function () {
      
      //checkbox check
      if (!this.click) {
        $(this).closest('tr').removeClass("row-select");
        alert("Status Enabled");
      }
      else
      {
        $(this).closest('tr').addClass("row-select");
        alert("Status Disabled");
      }
      
  })
  }

  allProducts: any;
  isFetching: boolean = false;

  showdata(){
    // this.service.getCustomerDetails().subscribe((products:any) => {  
      this.searchdataService.showdata().subscribe((products:any) => {  
      this.allProducts = products;
      this.isFetching = false;
  }) 
  }

  searchdata() {
    this.searchdataService.searchdata(this.model).subscribe((res: any) => {  
        this.allProducts=res;   
        console.log(this.allProducts);   
    })  
  }


  modalTitle:string = '';
  activateAddCustomersComponent:boolean = false;
  customer:any;

  modalAdd(){
    this.customer = {
      customerId:0,
      name:null,
      phNo:null,
      email:null,
      countryId:null,
      stateId:null,
      remarks:null,
      gstEnable:null,
      createdDate:null
    }
    this.modalTitle = "Add Customers";
    this.activateAddCustomersComponent = true;
  }

  modalEdit(item:any){
    this.customer = item;
    this.modalTitle = "Edit Customer";
    this.activateAddCustomersComponent = true;
  }

  searchText: string = '';
  onSearchTextEntered(searchValue: string){
    this.searchText = searchValue;
    // console.log(this.SearchText);
  }

  StatusChange(customerId: number){
    this.searchdataService.statusChange(customerId).subscribe();
    setTimeout(() => {
      location.reload();
    }, 3000);
  }

  modalClose(){
    this.activateAddCustomersComponent = false;
    this.countryDetails$ = this.service.getCountryDetails();
  }

  refreshcountryDetailsMap(){
    this.service.getCountryDetails().subscribe(data =>{
      this.countryDetails = data;
      
      for(let i=0; i< data.length; i++)
      {
        this.countryDetailsMap.set(this.countryDetails[i].id,this.countryDetails[i].
          countryName);
      }
    })
  }

  refreshstateDetailsMap(){
    this.service.getStateDetails().subscribe(data =>{
      this.stateDetails = data;
      
      for(let i=0; i< data.length; i++)
      {
        this.stateDetailsMap.set(this.stateDetails[i].id,this.stateDetails[i].
          stateName);
      }
    })
  }

  
 
 

}