import {Component, OnDestroy, OnInit} from '@angular/core';
import {Option} from '../../shared/models/Option';
import {Question} from '../../shared/models/Question';
import {QuestionService} from '../../shared/services/question.service';
import {Answer} from '../../shared/models/Answer';
import {AnswerService} from '../../shared/services/answer.service';
import {Subscription} from 'rxjs';

@Component({
  selector: 'app-questionnaire',
  templateUrl: './questionnaire.component.html',
  styleUrls: ['./questionnaire.component.scss']
})
export class QuestionnaireComponent implements OnInit, OnDestroy{

  public name: string;
  public selectedOption: Option[] = [];
  public questions: Question[];
  private subscriptions: Subscription[] = [];

  constructor(private questionService: QuestionService, private answerService: AnswerService) {
  }

  ngOnInit(): void {
    const subscription = this.questionService.getQuestions().subscribe(data => {
        this.questions = data;
      });
    this.subscriptions.push(subscription);
  }

  public isDisabledSendButton(): boolean {
    return !(this.name !== undefined && this.name.length > 0 && this.selectedOption.length > 0);
  }

  public selectOption(option: Option): void {
    if (!this.selectedOption.some(el => el.id === option.id)) {
      this.selectedOption.push(option);
    } else {
      this.selectedOption.forEach((el, index) => {
        if (el.id === option.id) {
          this.selectedOption.splice(index, 1);
        }
      });
    }
  }

  public sendQuestionnaire(): void {
    const subscription = this.answerService.sendAnswers(this.prepareAnswers()).subscribe();
    this.subscriptions.push(subscription);

  }

  private prepareAnswers(): Answer[] {
    const answers: Answer[] = [];
    this.selectedOption.forEach(option => {
      const answer: Answer = {
        optionId: option.id,
        userName: this.name
      };
      answers.push(answer);
    });
    return answers;
  }

  ngOnDestroy(): void {
    this.subscriptions.forEach((subscription) => subscription.unsubscribe());
  }
}
