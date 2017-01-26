import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'friends',
    template: require('./friends.component.html')
})

export class FriendsComponent {
    public friend: Friend[] = [];
    public frienddetials: FriendDetails[] = [];

    myName: string;
    constructor(public http: Http) {
        this.myName = "Shawn";
        //http.get('/api/friendapi/Friend').subscribe(result => {
        //    this.friend = result.json();
        //});

        this.getFriendData();
    }
    getFriendData() {
        this.http.get('/api/friendapi/Friend').subscribe(result => {
            this.friend = result.json();
        });
    }


}

export interface Friend {
    FriendId: number;
    FirstName: string;
    LastName: string;
    Email: string;
    Address: string;
    City: string;
    PostalCode: string;
    Country: string;
    Notes: string;
}

export interface FriendDetails {
    FriendDetailId: number;
    FriendId: number;
    Major: string;
    Year: string;
    Term: string;
    Grade: string;
}