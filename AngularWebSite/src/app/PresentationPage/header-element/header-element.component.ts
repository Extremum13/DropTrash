import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header-element',
  templateUrl: './header-element.component.html',
  styleUrls: ['./header-element.component.css']
})
export class HeaderElementComponent implements OnInit {
  logInImagePath = '../assets/HeaderImages/LogInArrowImg.png';
  constructor() { }

  ngOnInit() {
  }

}
