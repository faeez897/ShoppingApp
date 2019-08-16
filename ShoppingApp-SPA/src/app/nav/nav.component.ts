import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  users: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getUsers();
  }

  // we want to call this method when our component loads
  getUsers() {
    this.http.get('http://localhost:5000/api/users').subscribe(reponse => {
      this.users = reponse;
      console.log(this.users);
    }, error => {
      console.log(error);
    });
  }
}
