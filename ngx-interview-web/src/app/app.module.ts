import { AssetFieldsService } from './services/assetfields.service';
import { AssetsService } from './services/assets.service';
import { CommonService } from './services/common.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule, JsonpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { DisplayComponentComponent } from './display-component/display-component.component';

@NgModule({
  declarations: [
    AppComponent,
    DisplayComponentComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    JsonpModule
  ],
  providers: [
    AssetsService,
    AssetFieldsService,
    CommonService
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
