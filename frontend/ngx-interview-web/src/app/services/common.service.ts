import { Injectable } from '@angular/core';

@Injectable()
export class CommonService {

  constructor() { }

  getBaseUrl() {
    return this.getCSharpApiUrl();
  }

  getCSharpApiUrl() {
    return 'http://localhost:63477/api/';
  }

  getJavaApiUrl() {
    return 'http://localhost:63477/api/';
  }

}
