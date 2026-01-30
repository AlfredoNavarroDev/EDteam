import { Component } from '@angular/core';

@Component({
  selector: 'app-card',
  standalone: false,
  templateUrl: './card.html',
  styleUrl: './card.css',
})
export class Card {
  course:string = 'Angular desde cero';
  cardData = {
    imageUrl: 'https://colorlib.com/wp/wp-content/uploads/sites/2/angular-logo.png',
    title: 'Angular',
    description: 'Descripción breve',
  }

  onTitleChange(event: Event):void {
    this.cardData.title = (event.target as HTMLInputElement).value;
  }

  changeTitle():void {
    this.cardData.title = 'Nuevo título';
  }
}
