import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser'; 

import { AccountOwnerComponent } from './app.accountowner';
import { RenderTargetComponent } from './app.routingcomponent';
import {routing} from './app.routing';
import { LocationStrategy, HashLocationStrategy } from '@angular/common'; 


@NgModule({

    imports: [ BrowserModule, 
                    routing], 

    declarations: [AccountOwnerComponent, 
                    RenderTargetComponent],

    providers: [{provide: LocationStrategy, useClass: HashLocationStrategy}],
    bootstrap: [RenderTargetComponent]
})

export class RoutingModule{}


platformBrowserDynamic().bootstrapModule(RoutingModule);