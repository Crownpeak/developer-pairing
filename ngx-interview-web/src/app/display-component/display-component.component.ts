import { AssetsService } from './../services/assets.service';
import { Observable } from 'rxjs/Observable';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-display-component',
  templateUrl: './display-component.component.html',
  styleUrls: ['./display-component.component.css']
})


export class DisplayComponentComponent implements OnInit {

  constructor(private assetsService: AssetsService) { }

  results: any[];

  ngOnInit() {
    this.assetsService.getAssts().subscribe(res => {
      this.results = res;
    })
  }


}

