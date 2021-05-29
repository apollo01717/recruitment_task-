import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {Answer} from '../models/Answer';
import {environment} from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AnswerService {

  private url = 'answer';

  constructor(private httpClient: HttpClient) {}

  public sendAnswers(answers: Answer[]): Observable<Answer[]>{
    return this.httpClient.post<Answer[]>(environment.serverUrl + this.url, answers);
  }
}
