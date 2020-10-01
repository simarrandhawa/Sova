import { Component, OnInit } from '@angular/core';
import { GetQuestionService } from '../get-question.service';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent implements OnInit {
public question;
  constructor(private gqs: GetQuestionService) { }

  ngOnInit(): void {
    this.question = this.gqs.getQuestion();
  }

}
