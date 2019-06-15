import {Component, OnInit} from '@angular/core';
import {dataSlide} from './slide-data';

@Component({
  selector: 'app-slide-generate',
  templateUrl: './slide-generate.component.html',
  styleUrls: ['./slide-generate.component.css']
})
export class SlideGenerateComponent implements OnInit {
  imagePathSlides = '../assets/SlidesImages/';
  dataSlides = dataSlide;
  constructor() { }

  ngOnInit() {
  }

}
