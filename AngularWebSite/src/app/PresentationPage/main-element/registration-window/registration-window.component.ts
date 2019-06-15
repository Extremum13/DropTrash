import { Component, OnInit } from '@angular/core';


export interface IRegData {
  data: string;
}

@Component({
  selector: 'app-registration-window',
  templateUrl: './registration-window.component.html',
  styleUrls: ['./registration-window.component.css']
})

export class RegistrationWindowComponent implements OnInit {
  helpImagePath = '../assets/RegistrationImages/question-mark.png';
  closeImagePath = '../assets/RegistrationImages/close.png';
  public regMainData: IRegData[] = [
    {data: 'ПРІЗВИЩЕ:'},
    {data: 'ІМ’Я:'},
    {data: 'ПО БАТЬКОВІ:'}
  ];
  public regData: IRegData[] = [
    {data: 'ЕЛЕКТРОННА СКРИНЬКА:'},
    {data: 'АДРЕСА ПРОЖИВАННЯ:'},
    {data: 'ПОШТОВИЙ ІНДЕКС:'},
    {data: 'ПАРОЛЬ:'},
    {data: 'ПОВТОРІТЬ ПАРОЛЬ:'}
  ];
  constructor() { }
  ngOnInit() {
  }
}
