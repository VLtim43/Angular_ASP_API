import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent implements OnInit {
  ngOnInit(): void {
    this.GetEventos();
  }

  public eventos: any;

  public GetEventos(): void {
    this.http.get(`https://localhost:5001/api/eventos`).subscribe(
      respose => this.eventos = respose ,
      error => console.log("ERROR" + error)
    )
  }
  constructor(private http: HttpClient) {}
}
