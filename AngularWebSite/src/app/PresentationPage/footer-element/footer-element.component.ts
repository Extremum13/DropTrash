import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer-element',
  templateUrl: './footer-element.component.html',
  styleUrls: ['./footer-element.component.css']
})
export class FooterElementComponent implements OnInit {
  iSoImagePath = '../assets/FooterImages/iso-file-rounded-rectangular-outlined-interface-symbol.png';
  constructor() { }

  ngOnInit() {
  }

}
