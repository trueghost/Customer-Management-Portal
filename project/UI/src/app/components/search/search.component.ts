import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CmpServiceService } from 'src/app/services/cmp-service.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {

  constructor(private service:CmpServiceService) { }

  ngOnInit(): void {
  }

  enteredSerchValue: string = '';

  @Output()
  searchTextChanged: EventEmitter<string> = new EventEmitter<string>();

  onSearchTextChanged(){
    this.searchTextChanged.emit(this.enteredSerchValue);
  }


}
