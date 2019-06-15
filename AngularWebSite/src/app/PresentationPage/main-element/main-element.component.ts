import {Component, OnInit} from '@angular/core';

export interface PathIMG {
  path: string;
}

@Component({
  selector: 'app-main-element',
  templateUrl: './main-element.component.html',
  styleUrls: ['./main-element.component.css',
    'Slides.css'],
})
export class MainElementComponent implements OnInit {
  constructor() {
  }
  public imagesPath: PathIMG[] = [
    {path: '../assets/SlidesImages/LeftArrow.png'},
    {path: '../assets/SlidesImages/RightArrow.png'},
    {path: '../assets/SlidesImages/garbage.png'}
  ];
  ngOnInit() {
  }

}

