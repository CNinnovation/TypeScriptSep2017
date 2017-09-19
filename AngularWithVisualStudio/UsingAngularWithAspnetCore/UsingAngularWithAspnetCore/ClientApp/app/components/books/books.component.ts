import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'book-samples',
    templateUrl: './books.component.html'
})
export class BooksComponent {
    public books: Book[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Books/SampleBooks').subscribe(result => {
            this.books = result.json() as Book[];
        }, error => console.error(error));
    }
}

interface Book {
    bookId: number;
    title: string;
    publisher: string;
}
