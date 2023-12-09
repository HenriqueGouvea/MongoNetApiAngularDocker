import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListComponent } from './product/list/list.component';
import { HttpClientModule } from '@angular/common/http';
import { InsertComponent } from './product/insert/insert.component'
import { ReactiveFormsModule } from '@angular/forms';
import {NgcCookieConsentModule, NgcCookieConsentConfig} from 'ngx-cookieconsent';

const cookieConfig: NgcCookieConsentConfig = {
  cookie: {
    domain: 'localhost'
  },
  palette: {
    popup: {
      background: '#000'
    },
    button: {
      background: '#e7e7e7'
    }
  },
  theme: 'edgeless',
  type: 'opt-out'
};

@NgModule({
  declarations: [
    AppComponent,
    ListComponent,
    InsertComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgcCookieConsentModule.forRoot(cookieConfig),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
