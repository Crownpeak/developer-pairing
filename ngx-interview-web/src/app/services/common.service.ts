import { Injectable } from '@angular/core';

@Injectable()
export class CommonService {

  constructor() { }

  getBaseUrl() {
    return 'http://localhost:8080/api/'
  }

}
