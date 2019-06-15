import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { HeaderElementComponent } from './PresentationPage/header-element/header-element.component';
import { MainElementComponent } from './PresentationPage/main-element/main-element.component';
import { FooterElementComponent } from './PresentationPage/footer-element/footer-element.component';
import { SlideGenerateComponent } from './PresentationPage/slide-generate/slide-generate.component';
import { LogInWindowComponent } from './PresentationPage/main-element/log-in-window/log-in-window.component';
import { RegistrationWindowComponent } from './PresentationPage/main-element/registration-window/registration-window.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderElementComponent,
    MainElementComponent,
    FooterElementComponent,
    SlideGenerateComponent,
    LogInWindowComponent,
    RegistrationWindowComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
