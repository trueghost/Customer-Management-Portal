import { Component, Input , OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { CmpServiceService } from 'src/app/services/cmp-service.service';
import { CustomersComponent } from '../customers.component';
import { FormControl,FormBuilder,FormGroup,FormArray,Validators } from '@angular/forms';
@Component({
  selector: 'app-add-customers',
  templateUrl: './add-customers.component.html',
  styleUrls: ['./add-customers.component.scss']
})
export class AddCustomersComponent implements OnInit {

  customerList$!: Observable<any[]>;
  countryList$!: Observable<any[]>;
  stateList$!: Observable<any[]>;
  

  constructor(private service:CmpServiceService){}
  

  @Input() customer:any;
  customerId: number=0;
  name: string= "";
  phNo: string= "";
  email: string= "";
  countryId!: number;
  stateId!: number;
  remarks: string= "";
  gstEnable = false;
  createdDate: string= "";
  status!: number;

  ngOnInit(): void {
    this.customerId = this.customer.customerId;
    this.name = this.customer.name;
    this.phNo = this.customer.phNo;
    this.email = this.customer.email;
    this.countryId = this.customer.countryId;
    this.stateId = this.customer.stateId;
    this.remarks = this.customer.remarks;
    this.gstEnable = this.customer.gstEnable;
    this.createdDate = this.customer.createdDate;
    this.status = this.customer.status;
    this.customerList$ = this.service.getCustomerDetails();
    this.countryList$ = this.service.getCountryDetails();
    this.stateList$ = this.service.getStateDetails();
    
  }

  addCustomers()
  {
    // debugger;
    var customer = {
    "name":this.name,
    "phNo":this.phNo,
    "email":this.email,
    "countryId":this.countryId,
    "stateId":this.stateId,
    "remarks":this.remarks,
    "gstEnable":this.gstEnable ? 'Yes' : 'No' ,
    "createdDate":this.createdDate,
    "status": 2
    }
    // var customer = {
    //   "name": "sauravtajith",
    //   "phNo": "55684884",
    //   "email": "saurat@gmail.com",
    //   "countryId": 1,
    //   "stateId": 5,
    //   "remarks": "great",
    //   "gstEnable": 1,
    //   "createdDate": "01/02/2002"
    // }
    this.service.addCustomers(customer).subscribe(res =>
      {
        var closeModalBtn = document.getElementById('add-modal-close');
        if(closeModalBtn) {
          closeModalBtn.click();
        }

        var showAddSuccess = document.getElementById('add-success-alert');
        if(showAddSuccess){
          showAddSuccess.style.display = "block";
        }
        
        setTimeout(function(){
          if(showAddSuccess){
            showAddSuccess.style.display= "none"
            location.reload();
          }
        },4000);
      })
  
  }

  updateStates() {
    if (this.countryId == 1) {
      this.stateId = 4;
    } else if (this.countryId == 2) {
      this.stateId = 5;
    }
  }

  updateCustomers(){
    var customer = {
    "customerId":this.customerId,
    "name":this.name,
    "phNo":this.phNo,
    "email":this.email,
    "countryId":this.countryId,
    "stateId":this.stateId,
    "remarks":this.remarks,
    "gstEnable":this.gstEnable ? 'Yes' : 'No',
    "createdDate":this.createdDate,
    "status": this.status
    }
    var customerId:number = this.customerId;
    this.service.updateCustomers(customerId,customer).subscribe(res =>
      {
        var closeModalBtn = document.getElementById('add-modal-close');
        if(closeModalBtn) {
          closeModalBtn.click();
        }

        var showUpdateSuccess = document.getElementById('update-success-alert');
        if(showUpdateSuccess){
          showUpdateSuccess.style.display = "block";
        }
        
        setTimeout(function(){
          if(showUpdateSuccess){
            showUpdateSuccess.style.display= "none"
            location.reload();
          }
        },4000);
      })

  
  }
  
}
