import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GetQuestionService {

  constructor(private http: HttpClient) { }

  getQuestion(){
    return this.http.get('https://localhost:5001/api/questions', { 
      responseType: 'text',
    })
  }
}
