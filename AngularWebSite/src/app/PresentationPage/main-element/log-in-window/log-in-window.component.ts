import { Component, OnInit } from '@angular/core';

export interface PathImage {
  path: string;
}

@Component({
  selector: 'app-log-in-window',
  templateUrl: './log-in-window.component.html',
  styleUrls: ['./log-in-window.component.css']
})
export class LogInWindowComponent implements OnInit {
  constructor() { }
  path: PathImage[] = [
    {path: '../assets/LogInImages/windows-8.png'},
    {path: '../assets/LogInImages/google-plus.png'},
    {path: ''}
  ];
  ngOnInit() {
  }

}
