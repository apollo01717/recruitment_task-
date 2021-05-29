import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Question} from '../models/Question';
import {Observable} from 'rxjs';
import {environment} from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  private url = 'question';

  constructor(private httpClient: HttpClient) {}

  public getQuestions(): Observable<Question[]>{
    return this.httpClient.get<Question[]>(environment.serverUrl + this.url);
  }

}
