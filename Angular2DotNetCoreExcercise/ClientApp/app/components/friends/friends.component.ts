import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'friends',
    template: require('./friends.component.html')
})

export class FriendsComponent {
    public friend: Friend[] = [];
    public frienddetails: FriendDetails[] = [];

    myName: string;
    activeRow: string = "0";

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
    getFriendDetails(friendId) {
        this.http.get('/api/friendapi/Details/' + friendId).subscribe(result => {
            this.frienddetails = result.json();
        });
        this.activeRow = friendId;
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